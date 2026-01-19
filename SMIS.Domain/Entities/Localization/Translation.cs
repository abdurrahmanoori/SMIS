using SMIS.Domain.Common.BaseAbstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMIS.Domain.Entities.Localization
{
    public class Translation : BaseAuditableEntity
    {
        public int TranslationKeyPublicId { get; set; }

        public int LanguageNo { get; set; }

        public string Description { get; set; } = string.Empty;

        // Navigation properties
        [ForeignKey(nameof(TranslationKeyPublicId))]
        public TranslationKey TranslationKey { get; set; } = null!;

        [ForeignKey(nameof(LanguageNo))]
        public Language Language { get; set; } = null!;
    }
}