using Domain.Entities.Projects;

namespace Application.Projects.DTOs;

public record ProjectMemberDto(Guid UserId, ProjectMemberRole Role);
