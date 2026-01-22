using SMIS.Domain.Entities.Localization;

namespace SMIS.Domain.Entities.LocationEntities
{
    public class ProvinceTranslation : TranslationBase
    {
        public string ProvinceId { get; set; } = string.Empty;
        public Province Province { get; set; } = default!;

        public string Name { get; set; } = string.Empty;
    }
}
