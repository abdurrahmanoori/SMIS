using SMIS.Domain.Services;

namespace SMIS.Domain.Common.BaseAbstract;

/// <summary>
/// Shared server-side conflict metadata for entities uploaded by PowerSync.
/// PowerSync owns client queue state; this type stores only the client change
/// timestamp still required by the API's conflict policy.
/// </summary>
public abstract class BaseSyncableAuditableEntity : BaseAuditableEntity
{
    /// <summary>
    /// Most recent modification timestamp reported by an offline client.
    /// It participates in last-write-wins conflict comparison.
    /// </summary>
    public DateTime? ClientModifiedDate { get; private set; }

    public void SetClientModificationMetadata(
        DateTime modifiedDateUtc
    )
    {
        ClientModifiedDate = DateTimeService.NormalizeUtc(modifiedDateUtc);
    }

    public void ClearClientModificationMetadata()
    {
        ClientModifiedDate = null;
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
        ?? CreatedDate
        ?? LastModifiedUtc);
}