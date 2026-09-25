using Microsoft.EntityFrameworkCore;
using SMIS.Application.DTO.Categories;
using SMIS.Application.DTO.Localization;
using SMIS.Application.Services;
using SMIS.Domain.Entities;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Application.Features.Categories;

internal static class CategoryLocalization
{
    public static IQueryable<Category> IncludeNameLocalization(
        this IQueryable<Category> query
    ) =>
        query
            .Include(x => x.NameLocalizedText)
            .ThenInclude(x => x.Translations);

    public static LocalizedText CreateName(
        CategoryCreateDto dto
    )
    {
        var localizedText = LocalizedText.Create(dto.Name);
        localizedText.SetTranslation(LanguageDefaults.EnglishId, dto.Name);
        ApplyOptionalTranslations(localizedText, dto.NameTranslations);
        return localizedText;
    }

    public static void ApplyName(
        Category category,
        CategoryCreateDto dto
    )
    {
        ApplyName(
            category,
            dto.Name,
            dto.NameTranslations);
    }

    public static void ApplyName(
        Category category,
        CategoryUpdateDto dto
    )
    {
        ApplyName(
            category,
            dto.Name,
            dto.NameTranslations);
    }

    public static CategoryDto ToDto(
        Category category,
        string languageId
    )
    {
        var localizedText = category.NameLocalizedText;
        var translations = localizedText.Translations;

        var englishName = translations
                              .FirstOrDefault(x => x.LanguageId == LanguageDefaults.EnglishId)
                              ?.Value
                          ?? localizedText.DefaultValue
                          ?? category.Name;

        var dariName = translations
            .FirstOrDefault(x => x.LanguageId == LanguageDefaults.DariId)
            ?.Value;

        var requestedName = translations
                                .FirstOrDefault(x => x.LanguageId == languageId)
                                ?.Value
                            ?? englishName;

        return new CategoryDto
        {
            Id = category.Id,
            Name = requestedName,
            EnglishName = englishName,
            DariName = dariName,
            NameLocalizedTextId = category.NameLocalizedTextId,
            NameTranslations = translations
                .OrderBy(x => x.LanguageId)
                .Select(x => new LocalizedTextValueDto
                {
                    LanguageId = x.LanguageId,
                    Value = x.Value
                })
                .ToList(),
            Code = category.Code,
            Description = category.Description,
            IsActive = category.IsActive,
            ShopId = category.ShopId,
            CreatedDate = AsUtc(category.CreatedDate),
            CreatedBy = category.CreatedBy,
            UpdatedDate = AsUtc(category.UpdatedDate),
            UpdatedBy = category.UpdatedBy,
            ClientModifiedDate = AsUtc(category.ClientModifiedDate),
            LastModifiedUtc = AsUtc(category.LastModifiedUtc),
            IsDeleted = category.IsDeleted
        };
    }

    private static void ApplyName(
        Category category,
        string englishName,
        IReadOnlyCollection<LocalizedTextValueDto> translations
    )
    {
        var localizedText = category.NameLocalizedText;
        localizedText.SetDefaultValue(englishName);
        localizedText.SetTranslation(LanguageDefaults.EnglishId, englishName);
        ApplyOptionalTranslations(localizedText, translations);
        category.SetName(englishName);
    }

    private static void ApplyOptionalTranslations(
        LocalizedText localizedText,
        IReadOnlyCollection<LocalizedTextValueDto> translations
    )
    {
        var dari = translations.FirstOrDefault(x => x.LanguageId == LanguageDefaults.DariId);
        if (dari is null)
            return;

        if (string.IsNullOrWhiteSpace(dari.Value))
        {
            localizedText.RemoveTranslation(LanguageDefaults.DariId);
            return;
        }

        localizedText.SetTranslation(LanguageDefaults.DariId, dari.Value);
    }

    private static DateTime AsUtc(
        DateTime value
    ) => value.Kind switch
    {
        DateTimeKind.Utc => value,
        DateTimeKind.Local => value.ToUniversalTime(),
        _ => DateTime.SpecifyKind(value, DateTimeKind.Utc)
    };

    private static DateTime? AsUtc(
        DateTime? value
    ) =>
        value.HasValue ? AsUtc(value.Value) : null;
}
