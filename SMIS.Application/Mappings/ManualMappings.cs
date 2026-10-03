using System.Globalization;
using SMIS.Application.DTO.Categories;
using SMIS.Application.DTO.Customers;
using SMIS.Application.DTO.Districts;
using SMIS.Application.DTO.LoanAccounts;
using SMIS.Application.DTO.Localization;
using SMIS.Application.DTO.ProductPrices;
using SMIS.Application.DTO.Products;
using SMIS.Application.DTO.ProductUnits;
using SMIS.Application.DTO.Provinces;
using SMIS.Application.DTO.Sales;
using SMIS.Application.DTO.ShopOwners;
using SMIS.Application.DTO.Shops;
using SMIS.Application.DTO.StockBatches;
using SMIS.Application.DTO.StockMovements;
using SMIS.Application.DTO.UnitOfMeasures;
using SMIS.Application.DTO.Users;
using SMIS.Application.Features.Categories;
using SMIS.Domain.Entities;
using SMIS.Domain.Entities.Identity.Entity;
using SMIS.Domain.Entities.Localization;
using SMIS.Domain.Entities.LocationEntities;

namespace SMIS.Application.Mappings;

internal static class ManualMappings
{
    public static CustomerDto ToDto(
        this Customer value
    ) => new()
    {
        Id = value.Id,
        FirstName = value.FirstName,
        LastName = value.LastName,
        ShopId = value.ShopId,
        ShopName = value.ShopName,
        CustomerType = value.CustomerType,
        FatherName = value.FatherName,
        Email = value.Email,
        PhoneNumber = value.PhoneNumber,
        Address = value.Address,
        TaxNumber = value.TaxNumber,
        ProvinceId = value.ProvinceId,
        DistrictId = value.DistrictId,
        IsActive = value.IsActive,
        CreatedDate = AsUtc(value.CreatedDate),
        CreatedBy = value.CreatedBy,
        UpdatedDate = AsUtc(value.UpdatedDate),
        UpdatedBy = value.UpdatedBy,
        LastModifiedUtc = AsUtc(value.LastModifiedUtc),
        IsDeleted = value.IsDeleted
    };

    public static ProductDto ToDto(
        this Product value
    ) => new()
    {
        Id = value.Id,
        Name = value.Name,
        ShopId = value.ShopId,
        BaseUnitId = value.BaseUnitId,
        Description = value.Description,
        IsActive = value.IsActive,
        SKU = value.SKU,
        Barcode = value.Barcode,
        ImageUrl = value.ImageUrl,
        CategoryId = value.CategoryId,
        ReorderPointBase = value.ReorderPointBase,
        ReorderQuantityBase = value.ReorderQuantityBase,
        Category = value.Category is null ? null : CategoryMapping.ToDto(value.Category),
        CreatedDate = AsUtc(value.CreatedDate),
        CreatedBy = value.CreatedBy,
        UpdatedDate = AsUtc(value.UpdatedDate),
        UpdatedBy = value.UpdatedBy,
        ClientModifiedDate = AsUtc(value.ClientModifiedDate),
        LastModifiedUtc = AsUtc(value.LastModifiedUtc),
        IsDeleted = value.IsDeleted
    };

    public static ShopDto ToDto(
        this Shop value
    ) => new()
    {
        Id = value.Id,
        Name = value.Name,
        ShopType = value.ShopType,
        Address = value.Address,
        PhoneNumber = value.PhoneNumber,
        Email = value.Email,
        TaxNumber = value.TaxNumber,
        IsActive = value.IsActive,
        LastModifiedUtc = AsUtc(value.LastModifiedUtc),
        IsDeleted = value.IsDeleted,
        ClientModifiedDate = AsUtc(value.ClientModifiedDate)
    };

    public static UserDto ToDto(
        this ApplicationUser value
    ) => new()
    {
        Id = value.Id,
        UserName = value.UserName,
        Email = value.Email,
        PhoneNumber = value.PhoneNumber,
        FirstName = value.FirstName,
        LastName = value.LastName,
        ShopId = value.ShopId,
        LanguageId = value.LanguageId,
        EmailConfirmed = value.EmailConfirmed,
        PhoneNumberConfirmed = value.PhoneNumberConfirmed,
        IsActive = value.IsActive,
        IsLocked = value.LockoutEnabled && value.LockoutEnd.HasValue && value.LockoutEnd > DateTimeOffset.UtcNow,
        LockoutEnd = value.LockoutEnd,
        Shop = value.Shop is null ? null : value.Shop.ToDto()
    };

    public static DistrictDto ToDto(
        this District value
    ) => new()
    {
        Id = value.Id,
        Name = value.Name,
        ProvinceId = value.ProvinceId,
        ProvinceName = value.Province?.Name ?? string.Empty
    };

