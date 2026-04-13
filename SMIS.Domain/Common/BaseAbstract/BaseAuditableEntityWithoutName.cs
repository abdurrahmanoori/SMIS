using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Enums;
using SMIS.Domain.Services;
namespace SMIS.Domain.Common.BaseAbstract
{
    public abstract class BaseAuditableEntityWithoutName : IAuditableEntity,IEntityPK
    {

        public string Id { get; set; } = Guid.NewGuid().ToString();

        public bool IsPublic { get; set; } = false;

        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTimeService.UtcNow;
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; } = DateTimeService.UtcNow;
        public int Version { get ; set ; }
        public EntityStateEnum EntityState { get ; set ; }
        public DateTime LastModifiedUtc { get;  set; }
    }
}
