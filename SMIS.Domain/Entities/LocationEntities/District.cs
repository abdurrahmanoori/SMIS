using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;

namespace SMIS.Domain.Entities.LocationEntities;

public class District : BaseAuditableEntity, IEntity
{
    public string Name { get; set; } = string.Empty;
}