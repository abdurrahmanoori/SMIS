using SMIS.Application.DTO.ProductUnits;
using SMIS.Application.Features.Products;
using SMIS.Application.Features.UnitOfMeasures;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.ProductUnits;

internal static class ProductUnitMapping
{
    public static ProductUnitDto ToDto(ProductUnit productUnit) => new()
    {
        Id = productUnit.Id,
        ProductId = productUnit.ProductId,
        UnitOfMeasureId = productUnit.UnitOfMeasureId,
        BaseUnitQuantity = productUnit.BaseUnitQuantity,
        ClientModifiedDate = AsUtc(productUnit.ClientModifiedDate),
        LastModifiedUtc = AsUtc(productUnit.LastModifiedUtc),
        IsDeleted = productUnit.IsDeleted,
        Product = productUnit.Product is null ? null : ProductMapping.ToDto(productUnit.Product),
        UnitOfMeasure = productUnit.UnitOfMeasure is null
            ? null
            : UnitOfMeasureMapping.ToDto(productUnit.UnitOfMeasure)
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
