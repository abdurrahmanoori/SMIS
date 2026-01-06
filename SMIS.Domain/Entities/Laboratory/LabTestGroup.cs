using SMIS.Domain.Common.BaseAbstract;

namespace SMIS.Domain.Entities.Laboratory
{
    public class LabTestGroup : BaseEntity
    {
        public string? Description { get; set; }
        public short? SortOrder { get; set; }
        public ICollection<LabTest> LabTests { get; set; }
    }
}
