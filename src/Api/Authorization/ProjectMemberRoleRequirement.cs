using Microsoft.AspNetCore.Authorization;

namespace Api.Authorization;

public class ProjectMemberRoleRequirement(params string[] allowedRoles) : IAuthorizationRequirement
{
    public string[] AllowedRoles { get; } = allowedRoles;
}
