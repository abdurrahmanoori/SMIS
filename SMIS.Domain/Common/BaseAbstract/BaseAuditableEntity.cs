using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Services;

namespace SMIS.Domain.Common.BaseAbstract
{
    public abstract class BaseAuditableEntity : BaseEntity, IAuditableEntity
    {
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTimeService.Now;
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; } = DateTimeService.Now;
    }
}
