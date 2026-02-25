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
using SMIS.Application.DTO.TranslationKeys;
using SMIS.Application.DTO.Translations;
using SMIS.Application.DTO.StockTransactions;
using SMIS.Domain.Entities;
using SMIS.Domain.Entities.Localization;
using SMIS.Domain.Entities.LocationEntities;
using SMIS.Domain.Entities.Identity.Entity;
using SMIS.Domain.Enums;
using SMIS.Application.DTO.ProductPrices;
using SMIS.Application.DTO.Customers;
using SMIS.Application.DTO.ShopOwners;
using SMIS.Application.DTO.LoanAccounts;

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
                src.IsActive,
                src.Description,
                src.Barcode,
                src.ImageUrl,
                src.CategoryId
            ));

        // UnitOfMeasure mapping
        CreateMap<UnitOfMeasure, UnitOfMeasureDto>().ReverseMap();
        CreateMap<UnitOfMeasureCreateDto, UnitOfMeasure>()
            .ConstructUsing(src => UnitOfMeasure.Create(
                src.Name,
                src.Symbol,
                src.ShopId,
                src.Description
            ));

        // Category mapping
        CreateMap<Category, CategoryDto>().ReverseMap();
        // CategoryCreateDto mapping removed - use Category.Create() in handler with ICurrentUser.GetShopId()


        // ProductUnit mapping
        CreateMap<ProductUnit, ProductUnitDto>().ReverseMap();
        CreateMap<ProductUnitCreateDto, ProductUnit>()
            .ConstructUsing(src => ProductUnit.Create(
                src.ProductId,
                src.UnitOfMeasureId,
                src.ConversionFactor
            ));

        // ProductPrice mapping
        CreateMap<ProductPrice, ProductPriceDto>().ReverseMap();
        CreateMap<ProductPriceCreateDto, ProductPrice>()
            .ConstructUsing(src => ProductPrice.Create(
                src.ProductId,
                src.ProductUnitId,
                src.BuyPrice,
                src.SellPrice,
                src.EffectiveDate
            ))
            .AfterMap((src, dest) =>
            {
                dest.SetEndDate(src.EndDate);
                if (src.IsActive) dest.Activate(); else dest.Deactivate();
            });

        // TranslationKey mapping
        CreateMap<TranslationKey, TranslationKeyDto>().ReverseMap();
        CreateMap<TranslationKey, TranslationKeyCreateDto>().ReverseMap();

        // Translation mapping
        CreateMap<Translation, TranslationEntityDto>().ReverseMap();
        CreateMap<Translation, TranslationEntityCreateDto>().ReverseMap();

        // StockBatch mapping
        CreateMap<StockBatch, StockBatchDto>().ReverseMap();
        CreateMap<StockBatchCreateDto, StockBatch>()
            .ConstructUsing(src => StockBatch.Create(
                src.ProductId,
                src.UnitId,
                src.Quantity,
                src.PurchasePrice,
                src.ReceivedDate,
                src.BatchNumber,
                src.ExpirationDate
            ));

        // StockTransaction mapping
        CreateMap<StockTransaction, StockTransactionDto>()
            .ForMember(dest => dest.Type, opt => opt.MapFrom(src => Enum.Parse<TransactionType>(src.Type)));
        CreateMap<StockTransactionCreateDto, StockTransaction>()
            .ConstructUsing(src => StockTransaction.Create(
                src.ShopId,
                src.ProductId,
                src.StockBatchId,
                src.Quantity,
                src.UnitId,
                src.Type,
                src.TransactionDate,
                src.Reference
            ));

        // Customer mapping
        CreateMap<Customer, CustomerDto>().ReverseMap();
        CreateMap<CustomerCreateDto, Customer>()
            .ConstructUsing(src => Customer.Create(
                src.FirstName,
                src.ShopId,
                src.CustomerType,
                src.LastName,
                src.FatherName,
                src.Email,
                src.PhoneNumber,
                src.Address,
                src.TaxNumber,
                src.ProvinceId,
                src.DistrictId,
                src.IsActive
            ));

        // ShopOwner mapping
        CreateMap<ShopOwner, ShopOwnerDto>().ReverseMap();
        CreateMap<ShopOwnerCreateDto, ShopOwner>()
            .ConstructUsing(src => ShopOwner.Create(
                src.ApplicationUserId,
                src.ShopId,
                src.FirstName,
                src.LastName,
                src.PhoneNumber,
                src.Email,
                src.Address,
                src.OwnershipPercentage
            ))
            .AfterMap((src, dest) =>
            {
                dest.SetNationalIdCardNumber(src.NationalIdCardNumber);
                if (src.IsActive) dest.Activate(); else dest.Deactivate();
            });

        // LoanAccount mapping
        CreateMap<LoanAccount, LoanAccountDto>()
            .ForMember(dest => dest.PaidAmount, opt => opt.MapFrom(src => src.PaidAmount))
            .ForMember(dest => dest.RemainingAmount, opt => opt.MapFrom(src => src.RemainingAmount));
        CreateMap<LoanAccountCreateDto, LoanAccount>()
            .ConstructUsing(src => LoanAccount.Create(
                src.CustomerId,
                src.ShopId,
                src.ProductId,
                src.Quantity,
                src.UnitId,
                src.PriceAtLoanTime,
                src.TotalAmount,
                src.DueDate,
                src.Notes
            ));
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