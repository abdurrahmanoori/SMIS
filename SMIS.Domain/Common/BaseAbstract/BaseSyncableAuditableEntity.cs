using SMIS.Domain.Services;

namespace SMIS.Domain.Common.BaseAbstract;

/// <summary>
/// Shared offline-sync state for entities that can be created, updated, or
/// deleted on a client. Server audit fields remain in <see cref="BaseAuditableEntity"/>.
/// </summary>
public abstract class BaseSyncableAuditableEntity : BaseAuditableEntity
{
    public DateTime? ClientCreatedDate { get; private set; }
    public DateTime? ClientModifiedDate { get; private set; }
    public string? ClientCreatedBy { get; private set; }
    public string? ClientModifiedBy { get; private set; }

    public void SetClientCreationMetadata(DateTime createdDateUtc, string? createdBy)
    {
        ClientCreatedDate = DateTimeService.NormalizeUtc(createdDateUtc);
        ClientCreatedBy = NormalizeUserId(createdBy);
    }

    public void SetClientModificationMetadata(DateTime modifiedDateUtc, string? modifiedBy)
    {
        ClientModifiedDate = DateTimeService.NormalizeUtc(modifiedDateUtc);
        ClientModifiedBy = NormalizeUserId(modifiedBy);
    }

    public void ClearClientModificationMetadata()
    {
        ClientModifiedDate = null;
        ClientModifiedBy = null;
    }

    public virtual void Restore()
    {
        IsDeleted = false;
        DeletedAt = null;
    }

    public DateTime GetConflictModifiedUtc() => DateTimeService.NormalizeUtc(
        ClientModifiedDate
        ?? UpdatedDate
        ?? ClientCreatedDate
        ?? CreatedDate
        ?? LastModifiedUtc);

    private static string? NormalizeUserId(string? value) =>
        string.IsNullOrWhiteSpace(value) ? null : value.Trim();
}