    public static District ToEntity(
        this DistrictCreateDto value
    ) => new()
    {
        Name = value.Name,
        ProvinceId = value.ProvinceId
    };

    public static void ApplyTo(
        this DistrictCreateDto source,
        District target
    )
    {
        target.Name = source.Name;
        target.ProvinceId = source.ProvinceId;
    }

    public static ProvinceDto ToDto(
        this Province value
    ) => new()
    {
        Id = value.Id,
        Name = ResolveProvinceName(value)
    };

    public static Province ToEntity(
        this ProvinceCreateDto value
    )
    {
        var province = new Province { Name = value.Name };
        if (value.Translations is { Count: > 0 })
        {
            province.Translations = value.Translations.Select(ToEntity).ToList();
        }
        else if (!string.IsNullOrWhiteSpace(value.Name))
        {
            province.Translations =
            [
                new ProvinceTranslation
                {
                    LanguageCode = "en",
                    LanguageId = "1",
                    IsDefault = true,
                    Name = value.Name
                }
            ];
        }

        return province;
    }

    public static ProvinceTranslationDto ToDto(
        this ProvinceTranslation value
    ) => new()
    {
        Id = value.Id,
        ProvinceId = value.ProvinceId,
        LanguageCode = value.LanguageCode,
        LanguageId = value.LanguageId,
        IsDefault = value.IsDefault,
        Name = value.Name
    };

    public static ProvinceTranslation ToEntity(
        this ProvinceTranslationDto value
    ) => new()
    {
        Id = value.Id,
        ProvinceId = value.ProvinceId,
        LanguageCode = value.LanguageCode,
        LanguageId = value.LanguageId,
        IsDefault = value.IsDefault,
        Name = value.Name
    };

    public static ProvinceTranslation ToEntity(
        this TranslationDto value
    ) => new()
    {
        LanguageCode = value.LanguageCode,
        LanguageId = value.LanguageId,
        IsDefault = value.IsDefault,
        Name = value.Name
    };

    public static void ApplyTo(
        this ProvinceTranslationDto source,
        ProvinceTranslation target
    )
    {
        target.ProvinceId = source.ProvinceId;
        target.LanguageCode = source.LanguageCode;
        target.LanguageId = source.LanguageId;
        target.IsDefault = source.IsDefault;
        target.Name = source.Name;
    }

    public static LanguageDto ToDto(
        this Language value
    ) => new()
    {
        Id = value.Id,
        Name = value.Name,
        Code = value.Code,
        IsActive = value.IsActive
    };

    public static Language ToEntity(
        this LanguageCreateDto value
    ) => new()
    {
        Name = value.Name,
        Code = value.Code,
        IsActive = value.IsActive
    };

    public static void ApplyTo(
        this LanguageCreateDto source,
        Language target
    )
    {
        target.Name = source.Name;
        target.Code = source.Code;
        target.IsActive = source.IsActive;
    }

    public static ProductUnitDto ToDto(
        this ProductUnit value
    ) => new()
    {
        Id = value.Id,
        ProductId = value.ProductId,
        UnitOfMeasureId = value.UnitOfMeasureId,
        BaseUnitQuantity = value.BaseUnitQuantity,
        ClientModifiedDate = AsUtc(value.ClientModifiedDate),
        LastModifiedUtc = AsUtc(value.LastModifiedUtc),
        IsDeleted = value.IsDeleted,
        Product = value.Product is null ? null : value.Product.ToDto(),
        UnitOfMeasure = value.UnitOfMeasure is null ? null : value.UnitOfMeasure.ToDto()
    };

    public static ProductUnit ToEntity(
        this ProductUnitCreateDto value
    ) =>
        ProductUnit.Create(value.ProductId, value.UnitOfMeasureId, value.BaseUnitQuantity);

    public static ProductPriceDto ToDto(
        this ProductPrice value
    ) => new()
    {
        Id = value.Id,
        ProductUnitId = value.ProductUnitId,
        SellPrice = value.SellPrice,
        EffectiveDate = value.EffectiveDate,
        EndDate = value.EndDate,
        ClientModifiedDate = AsUtc(value.ClientModifiedDate),
        LastModifiedUtc = AsUtc(value.LastModifiedUtc),
        IsDeleted = value.IsDeleted
    };

    public static UnitOfMeasureDto ToDto(
        this UnitOfMeasure value
    ) => new()
    {
        Id = value.Id,
        Name = value.Name,
        Symbol = value.Symbol,
        Description = value.Description,
        ClientModifiedDate = AsUtc(value.ClientModifiedDate),
        LastModifiedUtc = AsUtc(value.LastModifiedUtc),
        IsDeleted = value.IsDeleted
    };

