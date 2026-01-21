using SMIS.Domain.Common.BaseAbstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMIS.Domain.Entities.Localization
{
    public class Translation : BaseAuditableEntity
    {
        public string TranslationKeyPublicId { get; set; } = string.Empty;

        public string LanguageNo { get; set; } = string.Empty;


        // Navigation properties
        [ForeignKey(nameof(TranslationKeyPublicId))]
        public TranslationKey TranslationKey { get; set; } = null!;

        [ForeignKey(nameof(LanguageNo))]
        public Language Language { get; set; } = null!;
    }
}