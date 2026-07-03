using Application.Projects.DTOs;
using Domain.Entities.Projects;

namespace Application.Projects.Interfaces;

public interface IProjectService
{
    Task<Project> GetByIdAsync(Guid id, CancellationToken ct = default);
    Task<IReadOnlyList<Project>> GetAllByTenantIdAsync(
        Guid tenantId,
        CancellationToken ct = default
    );
    Task AddAsync(Guid tenantId, CreateProjectDto createProjectDto, CancellationToken ct = default);
    Task UpdateAsync(
        Guid tenantId,
        Guid projectId,
        UpdateProjectDto updateProjectDto,
        CancellationToken ct = default
    );
    Task<bool> NameExistsAsync(Guid tenantId, string name, CancellationToken ct = default);
}
