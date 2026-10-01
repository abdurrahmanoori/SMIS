using SMIS.Application.DTO.Provinces;
using SMIS.Domain.Entities.LocationEntities;

namespace SMIS.Application.Features.Provinces;

internal static class ProvinceTranslationMapping
{
    public static ProvinceTranslation Create(ProvinceTranslationDto dto)
    {
        var translation = new ProvinceTranslation
        {
            ProvinceId = dto.ProvinceId,
            LanguageCode = dto.LanguageCode,
            LanguageId = dto.LanguageId,
            IsDefault = dto.IsDefault,
            Name = dto.Name
        };

        if (!string.IsNullOrWhiteSpace(dto.Id)) translation.Id = dto.Id;
        return translation;
    }

    public static void Apply(ProvinceTranslation translation, ProvinceTranslationDto dto)
    {
        translation.ProvinceId = dto.ProvinceId;
        translation.LanguageCode = dto.LanguageCode;
        translation.LanguageId = dto.LanguageId;
        translation.IsDefault = dto.IsDefault;
        translation.Name = dto.Name;
    }

    public static ProvinceTranslationDto ToDto(ProvinceTranslation translation) => new()
    {
        Id = translation.Id,
        ProvinceId = translation.ProvinceId,
        LanguageCode = translation.LanguageCode,
        LanguageId = translation.LanguageId,
        IsDefault = translation.IsDefault,
        Name = translation.Name
    };
}
