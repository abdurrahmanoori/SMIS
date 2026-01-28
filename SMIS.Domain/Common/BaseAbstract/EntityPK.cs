using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Common.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SMIS.Domain.Common.BaseAbstract
{
    public class EntityPK : IEntityPK
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public int Version { get; set; } = 0; // increment on every change
        public EntityState State { get; set; } = EntityState.Added;
        public DateTimeOffset LastModifiedUtc { get;  set; } = DateTimeOffset.UtcNow;
    }
}
