using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Common.Interfaces;
namespace SMIS.Domain.Common.BaseAbstract
{
    public abstract class BaseAuditableEntityWithoutName : IAuditableEntity,IEntityPK
    {

        public string Id { get; set; } = Guid.NewGuid().ToString();

        public bool IsPublic { get; set; } = false;

        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; } = DateTime.Now;
        public int Version { get ; set ; }
        public EntityState State { get ; set ; }
        public DateTimeOffset LastModifiedUtc { get;  set; }
    }
}
