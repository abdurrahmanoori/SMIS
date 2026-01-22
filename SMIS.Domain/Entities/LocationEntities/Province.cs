using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;

namespace SMIS.Domain.Entities.LocationEntities
{
    public class Province : BaseAuditableEntity, IHasTranslations<ProvinceTranslation>
    {
        public virtual ICollection<ProvinceTranslation> Translations { get; set; } = new List<ProvinceTranslation>();
    }
}
