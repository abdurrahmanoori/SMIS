using System.ComponentModel.DataAnnotations.Schema;

namespace SMIS.Domain.Entities.Localization
{
    public abstract class TranslationBase
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string LanguageCode { get; set; } = "en"; // RFC5646 language tag, e.g., en, fa-AF
        public Guid LanguageId { get; set; }
        public bool IsDefault { get; set; } = false;
        [ForeignKey(nameof(LanguageId))]
        public Language? Language { get; set; }
    }
}
