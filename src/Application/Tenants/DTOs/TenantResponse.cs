using Domain.Enums;

namespace Application.Tenants.DTOs;

public record TenantResponse(
    Guid Id,
    string Slug,
    string Name,
    PlanTier Plan,
    TenantStatus Status,
    string BillingEmail,
    DateTimeOffset CreatedAt,
    DateTimeOffset? UpdatedAt
);
