using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Entities.Localization;
using SMIS.Domain.Common.Interfaces;

namespace SMIS.Domain.Entities.LocationEntities;

public class District : BaseAuditableEntity, IEntity
{
    public string Name { get; set; } = string.Empty;
    public string? TranslationKeyId { get; set; }
    public TranslationKey TranslationKey { get; set; } = null!;
}