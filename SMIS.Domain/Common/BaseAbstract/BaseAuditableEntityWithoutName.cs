using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Services;

namespace SMIS.Domain.Common.BaseAbstract
{
    public abstract class BaseAuditableEntityWithoutName : IAuditableEntity, IEntityPK
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTimeService.NowUtc;
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; } = DateTimeService.NowUtc;
        public int Version { get; set; }
        public DateTime LastModifiedUtc { get; set; }
    }
}