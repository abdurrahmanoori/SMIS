using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Exceptions;

namespace SMIS.Domain.Entities;

public class Product : BaseAuditableEntity, IEntity
{
    public string Name { get; set; } = string.Empty;
 
    public string BaseUnitId { get; private set; } = string.Empty;
    public string? BaseUnitName { get; set; }
    public int SalePricePerBaseUnit { get; private set; }
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
    public virtual Shop Shop { get; set; } = null!;
    public UnitOfMeasure UnitOfMeasure { get; set; } = null!;
    public virtual Category? Category { get; set; }
    public virtual ICollection<ProductUnit> ProductUnits { get; set; } = new List<ProductUnit>();
    public virtual ICollection<ProductPrice> ProductPrices { get; set; } = new List<ProductPrice>();

    internal Product() { } // EF Core & Seeding

    public static Product Create(string name, string shopId, string baseUnitId, string sku, int salePricePerBaseUnit, bool isActive = true, string? description = null, string? barcode = null, string? imageUrl = null, string? categoryId = null)
    {
        var product = new Product();
        product.SetName(name);
        product.SetShopId(shopId);
        product.SetBaseUnitId(baseUnitId);
        product.SetSKU(sku);
        product.SetSalePricePerBaseUnit(salePricePerBaseUnit);
        product.SetDescription(description);
        if (!string.IsNullOrWhiteSpace(barcode)) product.SetBarcode(barcode);
        product.SetImageUrl(imageUrl);
        product.SetCategoryId(categoryId);
        if (!isActive) product.Deactivate();
        return product;
    }

    public void SetName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new DomainValidationException("Product name cannot be empty");

        if (name.Length > 200)
            throw new DomainValidationException("Product name cannot exceed 200 characters");

        Name = name.Trim();
    }

    public void SetShopId(string shopId)
    {
        if (string.IsNullOrWhiteSpace(shopId))
            throw new DomainValidationException("Shop ID cannot be empty");

        ShopId = shopId;
    }

    public void SetBaseUnitId(string baseUnitId)
    {
        if (string.IsNullOrWhiteSpace(baseUnitId))
            throw new DomainValidationException("Base unit ID cannot be empty");

        BaseUnitId = baseUnitId;
    }

    public void SetSKU(string? sku)
    {
        var skuVO = ValueObjects.SKU.Create(sku);
        SKU = skuVO;
    }

    public void SetSalePricePerBaseUnit(int price)
    {
        if (price < 0)
            throw new DomainValidationException("Sale price cannot be negative");

        SalePricePerBaseUnit = price;
    }

    public void SetDescription(string? description)
    {
        if (description?.Length > 1000)
            throw new DomainValidationException("Description cannot exceed 1000 characters");

        Description = description?.Trim();
    }

    public void SetBarcode(string barcode)
    {
        var barcodeVO = ValueObjects.Barcode.Create(barcode);
        Barcode = barcodeVO;
    }

    public void SetImageUrl(string? imageUrl)
    {
        if (imageUrl?.Length > 500)
            throw new DomainValidationException("Image URL cannot exceed 500 characters");

        ImageUrl = imageUrl?.Trim();
    }

    public void SetCategoryId(string? categoryId)
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
