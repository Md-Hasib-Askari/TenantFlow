using Application.Tenants.DTOs;
using Application.Tenants.Interfaces;
using Domain.Entities;

namespace Application.Tenants.Services;

public class TenantService(ITenantRepository repo) : ITenantService
{
    private readonly ITenantRepository _repo = repo;

    public async Task AddAsync(
        CreateTenantRequest createTenantDto,
        Guid createdBy,
        CancellationToken ct = default
    )
    {
        var tenant = Tenant.Create(
            createTenantDto.Slug,
            createTenantDto.Name,
            createdBy,
            createTenantDto.Plan
        );
        await _repo.AddAsync(tenant, ct);
    }

    public async Task<Tenant?> GetByApiKeyHashAsync(string hash, CancellationToken ct = default) =>
        await _repo.GetByApiKeyHashAsync(hash, ct);

    public async Task<Tenant?> GetByIdAsync(Guid id, CancellationToken ct = default) =>
        await _repo.GetByIdAsync(id, ct);

    public async Task<Tenant?> GetBySlugAsync(string slug, CancellationToken ct = default) =>
        await _repo.GetBySlugAsync(slug, ct);

    public async Task<bool> SlugExistsAsync(string slug, CancellationToken ct = default) =>
        await _repo.SlugExistsAsync(slug, ct);

    public async Task UpdateAsync(
        Guid id,
        UpdateTenantRequest updateTenantDto,
        Guid updatedBy,
        CancellationToken ct = default
    )
    {
        var tenant =
            await _repo.GetByIdAsync(id, ct)
            ?? throw new KeyNotFoundException($"Tenant with ID {id} not found.");

        tenant.Update(
            updatedBy: updatedBy,
            name: updateTenantDto.Name,
            tenantStatus: updateTenantDto.TenantStatus,
            newPlan: updateTenantDto.TenantPlan,
            billingEmail: updateTenantDto.BillingEmail
        );

        await _repo.UpdateAsync(tenant, ct);
    }
}
