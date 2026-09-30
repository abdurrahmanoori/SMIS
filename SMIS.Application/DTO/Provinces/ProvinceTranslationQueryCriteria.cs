namespace SMIS.Application.DTO.Provinces;

public sealed class ProvinceTranslationQueryCriteria
{
    public string? Id { get; set; }
    public string? ProvinceId { get; set; }
    public string? LanguageCode { get; set; }
    public string? LanguageId { get; set; }
    public bool? IsDefault { get; set; }
    public string? Name { get; set; }
}