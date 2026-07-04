using Application.Auth;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Identity;

public class UserTenantRoleRepository(AppDbContext db) : IUserTenantRoleRepository
{
    private readonly AppDbContext _db = db;

    public async Task<UserTenantRole?> GetByUserAndTenantAsync(Guid userId, Guid tenantId, CancellationToken ct = default) =>
        await _db.UserTenantRoles
            .FirstOrDefaultAsync(r => r.UserId == userId && r.TenantId == tenantId, ct);

    public async Task AddAsync(UserTenantRole role, CancellationToken ct = default) =>
        await _db.UserTenantRoles.AddAsync(role, ct);
}
