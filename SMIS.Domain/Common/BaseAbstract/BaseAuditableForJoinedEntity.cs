using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;

namespace SMIS.Domain.Common.BaseAbstract
{
    public class BaseAuditableForJoinedEntity : IAuditableEntity
    {
        //public int Id { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
