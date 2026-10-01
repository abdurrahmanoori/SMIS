using SMIS.Application.DTO.Localization;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Application.Features.Localization;

internal static class LanguageMapping
{
    public static Language Create(LanguageCreateDto dto) => new()
    {
        Name = dto.Name,
        Code = dto.Code,
        IsActive = dto.IsActive
    };

    public static void Apply(Language language, LanguageCreateDto dto)
    {
        language.Name = dto.Name;
        language.Code = dto.Code;
        language.IsActive = dto.IsActive;
    }

    public static LanguageDto ToDto(Language language) => new()
    {
        Id = language.Id,
        Name = language.Name,
        Code = language.Code,
        IsActive = language.IsActive
    };
}