    public static StockBatchDto ToDto(
        this StockBatch value
    ) => new()
    {
        Id = value.Id,
        ShopId = value.ShopId,
        ProductId = value.ProductId,
        ReceivedProductUnitId = value.ReceivedProductUnitId,
        ReceivedQuantity = value.ReceivedQuantity,
        ReceivedQuantityBase = value.ReceivedQuantityBase,
        RemainingQuantityBase = value.RemainingQuantityBase,
        UnitCostBase = value.UnitCostBase,
        BatchNumber = value.BatchNumber,
        ReceivedAtUtc = value.ReceivedAtUtc,
        ExpirationDate = value.ExpirationDate,
        Status = value.Status
    };

    public static StockMovementDto ToDto(
        this StockMovement value
    ) => new()
    {
        Id = value.Id,
        ShopId = value.ShopId,
        OperationId = value.OperationId,
        StockBatchId = value.StockBatchId,
        ProductUnitId = value.ProductUnitId,
        QuantityEntered = value.QuantityEntered,
        QuantityBase = value.QuantityBase,
        Direction = value.Direction,
        Reason = value.Reason,
        OccurredAtUtc = value.OccurredAtUtc,
        ReferenceType = value.ReferenceType,
        ReferenceId = value.ReferenceId
    };

    public static SaleLineDto ToDto(
        this SaleLine value
    ) => new()
    {
        Id = value.Id,
        SaleId = value.SaleId,
        ProductId = value.ProductId,
        ProductUnitId = value.ProductUnitId,
        QuantityEntered = value.QuantityEntered,
        ReturnedQuantityEntered = value.ReturnedQuantityEntered,
        ReturnableQuantityEntered = value.ReturnableQuantityEntered,
        UnitPrice = value.UnitPrice,
        LineTotal = value.LineTotal
    };

    public static SaleDto ToDto(
        this Sale value
    ) => new()
    {
        Id = value.Id,
        ShopId = value.ShopId,
        CustomerId = value.CustomerId,
        SaleDateUtc = value.SaleDateUtc,
        PaymentType = value.PaymentType,
        TotalAmount = value.TotalAmount,
        ReturnedAmount = value.ReturnedAmount,
        NetAmount = value.NetAmount,
        Status = value.Status,
        Notes = value.Notes,
        ReceivableId = value.Receivable?.Id,
        ReceivableRemainingAmount = value.Receivable?.RemainingAmount,
        Lines = value.Lines.Select(ToDto).ToList()
    };

    public static ShopOwnerDto ToDto(
        this ShopOwner value
    ) => new()
    {
        Id = value.Id,
        ApplicationUserId = value.ApplicationUserId,
        ShopId = value.ShopId,
        ShopName = value.ShopName,
        FirstName = value.FirstName,
        LastName = value.LastName,
        NationalIdCardNumber = value.NationalIdCardNumber,
        PhoneNumber = value.PhoneNumber,
        Email = value.Email,
        Address = value.Address,
        OwnershipPercentage = value.OwnershipPercentage,
        StartDate = value.StartDate,
        EndDate = value.EndDate,
        IsActive = value.IsActive,
        ProvinceId = value.ProvinceId,
        DistrictId = value.DistrictId
    };

    public static LoanAccountDto ToDto(
        this LoanAccount value
    ) => new()
    {
        Id = value.Id,
        SaleId = value.SaleId,
        CustomerId = value.CustomerId,
        CustomerName = value.CustomerName,
        ShopId = value.ShopId,
        ShopName = value.ShopName,
        TotalAmount = value.TotalAmount,
        LoanDate = value.LoanDate,
        DueDate = value.DueDate,
        Status = value.Status,
        Notes = value.Notes,
        IsActive = value.IsActive,
        PaidAmount = value.PaidAmount,
        RemainingAmount = value.RemainingAmount
    };

    public static ApplicationUser ToEntity(
        this UserCreateDto value
    ) => ApplicationUser.Create(
        value.UserName,
        value.Email,
        value.ShopId,
        value.FirstName,
        value.LastName,
        value.PhoneNumber,
        value.LanguageId);

    private static string ResolveProvinceName(
        Province value
    )
    {
        if (value.Translations is { Count: > 0 })
        {
            var current = CultureInfo.CurrentUICulture;
            var exact = value.Translations.FirstOrDefault(t =>
                string.Equals(t.LanguageCode, current.Name, StringComparison.OrdinalIgnoreCase));
            if (exact is not null) return exact.Name;

            var primary = value.Translations.FirstOrDefault(t =>
                string.Equals(t.LanguageCode, current.TwoLetterISOLanguageName, StringComparison.OrdinalIgnoreCase));
            if (primary is not null) return primary.Name;

            var @default = value.Translations.FirstOrDefault(t => t.IsDefault);
            if (@default is not null) return @default.Name;

            return value.Translations.First().Name;
        }

        return value.Name ?? string.Empty;
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