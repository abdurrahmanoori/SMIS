using SMIS.Domain.Entities.Localization;

namespace SMIS.Domain.Entities
{
    public class ProvinceTranslation : TranslationBase
    {
        public Guid ProvinceId { get; set; }
        public Province Province { get; set; } = default!;

        public string Name { get; set; } = string.Empty;
    }
}
