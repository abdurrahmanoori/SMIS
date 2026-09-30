using SMIS.Application.DTO.ProductPrices;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.ProductPrices;

internal static class ProductPriceMapping
{
    public static ProductPriceDto ToDto(ProductPrice price) => new()
    {
        Id = price.Id,
        ProductUnitId = price.ProductUnitId,
        SellPrice = price.SellPrice,
        EffectiveDate = price.EffectiveDate,
        EndDate = price.EndDate,
        ClientModifiedDate = AsUtc(price.ClientModifiedDate),
        LastModifiedUtc = AsUtc(price.LastModifiedUtc),
        IsDeleted = price.IsDeleted
    };

    private static DateTime AsUtc(DateTime value) => value.Kind switch
    {
        DateTimeKind.Utc => value,
        DateTimeKind.Local => value.ToUniversalTime(),
        _ => DateTime.SpecifyKind(value, DateTimeKind.Utc)
    };

    private static DateTime? AsUtc(DateTime? value) =>
        value.HasValue ? AsUtc(value.Value) : null;
}
