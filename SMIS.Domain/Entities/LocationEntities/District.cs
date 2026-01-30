using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Domain.Entities.LocationEntities;

public class District : BaseAuditableEntity
{
    public string? TranslationKeyId { get; set; }
    public TranslationKey TranslationKey { get; set; } = null!;
}