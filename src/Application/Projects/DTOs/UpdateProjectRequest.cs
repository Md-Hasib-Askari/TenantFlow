using System.ComponentModel.DataAnnotations;
using Application.Common;

namespace Application.Projects.DTOs;

[AtLeastOneRequired("Name", "Description", "Color")]
public record UpdateProjectRequest(string? Name, string? Description, string? Color);
