using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Exceptions;
using SMIS.Domain.ValueObjects;

namespace SMIS.Domain.Entities;

/// <summary>
/// Defines how a specific Unit is converted for a specific Product.
/// This entity exists because the same Unit (e.g. Box, Carton)
/// can represent different quantities for different products.
/// </summary>
public class ProductUnit : EntityPK
{
    /// <summary>
    /// Foreign key to the Product.
    /// Example: Biscuit, Notebook, Coca Cola
    /// </summary>
    public string ProductId { get; private set; } = string.Empty;
    public string? ProductName { get; private set; }

    /// <summary>
    /// Foreign key to Unit.
    /// Example: Box, Carton, Pack
    /// </summary>
    public string UnitOfMeasureId { get; private set; } = string.Empty;
    public string? UnitName { get; private set; }

    /// <summary>
    /// How many Base Units of the Product are contained in this Unit.
    /// 
    /// Example:
    /// - Biscuit: 1 Box = 12 Packs → ConversionFactor = 12
    /// - Notebook: 1 Box = 10 Pieces → ConversionFactor = 10
    /// - Coca Cola: 1 Carton = 24 Bottles → ConversionFactor = 24
    /// </summary>
    public decimal ConversionFactor { get; private set; }

    /// <summary>
    /// Navigation property to Product.
    /// </summary>
    public Product Product { get; set; } = null!;

    /// <summary>
    /// Navigation property to Unit.
    /// </summary>
    public UnitOfMeasure UnitOfMeasure { get; set; } = null!;

    internal ProductUnit() { } // EF Core & Seeding

    public static ProductUnit Create(string productId, string unitOfMeasureId, decimal conversionFactor)
    {
        var productUnit = new ProductUnit();
        productUnit.SetProductId(productId);
        productUnit.SetUnitOfMeasureId(unitOfMeasureId);
        productUnit.SetConversionFactor(conversionFactor);
        return productUnit;
    }

    public void SetProductId(string productId)
    {
        if (string.IsNullOrWhiteSpace(productId))
            throw new DomainValidationException("Product ID cannot be empty");

        ProductId = productId.Trim();
    }

    public void SetUnitOfMeasureId(string unitOfMeasureId)
    {
        if (string.IsNullOrWhiteSpace(unitOfMeasureId))
            throw new DomainValidationException("Unit of measure ID cannot be empty");

        UnitOfMeasureId = unitOfMeasureId.Trim();
    }

    public void SetConversionFactor(decimal conversionFactor)
    {
        var conversionFactorVO = ValueObjects.ConversionFactor.Create(conversionFactor);
        ConversionFactor = conversionFactorVO;
    }

    public void SetProductName(string? productName) => ProductName = productName?.Trim();
    public void SetUnitName(string? unitName) => UnitName = unitName?.Trim();
}




/*
📌 IMPORTANT NOTE — Why ProductUnit Exists


Units do NOT mean the same thing for every product.

A Box is not a universal quantity.

A Carton is not a fixed number.

A Pack depends on what is inside it.

Example from real life
| Product   | Unit   | Quantity inside |
| --------- | ------ | --------------- |
| Biscuit   | Box    | 12 Packs        |
| Notebook  | Box    | 10 Pieces       |
| Coca‑Cola | Carton | 24 Bottles      |
| Eggs      | Carton | 30 Pieces       |
Same unit name → different meaning. 

❌ Wrong Thinking (Beginner Mistake)
Box = 12
Carton = 24
This will silently destroy your inventory data.
✅ Correct Thinking (Professional Thinking)

A unit only describes the container.
The product defines how much that container holds.

So conversion belongs to:
Product + Unit → ConversionFactor
That is exactly why ProductUnit exists.
🧠 Mental Rule (Never Forget This)

Unit = label
ProductUnit = meaning

If you remember only ONE sentence from this system, remember this one.
📐 What ProductUnit Does

It answers one question:

“For THIS product, how many base units are inside THIS unit?”

Example:
1 Box of Biscuit = 12 Packs
1 Box of Notebook = 10 Pieces
1 Carton of Coke = 24 Bottles





*/