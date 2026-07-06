using Application.Projects.Interfaces;
using Domain.Entities.Projects;

namespace Application.Projects.Services;

public class ProjectMemberService(
    IProjectMemberRepository projectMemberRepo,
    IProjectService projectSvc
) : IProjectMemberService
{
    private readonly IProjectMemberRepository _projectMemberRepo = projectMemberRepo;
    private readonly IProjectService _projectSvc = projectSvc;

    public async Task AddMemberAsync(
        Guid tenantId,
        Guid projectId,
        Guid userId,
        Guid addedById,
        CancellationToken ct = default
    )
    {
        if (!await _projectSvc.ExistsAsync(tenantId, projectId, ct))
            throw new InvalidOperationException("Project not found.");

        await _projectMemberRepo.AddMemberAsync(projectId, userId, addedById, ct);
    }

    public async Task<ProjectMember?> GetMemberAsync(
        Guid tenantId,
        Guid projectId,
        Guid userId,
        CancellationToken ct = default
    )
    {
        if (!await _projectSvc.ExistsAsync(tenantId, projectId, ct))
            throw new InvalidOperationException("Project not found.");

        return await _projectMemberRepo.GetMemberAsync(projectId, userId, ct);
    }

    public async Task<IReadOnlyList<ProjectMember>> GetMembersByProjectIdAsync(
        Guid tenantId,
        Guid projectId,
        CancellationToken ct = default
    )
    {
        if (!await _projectSvc.ExistsAsync(tenantId, projectId, ct))
            throw new InvalidOperationException("Project not found.");

        return await _projectMemberRepo.GetMembersByProjectIdAsync(projectId, ct);
    }

    public async Task<bool> IsMemberAsync(
        Guid tenantId,
        Guid projectId,
        Guid userId,
        CancellationToken ct = default
    )
    {
        if (!await _projectSvc.ExistsAsync(tenantId, projectId, ct))
            throw new InvalidOperationException("Project not found.");

        return await _projectMemberRepo.IsMemberAsync(projectId, userId, ct);
    }

    public async Task RemoveMemberAsync(
        Guid tenantId,
        Guid projectId,
        Guid userId,
        CancellationToken ct = default
    )
    {
        if (!await _projectSvc.ExistsAsync(tenantId, projectId, ct))
            throw new InvalidOperationException("Project not found.");

        await _projectMemberRepo.RemoveMemberAsync(projectId, userId, ct);
    }

    public async Task UpdateMemberRoleAsync(
        Guid tenantId,
        Guid projectId,
        Guid userId,
        ProjectMemberRole newRole,
        CancellationToken ct = default
    )
    {
        if (!await _projectSvc.ExistsAsync(tenantId, projectId, ct))
            throw new InvalidOperationException("Project not found.");

        await _projectMemberRepo.UpdateMemberRoleAsync(projectId, userId, newRole, ct);
    }
}
