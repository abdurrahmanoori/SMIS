using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Exceptions;
using SMIS.Domain.Common.Interfaces;

namespace SMIS.Domain.Entities;

public class Product : BaseSyncableAuditableEntity, IEntity, IShopEntity
{
    public string Name { get; private set; } = string.Empty;

    public string BaseUnitId { get; private set; } = string.Empty;
    public string? BaseUnitName { get; set; }
    public string? Description { get; private set; }
    public bool IsActive { get; private set; } = true;
    public string? SKU { get; private set; } = string.Empty;
    public string? Barcode { get; private set; }
    public string? ImageUrl { get; private set; }

    public string? CategoryId { get; private set; }
    public string? CategoryName { get; set; }
    public string ShopId { get; private set; } = string.Empty;

    public string? ShopName { get; set; }

    // Navigation Properties
    public Shop Shop { get; set; } = null!;
    public UnitOfMeasure UnitOfMeasure { get; set; } = null!;
    public Category? Category { get; set; }
    public ICollection<ProductUnit> ProductUnits { get; set; } = new List<ProductUnit>();

    internal Product()
    {
    } // EF Core & Seeding

    public static Product Create(
        string name,
        string shopId,
        string baseUnitId,
        string sku,
        bool isActive = true,
        string? description = null,
        string? barcode = null,
        string? imageUrl = null,
        string? categoryId = null
    )
    {
        var product = new Product();
        product.SetName(name);
        product.SetShopId(shopId);
        product.SetBaseUnitId(baseUnitId);
        product.SetSKU(sku);
        product.SetDescription(description);
        product.SetBarcode(barcode);
        product.SetImageUrl(imageUrl);
        product.SetCategoryId(categoryId);
        if (!isActive) product.Deactivate();
        return product;
    }

    public void SetName(
        string name
    )
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new DomainValidationException("Product name cannot be empty");

        Name = name.Trim();
    }

    public void SetShopId(
        string shopId
    )
    {
        if (string.IsNullOrWhiteSpace(shopId))
            throw new DomainValidationException("Shop ID cannot be empty");

        ShopId = shopId;
    }

    public bool IsBaseUnitChange(
        string baseUnitId
    ) =>
        !string.Equals(BaseUnitId, NormalizeBaseUnitId(baseUnitId), StringComparison.Ordinal);

    public void ChangeBaseUnit(
        string baseUnitId,
        bool hasStockOrConversions
    )
    {
        var normalizedBaseUnitId = NormalizeBaseUnitId(baseUnitId);
        if (string.Equals(BaseUnitId, normalizedBaseUnitId, StringComparison.Ordinal)) return;

        if (hasStockOrConversions)
            throw new DomainValidationException(
                "Base unit cannot be changed after stock or product-unit conversions exist.");

        BaseUnitId = normalizedBaseUnitId;
    }

    private void SetBaseUnitId(
        string baseUnitId
    )
    {
        BaseUnitId = NormalizeBaseUnitId(baseUnitId);
    }

    private static string NormalizeBaseUnitId(
        string baseUnitId
    )
    {
        if (string.IsNullOrWhiteSpace(baseUnitId))
            throw new DomainValidationException("Base unit ID cannot be empty");

        return baseUnitId.Trim();
    }

    public void SetSKU(
        string? sku
    )
    {
        var skuVO = ValueObjects.SKU.Create(sku);
        SKU = skuVO;
    }

    public void SetDescription(
        string? description
    )
    {
        Description = description?.Trim();
    }

    public void SetBarcode(
        string? barcode
    )
    {
        if (string.IsNullOrWhiteSpace(barcode))
        {
            Barcode = null;
            return;
        }

        var barcodeVO = ValueObjects.Barcode.Create(barcode);
        Barcode = barcodeVO;
    }

    public void SetImageUrl(
        string? imageUrl
    )
    {
        ImageUrl = imageUrl?.Trim();
    }

    public void SetCategoryId(
        string? categoryId
    )
    {
        CategoryId = categoryId;
    }

    public void Activate() => IsActive = true;
    public void Deactivate() => IsActive = false;
}


/*

| Id | Name        | Category   | Base Unit |
| -- | ----------- | ---------- | --------- |
| 1  | Coca Cola   | Drinks     | Bottle    |
| 2  | Pepsi       | Drinks     | Bottle    |
| 3  | Biscuit     | Food       | Pack      |
| 4  | Notebook    | Stationery | Piece     |
| 5  | Cooking Oil | Grocery    | Liter     |

*/