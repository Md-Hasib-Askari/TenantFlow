using System.ComponentModel.DataAnnotations;
using Domain.Enums;

namespace Application.Tenants.DTOs;

public record CreateTenantDto(
    [Required] string Slug,
    [Required] string Name,
    PlanTier Plan = PlanTier.Free
);
