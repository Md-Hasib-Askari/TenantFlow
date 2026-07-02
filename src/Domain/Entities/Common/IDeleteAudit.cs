namespace Domain.Entities.Common;

public interface IDeleteAudit
{
    DateTimeOffset? DeletedAt { get; }
    ApplicationUser? DeletedBy { get; }
}
