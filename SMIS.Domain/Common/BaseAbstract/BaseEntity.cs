using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace SMIS.Domain.Common.BaseAbstract
{
    public abstract class BaseEntity : IEntityPK
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Required]
        public bool IsPublic { get; set; } = false;
        public int Version { get; set; }
        public EntityStateEnum EntityState { get; set; }
        public DateTimeOffset LastModifiedUtc { get; set; } = DateTimeOffset.UtcNow;
        
        // Offline-first properties
        public bool IsSyncedToServer { get; set; } = false;
        public DateTime? LastSyncedAt { get; set; }
    }
}
