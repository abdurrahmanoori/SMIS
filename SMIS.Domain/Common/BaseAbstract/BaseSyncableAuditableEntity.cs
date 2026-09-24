using SMIS.Domain.Services;

namespace SMIS.Domain.Common.BaseAbstract;

/// <summary>
/// Shared offline-sync state for entities that can be created, updated, or
/// deleted on a client. Server audit fields remain in <see cref="BaseAuditableEntity"/>.
/// </summary>
public abstract class BaseSyncableAuditableEntity : BaseAuditableEntity
{
    /// <summary>
    /// Original client-side creation timestamp. This is intentionally separate
    /// from CreatedDate, which records when the server persisted the entity.
    /// </summary>
    public DateTime? ClientCreatedDate { get; private set; }

    /// <summary>
    /// Most recent modification timestamp reported by an offline client.
    /// It participates in last-write-wins conflict comparison.
    /// </summary>
    public DateTime? ClientModifiedDate { get; private set; }

    public string? ClientCreatedBy { get; private set; }
    public string? ClientModifiedBy { get; private set; }

    public void SetClientCreationMetadata(
        DateTime createdDateUtc,
        string? createdBy
    )
    {
        ClientCreatedDate = DateTimeService.NormalizeUtc(createdDateUtc);
        ClientCreatedBy = NormalizeUserId(createdBy);
    }

    public void SetClientModificationMetadata(
        DateTime modifiedDateUtc
    )
    {
        ClientModifiedDate = DateTimeService.NormalizeUtc(modifiedDateUtc);
    }

    public void SetClientModificationMetadata(
        DateTime modifiedDateUtc,
        string? modifiedBy
    )
    {
        SetClientModificationMetadata(modifiedDateUtc);
        ClientModifiedBy = NormalizeUserId(modifiedBy);
    }

    public void ClearClientModificationMetadata()
    {
        ClientModifiedDate = null;
        ClientModifiedBy = null;
    }

    public virtual void Restore()
    {
        // A newer client update may legitimately resurrect a soft-deleted row.
        // Clearing both fields keeps normal query filters and later sync pulls consistent.
        IsDeleted = false;
        DeletedAt = null;
    }

    /// <summary>
    /// Returns the timestamp used to resolve offline conflicts. Client modification
    /// time has highest priority because it represents the user's latest offline edit;
    /// server audit timestamps are fallbacks for server-originated changes.
    /// </summary>
    public DateTime GetConflictModifiedUtc() => DateTimeService.NormalizeUtc(
        ClientModifiedDate
        ?? UpdatedDate
        ?? ClientCreatedDate
        ?? CreatedDate
        ?? LastModifiedUtc);

    private static string? NormalizeUserId(
        string? value
    ) =>
        string.IsNullOrWhiteSpace(value) ? null : value.Trim();
}