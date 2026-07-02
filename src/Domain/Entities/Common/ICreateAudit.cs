namespace Domain.Entities.Common;

public interface ICreateAudit
{
    DateTimeOffset CreatedAt { get; }
    ApplicationUser? CreatedBy { get; }
}
