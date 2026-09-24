using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Exceptions;

namespace SMIS.Domain.Entities;

/// <summary>
/// One effective selling-price period for a specific ProductUnit.
/// Price history is represented by multiple rows over time instead of rewriting old prices.
/// </summary>
public class ProductPrice : BaseSyncableAuditableEntity
{
    /// <summary>
    /// The exact transaction unit being priced. ProductId is intentionally not duplicated
    /// because ProductUnit already determines the owning product.
    /// </summary>
    public string ProductUnitId { get; private set; } = string.Empty;

    /// <summary>
    /// Selling amount in the application's minor monetary unit.
    /// Actual purchase cost belongs to StockBatch, not ProductPrice.
    /// </summary>
    public long SellPrice { get; private set; }

    /// <summary>
    /// Start of this price period. EndDate stays null while the price remains open-ended.
    /// </summary>
    public DateTime EffectiveDate { get; private set; }

    public DateTime? EndDate { get; private set; }

    // Navigation Properties
    public ProductUnit ProductUnit { get; set; } = null!;

    internal ProductPrice()
    {
    } // EF Core

    public static ProductPrice Create(
        string productUnitId,
        long sellPrice,
        DateTime effectiveDate
    )
    {
        var productPrice = new ProductPrice();
        productPrice.SetProductUnitId(productUnitId);
        productPrice.SetSellPrice(sellPrice);
        productPrice.SetEffectiveDate(effectiveDate);
        return productPrice;
    }

    public void SetProductUnitId(
        string productUnitId
    )
    {
        if (string.IsNullOrWhiteSpace(productUnitId))
            throw new DomainValidationException("Product unit ID cannot be empty");

        ProductUnitId = productUnitId;
    }

    public void SetSellPrice(
        long sellPrice
    )
    {
        if (sellPrice < 0)
            throw new DomainValidationException("Sell price cannot be negative");

        SellPrice = sellPrice;
    }

    public void SetEffectiveDate(
        DateTime effectiveDate
    )
    {
        EffectiveDate = effectiveDate;
    }

    public void SetEndDate(
        DateTime? endDate
    )
    {
        if (endDate.HasValue && endDate.Value < EffectiveDate)
            throw new DomainValidationException("End date cannot be before effective date");

        EndDate = endDate;
    }
}