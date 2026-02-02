using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMIS.Domain.Entities.Localization;

public class Translation : BaseAuditableEntity, IEntity
{
    public string Name { get; set; } = string.Empty;
    public string TranslationKeyId { get; set; } = string.Empty;

    public string LanguageNo { get; set; } = string.Empty;


    // Navigation properties
    [ForeignKey(nameof(TranslationKeyId))]
    public TranslationKey TranslationKey { get; set; } = null!;

    [ForeignKey(nameof(LanguageNo))]
    public Language Language { get; set; } = null!;
}