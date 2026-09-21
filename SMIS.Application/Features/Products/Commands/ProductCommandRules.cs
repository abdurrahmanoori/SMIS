using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Products;
using SMIS.Application.Repositories.ProductUnits;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.Products.Commands;

/// <summary>
/// Product business mutations shared by the direct API and the offline sync API.
/// Conflict detection, client metadata and authorization remain sync concerns.
/// </summary>
internal static class ProductCommandRules
{
    public static Product Create(
        ProductCreateDto dto,
        string shopId
    ) =>
        Create(
            dto.Name,
            shopId,
            dto.BaseUnitId,
            dto.SKU,
            dto.IsActive,
            dto.Description,
            dto.Barcode,
            dto.ImageUrl,
            dto.CategoryId,
            dto.ReorderPointBase,
            dto.ReorderQuantityBase);

    public static Product Create(
        ProductSyncUpdateDto dto,
        string shopId
    ) =>
        Create(
            dto.Name,
            shopId,
            dto.BaseUnitId,
            dto.SKU,
            dto.IsActive,
            dto.Description,
            dto.Barcode,
            dto.ImageUrl,
            dto.CategoryId,
            dto.ReorderPointBase,
            dto.ReorderQuantityBase);

    public static bool Apply(
        Product product,
        ProductCreateDto dto
    ) =>
        Apply(
            product,
            dto.Name,
            dto.BaseUnitId,
            dto.SKU,
            dto.IsActive,
            dto.Description,
            dto.Barcode,
            dto.ImageUrl,
            dto.CategoryId,
            dto.ReorderPointBase,
            dto.ReorderQuantityBase);

    public static bool Apply(
        Product product,
        ProductSyncUpdateDto dto
    ) =>
        Apply(
            product,
            dto.Name,
            dto.BaseUnitId,
            dto.SKU,
            dto.IsActive,
            dto.Description,
            dto.Barcode,
            dto.ImageUrl,
            dto.CategoryId,
            dto.ReorderPointBase,
            dto.ReorderQuantityBase);

    public static async Task<ProductUnit> EnsureBaseProductUnitAsync(
        Product product,
        string oldBaseUnitId,
        IProductUnitRepository productUnits,
        CancellationToken cancellationToken
    )
    {
        var baseProductUnit = await productUnits.GetFirstOrDefaultAsync(item =>
            item.ProductId == product.Id && item.UnitOfMeasureId == oldBaseUnitId);

        if (baseProductUnit is null)
        {
            baseProductUnit = ProductUnit.Create(product.Id, product.BaseUnitId, 1m);
            await productUnits.AddAsync(baseProductUnit);
        }
        else
        {
            baseProductUnit.SetUnitOfMeasureId(product.BaseUnitId);
            baseProductUnit.SetBaseUnitQuantity(1m);
        }

        baseProductUnit.SetProductName(product.Name);
        return baseProductUnit;
    }

    public static Result<ProductDto> BaseUnitIsLocked() =>
        Result<ProductDto>.FailureResult(
            "BaseUnitChangeNotAllowed",
            "Base unit cannot be changed after stock or product-unit conversions exist.");

    private static Product Create(
        string name,
        string shopId,
        string baseUnitId,
        string sku,
        bool isActive,
        string? description,
        string? barcode,
        string? imageUrl,
        string? categoryId,
        decimal reorderPointBase,
        decimal reorderQuantityBase
    )
    {
        var product = Product.Create(
            name,
            shopId,
            baseUnitId,
            sku,
            isActive,
            description,
            barcode,
            imageUrl,
            categoryId);

        product.SetReorderPolicy(reorderPointBase, reorderQuantityBase);
        return product;
    }

    private static bool Apply(
        Product product,
        string name,
        string baseUnitId,
        string sku,
        bool isActive,
        string? description,
        string? barcode,
        string? imageUrl,
        string? categoryId,
        decimal reorderPointBase,
        decimal reorderQuantityBase
    )
    {
        var baseUnitChanged = product.IsBaseUnitChange(baseUnitId);

        product.SetName(name);
        if (baseUnitChanged)
            product.ChangeBaseUnit(baseUnitId, hasStockOrConversions: false);
        product.SetSKU(sku);
        product.SetDescription(description);
        product.SetBarcode(barcode);
        product.SetImageUrl(imageUrl);
        product.SetCategoryId(categoryId);
        product.SetReorderPolicy(reorderPointBase, reorderQuantityBase);

        if (isActive)
            product.Activate();
        else
            product.Deactivate();

        return baseUnitChanged;
    }
}