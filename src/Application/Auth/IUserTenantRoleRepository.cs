using Domain.Entities;

namespace Application.Auth;

public interface IUserTenantRoleRepository
{
    Task<UserTenantRole?> GetByUserAndTenantAsync(Guid userId, Guid tenantId, CancellationToken ct = default);
    Task AddAsync(UserTenantRole role, CancellationToken ct = default);
}
