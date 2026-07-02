namespace Domain.Entities.Common;

public class BaseAudit : ICreateAudit, IUpdateAudit, IDeleteAudit
{
    public DateTimeOffset CreatedAt { get; protected set; }

    public ApplicationUser? CreatedBy { get; protected set; }

    public DateTimeOffset? UpdatedAt { get; protected set; }

    public ApplicationUser? UpdatedBy { get; protected set; }

    public DateTimeOffset? DeletedAt { get; protected set; }

    public ApplicationUser? DeletedBy { get; protected set; }
}
