using System.Text.Json.Serialization;
using Domain.Entities.Common;
using Domain.Interfaces;

namespace Domain.Entities.Projects;

public class ProjectMember : BaseAudit, ITenantScoped
{
    public Guid Id { get; private init; }
    public Guid TenantId { get; private init; }
    public Guid ProjectId { get; private init; }
    public Guid UserId { get; private init; }
    public ProjectMemberRole Role { get; private set; } = ProjectMemberRole.Member;

    public Project Project { get; private set; } = null!;
    public ApplicationUser User { get; private set; } = null!;
    public Tenant Tenant { get; private set; } = null!;

    private ProjectMember() { }

    public static ProjectMember Create(Guid tenantId, Guid projectId, Guid userId) =>
        new()
        {
            Id = Guid.NewGuid(),
            TenantId = tenantId,
            ProjectId = projectId,
            UserId = userId,
            CreatedAt = DateTimeOffset.UtcNow,
        };

    public static bool ChangeRole(ProjectMember member, ProjectMemberRole newRole)
    {
        if (member.Role != newRole)
        {
            member.Role = newRole;
            return true;
        }
        return false;
    }
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ProjectMemberRole
{
    Member,
    Editor,
    Admin,
}
