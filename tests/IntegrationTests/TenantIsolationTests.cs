using System.Runtime.CompilerServices;
using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Interceptors;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using Testcontainers.PostgreSql;

namespace IntegrationTests;

public class TestableTenantContext : ITenantContext
{
    public Guid TenantId { get; set; }
    public string TenantSlug { get; set; } = string.Empty;
    public PlanTier TenantPlan { get; set; } = PlanTier.Free;
    public bool IsResolved { get; set; }
}

public class TenantIsolationTests : IAsyncLifetime
{
    private readonly PostgreSqlContainer _postgres = new PostgreSqlBuilder("postgres:16-alpine")
        .WithDatabase("mtsp_test")
        .WithUsername("mtsp")
        .WithPassword("mtsp")
        .Build();

    private string _connectionString = null!;

    public async Task DisposeAsync()
    {
        await _postgres.DisposeAsync();
    }

    public async Task InitializeAsync()
    {
        await _postgres.StartAsync();
        _connectionString = _postgres.GetConnectionString();
    }

    private async Task<AppDbContext> CreateDbContextAsync(TestableTenantContext tenantContext)
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseNpgsql(_connectionString)
            .UseSnakeCaseNamingConvention()
            .AddInterceptors(new RlsConnectionInterceptor(tenantContext))
            .Options;

        var context = new AppDbContext(options, tenantContext);
        await context.Database.MigrateAsync();
        return context;
    }

    private async Task SeedDataAsync()
    {
        var tenantContext = new TestableTenantContext { IsResolved = false };
        await using var context = await CreateDbContextAsync(tenantContext);

        var tenantA = Tenant.Create("tenant-a", "Tenant A Corp", PlanTier.Pro);
        var tenantB = Tenant.Create("tenant-b", "Tenant B Inc", PlanTier.Free);

        context.Tenants.Add(tenantA);
        context.Tenants.Add(tenantB);
        await context.SaveChangesAsync();

        // Insert projects via raw SQL to bypass RLS + query filters during seeding
        await using var conn = new NpgsqlConnection(_connectionString);
        await conn.OpenAsync();

        await using var cmd = conn.CreateCommand();
        cmd.CommandText = "SET app.tenant_id = '00000000-0000-0000-0000-000000000000'";
        await cmd.ExecuteNonQueryAsync();

        var projectA1Id = Guid.NewGuid();
        var projectA2Id = Guid.NewGuid();
        var projectB1Id = Guid.NewGuid();

        cmd.CommandText = $"""
            INTSERT INTO projects (id, name, tenant_id, created_at, updated_at, deleted_at)
            VALUES
            ('{projectA1Id}', 'Project A-1', '{tenantA.Id}', NOW(), NOW(), NULL),
            ('{projectA2Id}', 'Project A-2', '{tenantA.Id}', NOW(), NOW(), NULL),
            ('{projectB1Id}', 'Project B-1', '{tenantA.Id}', NOW(), NOW(), NULL),
            """;
        await cmd.ExecuteNonQueryAsync();
    }

    [Fact]
    public async Task EfQueryFilter_ReturnsOnlyCurrentTenantProjects()
    {
        // Arrange
        // Act
        // Assert - only Tenant A's 2 projects returned, not Tenant B's
    }

    [Fact]
    public async Task RawSqlWithRls_ReturnsOnlyCurrentTenantRows()
    {
        // Arrange
        // Act - raw SQL query, no EF invloved
        // Assert - only Tenant B's 1 row returned
    }

    [Fact]
    public async Task CrossTenant_AccessByForeignKey_ReturnsNull()
    {
        // Arrange
        // Act - try to find Tenant B's project using Tenant A's context
        // Assert - Tenant A cannot see Tenant B's projects
    }

    [Fact]
    public async Task NoTenantContext_ReturnsNoRows()
    {
        // Arrange
        // Act
        // Assert - no rows visible without a valid tenant
    }

    [Fact]
    private async Task<Tenant> GetTenantBySlugAsync(string slug)
    {
        var noTenantContext = new TestableTenantContext { IsResolved = false };
        await using var context = await CreateDbContextAsync(noTenantContext);

        // Tenants table is not tenant-scoped, so query filters don't apply
        return await context.Tenants.FirstAsync(t => t.Slug == slug);
    }
}
