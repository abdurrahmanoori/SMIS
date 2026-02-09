using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Exceptions;

namespace SMIS.Domain.Entities;

public class ProductPrice : BaseAuditableEntity
{
    public string ProductId { get; private set; } = string.Empty;
    public string ProductUnitId { get; private set; } = string.Empty;

    public long BuyPrice { get; private set; }
    public long SellPrice { get; private set; }

    public DateTime EffectiveDate { get; private set; }
    public DateTime? EndDate { get; private set; }
    public bool IsActive { get; private set; } = true;
    // Navigation Properties
    public virtual Product Product { get; set; } = null!;
    public ProductUnit ProductUnit { get; set; } = null!;
    internal ProductPrice() { } // EF Core

    public static ProductPrice Create(string productId, string productUnitId, long buyPrice, long sellPrice, DateTime effectiveDate)
    {
        var productPrice = new ProductPrice();
        productPrice.SetProductId(productId);
        productPrice.SetProductUnitId(productUnitId);
        productPrice.SetBuyPrice(buyPrice);
        productPrice.SetSellPrice(sellPrice);
        productPrice.SetEffectiveDate(effectiveDate);
        return productPrice;
    }

    public void SetProductId(string productId)
    {
        if (string.IsNullOrWhiteSpace(productId))
            throw new DomainValidationException("Product ID cannot be empty");

        ProductId = productId;
    }

    public void SetProductUnitId(string productUnitId)
    {
        if (string.IsNullOrWhiteSpace(productUnitId))
            throw new DomainValidationException("Product unit ID cannot be empty");

        ProductUnitId = productUnitId;
    }

    public void SetBuyPrice(long buyPrice)
    {
        if (buyPrice < 0)
            throw new DomainValidationException("Buy price cannot be negative");

        BuyPrice = buyPrice;
    }

    public void SetSellPrice(long sellPrice)
    {
        if (sellPrice < 0)
            throw new DomainValidationException("Sell price cannot be negative");

        SellPrice = sellPrice;
    }

    public void SetEffectiveDate(DateTime effectiveDate)
    {
        EffectiveDate = effectiveDate;
    }

    public void SetEndDate(DateTime? endDate)
    {
        if (endDate.HasValue && endDate.Value < EffectiveDate)
            throw new DomainValidationException("End date cannot be before effective date");

        EndDate = endDate;
    }

    public void Activate() => IsActive = true;
    public void Deactivate() => IsActive = false;
}
