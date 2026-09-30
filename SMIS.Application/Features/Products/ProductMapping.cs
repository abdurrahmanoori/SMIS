using SMIS.Application.DTO.Products;
using SMIS.Application.Features.Categories;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.Products;

internal static class ProductMapping
{
    public static ProductDto ToDto(Product product) => new()
    {
        Id = product.Id,
        Name = product.Name,
        ShopId = product.ShopId,
        BaseUnitId = product.BaseUnitId,
        Description = product.Description,
        IsActive = product.IsActive,
        SKU = product.SKU,
        Barcode = product.Barcode,
        ImageUrl = product.ImageUrl,
        CategoryId = product.CategoryId,
        ReorderPointBase = product.ReorderPointBase,
        ReorderQuantityBase = product.ReorderQuantityBase,
        Category = product.Category is null ? null : CategoryMapping.ToDto(product.Category),
        CreatedDate = AsUtc(product.CreatedDate),
        CreatedBy = product.CreatedBy,
        UpdatedDate = AsUtc(product.UpdatedDate),
        UpdatedBy = product.UpdatedBy,
        ClientModifiedDate = AsUtc(product.ClientModifiedDate),
        LastModifiedUtc = AsUtc(product.LastModifiedUtc),
        IsDeleted = product.IsDeleted
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
