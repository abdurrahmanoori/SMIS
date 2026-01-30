using AutoMapper;
using SMIS.Application.DTO.Localization;
using SMIS.Application.DTO.Provinces;
using SMIS.Application.DTO.Districts;
using SMIS.Application.DTO.Shops;
using SMIS.Application.DTO.UnitOfMeasures;
using SMIS.Application.DTO.Products;
using System.Globalization;
using SMIS.Application.DTO.Categories;
using SMIS.Application.DTO.ProductUnits;
using SMIS.Application.DTO.TranslationKeys;
using SMIS.Application.DTO.Translations;
using SMIS.Domain.Entities;
using SMIS.Domain.Entities.Localization;
using SMIS.Domain.Entities.LocationEntities;

namespace SMIS.Application.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {

        // Language mappings
        CreateMap<Language, LanguageDto>().ReverseMap();
        CreateMap<Language, LanguageCreateDto>().ReverseMap();

        // Province mapping: resolve Name by current UI culture from Translations, fallback to entity Name
        CreateMap<Province, ProvinceDto>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src =>
                ResolveProvinceName(src)))
            ;
        CreateMap<Province, ProvinceCreateDto>()
            .ReverseMap()
            .AfterMap((src, dest) =>
            {
                // If DTO provides translations, replace entity translations; else seed from Name if provided
                if (src.Translations != null && src.Translations.Any())
                {
                    dest.Translations = src.Translations.Select(t => new ProvinceTranslation
                    {
                        LanguageCode = t.LanguageCode,
                        LanguageId = t.LanguageId,
                        IsDefault = t.IsDefault,
                        Name = t.Name
                    }).ToList();
                }
                else if (!string.IsNullOrWhiteSpace(src.Name))
                {
                    // Create a default English translation based on Name for backward-compat
                    if (dest.Translations == null) dest.Translations = new List<ProvinceTranslation>();
                    if (!dest.Translations.Any())
                    {
                        dest.Translations.Add(new ProvinceTranslation
                        {
                            LanguageCode = "en",
                            LanguageId = "1",
                            IsDefault = true,
                            Name = src.Name
                        });
                    }
                }
            });


        //CreateMap<Hospital, HospitalCreateDto>()
        //    .ReverseMap()
        //    .ForMember(dest => dest.Name,
        //        opt => opt.MapFrom(src => string.IsNullOrWhiteSpace(src.Code) ? (src.Email ?? "Hospital") : src.Code));

        CreateMap<ProvinceTranslation, ProvinceTranslationDto>()
            .ForMember(dest => dest.LanguageCode, opt => opt.MapFrom(src => src.LanguageCode))
            .ForMember(dest => dest.LanguageId, opt => opt.MapFrom(src => src.LanguageId))
            .ReverseMap()
            .ForMember(dest => dest.LanguageCode, opt => opt.MapFrom(src => src.LanguageCode))
            .ForMember(dest => dest.LanguageId, opt => opt.MapFrom(src => src.LanguageId));

        // District mapping
        CreateMap<District, DistrictDto>().ReverseMap();
        CreateMap<District, DistrictCreateDto>().ReverseMap();

        // Shop mapping
        CreateMap<Shop, ShopDto>().ReverseMap();
        CreateMap<ShopCreateDto, Shop>()
            .ConstructUsing(src => Shop.Create(
                src.Name,
                src.ShopType,
                src.Address,
                src.PhoneNumber,
                src.Email,
                src.TaxNumber,
                src.IsActive
            ));

        // Product mapping
        CreateMap<Product, ProductDto>().ReverseMap();
        CreateMap<ProductCreateDto, Product>()
            .ConstructUsing(src => Product.Create(
                src.Name,
                src.ShopId,
                src.BaseUnitId,
                src.SKU,
                src.SalePricePerBaseUnit,
                src.IsActive,
                src.Description,
                src.Barcode,
                src.ImageUrl,
                src.CategoryId
            ));

        // UnitOfMeasure mapping
        CreateMap<UnitOfMeasure, UnitOfMeasureDto>().ReverseMap();
        CreateMap<UnitOfMeasure, UnitOfMeasureCreateDto>().ReverseMap();

        // Category mapping
        CreateMap<Category, CategoryDto>().ReverseMap();
        CreateMap<Category, CategoryCreateDto>().ReverseMap();

        // ProductUnit mapping
        CreateMap<ProductUnit, ProductUnitDto>().ReverseMap();
        CreateMap<ProductUnit, ProductUnitCreateDto>().ReverseMap();

        // TranslationKey mapping
        CreateMap<TranslationKey, TranslationKeyDto>().ReverseMap();
        CreateMap<TranslationKey, TranslationKeyCreateDto>().ReverseMap();

        // Translation mapping
        CreateMap<Translation, TranslationEntityDto>().ReverseMap();
        CreateMap<Translation, TranslationEntityCreateDto>().ReverseMap();
    }

    private static string ResolveProvinceName(Province src)
    {
        if (src.Translations != null && src.Translations.Count > 0)
        {
            var translations = src.Translations;
            var current = CultureInfo.CurrentUICulture;
            var exact = translations.FirstOrDefault(t => string.Equals(t.LanguageCode, current.Name, StringComparison.OrdinalIgnoreCase));
            if (exact != null) return exact.Name;
            var primary = translations.FirstOrDefault(t => string.Equals(t.LanguageCode, current.TwoLetterISOLanguageName, StringComparison.OrdinalIgnoreCase));
            if (primary != null) return primary.Name;
            var def = translations.FirstOrDefault(t => t.IsDefault);
            if (def != null) return def.Name;
            return translations.First().Name;
        }
        return src.Name ?? string.Empty;
    }
}