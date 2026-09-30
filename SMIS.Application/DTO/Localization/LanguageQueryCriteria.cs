namespace SMIS.Application.DTO.Localization;

public sealed class LanguageQueryCriteria
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? Code { get; set; }
    public bool? IsActive { get; set; }
}
