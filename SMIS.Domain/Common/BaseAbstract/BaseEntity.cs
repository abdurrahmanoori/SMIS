using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Enums;
using SMIS.Domain.Services;
using System.ComponentModel.DataAnnotations;

namespace SMIS.Domain.Common.BaseAbstract
{
    public abstract class BaseEntity : IEntityPK, ISyncableEntity, ISoftDeletable
    {
        [Key]
        public virtual string Id { get; set; } = Guid.NewGuid().ToString();
        [Required]
        public bool IsPublic { get; set; } = false;
        public int Version { get; set; }
        public EntityStateEnum EntityState { get; set; }
        public DateTime LastModifiedUtc { get; set; } = DateTimeService.UtcNow;

        // Offline-first properties
        public virtual bool IsSyncedToServer { get; set; } = true;
        public virtual DateTime? LastSyncedAt { get; set; }

        // Soft delete
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }
    }
}
