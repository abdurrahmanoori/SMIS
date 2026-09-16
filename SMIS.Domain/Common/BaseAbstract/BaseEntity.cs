using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Enums;
using SMIS.Domain.Services;
using System.ComponentModel.DataAnnotations;

namespace SMIS.Domain.Common.BaseAbstract
{
    /// <summary>
    /// Common persistence state shared by most domain entities.
    /// Synchronization metadata lives here because both the API and offline clients
    /// need the same version, change timestamp, and tombstone information.
    /// </summary>
    public abstract class BaseEntity : IEntityPK, ISyncableEntity, ISoftDeletable
    {
        /// <summary>
        /// Stable public identifier. Sync-capable entities may receive this ID from
        /// an offline client, so persistence interceptors must not blindly replace it.
        /// </summary>
        [Key] public virtual string Id { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// Visibility metadata. Authorization still decides whether a caller may
        /// actually access the row.
        /// </summary>
        [Required] public bool IsPublic { get; set; } = false;

        /// <summary>
        /// Logical version used by synchronization/concurrency workflows.
        /// </summary>
        public int Version { get; set; }

        /// <summary>
        /// Client/server lifecycle state used by synchronization code.
        /// </summary>
        public EntityStateEnum EntityState { get; set; }

        /// <summary>
        /// Canonical UTC timestamp used by pull-sync cursors to detect changed rows.
        /// </summary>
        public DateTime LastModifiedUtc { get; set; } = DateTimeService.NowUtc;

        // Local/offline bookkeeping. These flags do not replace LastModifiedUtc,
        // which remains the authoritative change cursor for synchronization.
        public virtual bool IsSyncedToServer { get; set; } = true;
        public virtual DateTime? LastSyncedAt { get; set; }

        // Soft-delete fields form the tombstone that other clients need in order
        // to learn that a previously downloaded record was deleted.
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }
    }
}