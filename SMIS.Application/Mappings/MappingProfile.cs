using AutoMapper;
using SMIS.Application.DTO.Localization;
using SMIS.Application.DTO.Provinces;
using SMIS.Application.DTO.Customers;
using SMIS.Application.DTO.ShopOwners;
using SMIS.Application.DTO.LoanAccounts;
using SMIS.Application.DTO.Sales;
using SMIS.Application.DTO.StockMovements;
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

        // Province translation management is not part of the Flutter location CRUD flow yet.
        CreateMap<ProvinceTranslation, ProvinceTranslationDto>()
            .ForMember(dest => dest.LanguageCode, opt => opt.MapFrom(src => src.LanguageCode))
            .ForMember(dest => dest.LanguageId, opt => opt.MapFrom(src => src.LanguageId))
            .ReverseMap()
            .ForMember(dest => dest.LanguageCode, opt => opt.MapFrom(src => src.LanguageCode))
            .ForMember(dest => dest.LanguageId, opt => opt.MapFrom(src => src.LanguageId));

        // Compatibility mapping for backend-only sale-return code. Flutter stock handlers
        // use StockMovementMapping directly; this remains until Sale is migrated separately.
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

    private static DateTime AsUtc(DateTime value) => value.Kind switch
    {
        DateTimeKind.Utc => value,
        DateTimeKind.Local => value.ToUniversalTime(),
        _ => DateTime.SpecifyKind(value, DateTimeKind.Utc)
    };

    private static DateTime? AsUtc(DateTime? value) =>
        value.HasValue ? AsUtc(value.Value) : null;
}
