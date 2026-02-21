using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Services;

namespace SMIS.Domain.Common.BaseAbstract
{
    public abstract class AuditableCreatedDateAndCreatedBy : IAuditableCreatedDateAndCreatedBy
    {
        public string? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTimeService.Now;
    }
}
