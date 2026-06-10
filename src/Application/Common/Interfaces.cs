using Domain.Entities;

namespace Application.Common;

/// <summary>
/// Cache service for tenant info, backed by Redis.
/// </summary>
public interface ICacheService
{
    Task SetTenantInfoAsync(Tenant tenant, CancellationToken ct = default);
    Task InvalidateTenantAsync(string slug, Guid tenantId, CancellationToken ct = default);
}
