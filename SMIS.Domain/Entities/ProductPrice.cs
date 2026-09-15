using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Exceptions;

namespace SMIS.Domain.Entities;

public class ProductPrice : BaseSyncableAuditableEntity
{
    public string ProductUnitId { get; private set; } = string.Empty;

    public long SellPrice { get; private set; }

    public DateTime EffectiveDate { get; private set; }
    public DateTime? EndDate { get; private set; }

    public DateTime ConflictModifiedUtc => GetConflictModifiedUtc();

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