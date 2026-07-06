using System.ComponentModel.DataAnnotations;

namespace Application.Projects.DTOs;

public record AddProjectMemberDto([Required] Guid UserId);
