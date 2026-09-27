using AutoMapper;
using SMIS.Application.DTO.Localization;
using SMIS.Application.DTO.Provinces;
using SMIS.Application.DTO.Districts;
using SMIS.Application.DTO.Shops;
using SMIS.Application.DTO.UnitOfMeasures;
using SMIS.Application.DTO.Products;
using SMIS.Application.DTO.Users;
using System.Globalization;
using SMIS.Application.DTO.Categories;
using SMIS.Application.DTO.ProductUnits;
using SMIS.Application.DTO.StockBatches;
using SMIS.Application.DTO.StockMovements;
using SMIS.Domain.Entities;
using SMIS.Domain.Entities.Localization;
using SMIS.Domain.Entities.LocationEntities;
using SMIS.Domain.Entities.Identity.Entity;
using SMIS.Domain.Enums;
using SMIS.Application.DTO.ProductPrices;
using SMIS.Application.DTO.Customers;
using SMIS.Application.DTO.ShopOwners;
using SMIS.Application.DTO.LoanAccounts;
using SMIS.Application.DTO.Sales;

namespace SMIS.Application.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // User mappings
        CreateMap<ApplicationUser, UserDto>().ReverseMap();
        CreateMap<UserCreateDto, ApplicationUser>()
            .ConstructUsing(src => ApplicationUser.Create(
                src.UserName,
                src.Email,
                src.ShopId,
                src.FirstName,
                src.LastName,
                src.PhoneNumber,
                src.LanguageId
            ));

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
        CreateMap<Shop, ShopDto>()
            .ForMember(dest => dest.ClientModifiedDate,
                opt => opt.MapFrom(src => AsUtc(src.ClientModifiedDate)))
            .ForMember(dest => dest.LastModifiedUtc,
                opt => opt.MapFrom(src => AsUtc(src.LastModifiedUtc)));
        // ShopCreateDto mapping removed - use Shop.Create() in handler

        // Product mapping
        CreateMap<Product, ProductDto>()
            .ForMember(dest => dest.CreatedDate,
                opt => opt.MapFrom(src => AsUtc(src.CreatedDate)))
            .ForMember(dest => dest.UpdatedDate,
                opt => opt.MapFrom(src => AsUtc(src.UpdatedDate)))
            .ForMember(dest => dest.ClientModifiedDate,
                opt => opt.MapFrom(src => AsUtc(src.ClientModifiedDate)))
            .ForMember(dest => dest.LastModifiedUtc,
                opt => opt.MapFrom(src => AsUtc(src.LastModifiedUtc)));
        // UnitOfMeasure mapping
        CreateMap<UnitOfMeasure, UnitOfMeasureDto>()
            .ForMember(dest => dest.ClientModifiedDate, opt => opt.MapFrom(src => AsUtc(src.ClientModifiedDate)))
            .ForMember(dest => dest.LastModifiedUtc, opt => opt.MapFrom(src => AsUtc(src.LastModifiedUtc)));
        CreateMap<UnitOfMeasureCreateDto, UnitOfMeasure>()
            .ConstructUsing(src => UnitOfMeasure.Create(
                src.Name,
                src.Symbol,
                src.Description
            ));

        // Category mapping
        CreateMap<Category, CategoryDto>()
            .ForMember(dest => dest.CreatedDate,
                opt => opt.MapFrom(src => AsUtc(src.CreatedDate)))
            .ForMember(dest => dest.UpdatedDate,
                opt => opt.MapFrom(src => AsUtc(src.UpdatedDate)))
            .ForMember(dest => dest.ClientModifiedDate,
                opt => opt.MapFrom(src => AsUtc(src.ClientModifiedDate)))
            .ForMember(dest => dest.LastModifiedUtc,
                opt => opt.MapFrom(src => AsUtc(src.LastModifiedUtc)));
        // CategoryCreateDto mapping removed - use Category.Create() in handler with ICurrentUser.GetShopId()


        // ProductUnit mapping
        CreateMap<ProductUnit, ProductUnitDto>()
            .ForMember(dest => dest.ClientModifiedDate, opt => opt.MapFrom(src => AsUtc(src.ClientModifiedDate)))
            .ForMember(dest => dest.LastModifiedUtc, opt => opt.MapFrom(src => AsUtc(src.LastModifiedUtc)));
        CreateMap<ProductUnitCreateDto, ProductUnit>()
            .ConstructUsing(src => ProductUnit.Create(
                src.ProductId,
                src.UnitOfMeasureId,
                src.BaseUnitQuantity
            ));

        // ProductPrice mapping
        CreateMap<ProductPrice, ProductPriceDto>()
            .ForMember(dest => dest.ClientModifiedDate, opt => opt.MapFrom(src => AsUtc(src.ClientModifiedDate)))
            .ForMember(dest => dest.LastModifiedUtc, opt => opt.MapFrom(src => AsUtc(src.LastModifiedUtc)));
        CreateMap<ProductPriceCreateDto, ProductPrice>()
            .ConstructUsing(src => ProductPrice.Create(
                src.ProductUnitId,
                src.SellPrice,
                src.EffectiveDate
            ))
            .AfterMap((src, dest) => { dest.SetEndDate(src.EndDate); });

        // Inventory mapping. Creation is handled explicitly because conversion,
        // tenant checks and ledger posting are domain/application operations.
        CreateMap<StockBatch, StockBatchDto>();
        CreateMap<StockMovement, StockMovementDto>();

        // Sales contain commercial facts only. Inventory allocation remains represented
        // by StockMovement rows that reference each SaleLine.Id.
        CreateMap<SaleLine, SaleLineDto>();
        CreateMap<Sale, SaleDto>()
            .ForMember(dest => dest.ReceivableId,
                opt => opt.MapFrom(src => src.Receivable == null ? null : src.Receivable.Id))
            .ForMember(dest => dest.ReceivableRemainingAmount,
                opt => opt.MapFrom(src => src.Receivable == null ? null : (long?)src.Receivable.RemainingAmount));

        // Customer mapping
        CreateMap<Customer, CustomerDto>()
            .ForMember(dest => dest.CreatedDate,
                opt => opt.MapFrom(src => AsUtc(src.CreatedDate)))
            .ForMember(dest => dest.UpdatedDate,
                opt => opt.MapFrom(src => AsUtc(src.UpdatedDate)))
            .ForMember(dest => dest.LastModifiedUtc,
                opt => opt.MapFrom(src => AsUtc(src.LastModifiedUtc)));
        // ShopOwner mapping
        CreateMap<ShopOwner, ShopOwnerDto>().ReverseMap();
        // LoanAccount is a receivable linked to a sale. Product/unit details live on SaleLine.
        CreateMap<LoanAccount, LoanAccountDto>()
            .ForMember(dest => dest.PaidAmount, opt => opt.MapFrom(src => src.PaidAmount))
            .ForMember(dest => dest.RemainingAmount, opt => opt.MapFrom(src => src.RemainingAmount));
    }

    private static string ResolveProvinceName(
        Province src
    )
    {
        if (src.Translations != null && src.Translations.Count > 0)
        {
            var translations = src.Translations;
            var current = CultureInfo.CurrentUICulture;
            var exact = translations.FirstOrDefault(t =>
                string.Equals(t.LanguageCode, current.Name, StringComparison.OrdinalIgnoreCase));
            if (exact != null) return exact.Name;
            var primary = translations.FirstOrDefault(t =>
                string.Equals(t.LanguageCode, current.TwoLetterISOLanguageName, StringComparison.OrdinalIgnoreCase));
            if (primary != null) return primary.Name;
            var def = translations.FirstOrDefault(t => t.IsDefault);
            if (def != null) return def.Name;
            return translations.First().Name;
        }

        return src.Name ?? string.Empty;
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