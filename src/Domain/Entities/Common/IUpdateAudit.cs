namespace Domain.Entities.Common;

public interface IUpdateAudit
{
    DateTimeOffset? UpdatedAt { get; }
    ApplicationUser? UpdatedBy { get; }
}
