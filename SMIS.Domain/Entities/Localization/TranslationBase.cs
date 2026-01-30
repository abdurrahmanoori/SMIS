using SMIS.Domain.Common.BaseAbstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMIS.Domain.Entities.Localization;

public abstract class TranslationBase : EntityPK
{
    public string LanguageCode { get; set; } = "en";
    public string LanguageId { get; set; } = string.Empty;
    public bool IsDefault { get; set; } = false;
    [ForeignKey(nameof(LanguageId))]
    public Language? Language { get; set; }
}
