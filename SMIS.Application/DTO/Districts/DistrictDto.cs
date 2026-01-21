namespace SMIS.Application.DTO.Districts
{
    public class DistrictDto
    {
        public string PublicId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string? TranslationKeyId { get; set; }
    }
}