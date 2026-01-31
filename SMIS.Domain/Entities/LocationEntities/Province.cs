using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;

namespace SMIS.Domain.Entities.LocationEntities;

public class Province : BaseAuditableEntity, IHasTranslations<ProvinceTranslation>, IEntity
{
    public string Name { get; set; } = string.Empty;
    public virtual ICollection<ProvinceTranslation> Translations { get; set; } = new List<ProvinceTranslation>();
}
