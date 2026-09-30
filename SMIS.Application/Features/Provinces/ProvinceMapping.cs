using System.Globalization;
using SMIS.Application.DTO.Provinces;
using SMIS.Domain.Entities.LocationEntities;

namespace SMIS.Application.Features.Provinces;

internal static class ProvinceMapping
{
    public static Province Create(ProvinceCreateDto dto)
    {
        var province = new Province { Name = dto.Name };

        if (dto.Translations is { Count: > 0 })
        {
            AddTranslations(province, dto);
        }
        else if (!string.IsNullOrWhiteSpace(dto.Name))
        {
            province.Translations.Add(CreateDefaultTranslation(dto.Name));
        }

        return province;
    }

    public static void Apply(Province province, ProvinceCreateDto dto)
    {
        province.Name = dto.Name;

        if (dto.Translations is { Count: > 0 })
        {
            province.Translations.Clear();
            AddTranslations(province, dto);

            var defaults = province.Translations.Where(t => t.IsDefault).ToList();
            foreach (var translation in defaults.Skip(1)) translation.IsDefault = false;
            if (defaults.Count == 0) province.Translations.First().IsDefault = true;
            return;
        }

        if (string.IsNullOrWhiteSpace(dto.Name)) return;

        if (province.Translations.Count == 0)
        {
            province.Translations.Add(CreateDefaultTranslation(dto.Name));
            return;
        }

        var defaultTranslation = province.Translations.FirstOrDefault(t => t.IsDefault)
                                 ?? province.Translations.First();
        defaultTranslation.Name = dto.Name;
    }

    public static ProvinceDto ToDto(Province province) => new()
    {
        Id = province.Id,
        Name = ResolveName(province)
    };

    private static void AddTranslations(Province province, ProvinceCreateDto dto)
    {
        foreach (var translation in dto.Translations!)
        {
            province.Translations.Add(new ProvinceTranslation
            {
                LanguageCode = translation.LanguageCode,
                LanguageId = translation.LanguageId,
                IsDefault = translation.IsDefault,
                Name = translation.Name
            });
        }
    }

    private static ProvinceTranslation CreateDefaultTranslation(string name) => new()
    {
        LanguageCode = "en",
        LanguageId = "1",
        IsDefault = true,
        Name = name
    };

    private static string ResolveName(Province province)
    {
        if (province.Translations is not { Count: > 0 }) return province.Name ?? string.Empty;

        var current = CultureInfo.CurrentUICulture;
        var exact = province.Translations.FirstOrDefault(t =>
            string.Equals(t.LanguageCode, current.Name, StringComparison.OrdinalIgnoreCase));
        if (exact is not null) return exact.Name;

        var primary = province.Translations.FirstOrDefault(t =>
            string.Equals(t.LanguageCode, current.TwoLetterISOLanguageName, StringComparison.OrdinalIgnoreCase));
        if (primary is not null) return primary.Name;

        return province.Translations.FirstOrDefault(t => t.IsDefault)?.Name
               ?? province.Translations.First().Name;
    }
}
