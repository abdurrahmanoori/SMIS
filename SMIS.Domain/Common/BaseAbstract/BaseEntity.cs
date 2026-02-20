using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace SMIS.Domain.Common.BaseAbstract
{
    public abstract class BaseEntity : IEntityPK, ISyncableEntity
    {
        [Key]
        public virtual string Id { get; set; } = Guid.NewGuid().ToString();
        [Required]
        public bool IsPublic { get; set; } = false;
        public int Version { get; set; }
        public EntityStateEnum EntityState { get; set; }
        public DateTimeOffset LastModifiedUtc { get; set; } = DateTimeOffset.UtcNow;
        
        // Offline-first properties
        public virtual bool IsSyncedToServer { get; set; } = true;
        public virtual DateTime? LastSyncedAt { get; set; }
    }
}
