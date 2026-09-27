using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Services;
using System.ComponentModel.DataAnnotations;

namespace SMIS.Domain.Common.BaseAbstract
{
    /// <summary>
    /// Common persistence state shared by most domain entities.
    /// Synchronization queue state belongs to PowerSync, not to the domain model.
    /// This base type keeps only persistence identity, change time, versioning, and
    /// soft-delete state that are still used by server-side behavior.
    /// </summary>
    public abstract class BaseEntity : IEntityPK, ISoftDeletable
    {
        /// <summary>
        /// Stable public identifier. Sync-capable entities may receive this ID from
        /// an offline client, so persistence interceptors must not blindly replace it.
        /// </summary>
        [Key]
        public virtual string Id { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// Logical version used by entities that still rely on versioned workflows.
        /// </summary>
        public int Version { get; set; }

        /// <summary>
        /// Canonical UTC timestamp used by PowerSync-facing change and conflict flows.
        /// </summary>
        public DateTime LastModifiedUtc { get; set; } = DateTimeService.NowUtc;

        // Soft-delete fields form the tombstone that other clients need in order
        // to learn that a previously downloaded record was deleted.
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }
    }
}