using System.ComponentModel.DataAnnotations;

namespace Application.Projects.DTOs;

public record CreateProjectDto([Required] string Name, string? Description, string? Color);
