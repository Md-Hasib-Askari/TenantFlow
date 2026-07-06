using System.ComponentModel.DataAnnotations;
using Domain.Entities.Projects;

namespace Application.Projects.DTOs;

public record UpdateProjectMemberRoleDto([Required] ProjectMemberRole Role);
