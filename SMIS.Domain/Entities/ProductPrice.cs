using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Exceptions;

namespace SMIS.Domain.Entities;

public class ProductPrice : BaseAuditableEntity
{
    public string ProductId { get; private set; } = string.Empty;
    public int Price { get; private set; }
    public DateTime EffectiveDate { get; private set; }
    public DateTime? EndDate { get; private set; }
    public bool IsActive { get; private set; } = true;

    // Navigation Properties
    public virtual Product Product { get; set; } = null!;

    internal ProductPrice() { } // EF Core

    public static ProductPrice Create(string productId, int price, DateTime effectiveDate)
    {
        var productPrice = new ProductPrice();
        productPrice.SetProductId(productId);
        productPrice.SetPrice(price);
        productPrice.SetEffectiveDate(effectiveDate);
        return productPrice;
    }

    public void SetProductId(string productId)
    {
        if (string.IsNullOrWhiteSpace(productId))
            throw new DomainValidationException("Product ID cannot be empty");

        ProductId = productId;
    }

    public void SetPrice(int price)
    {
        if (price < 0)
            throw new DomainValidationException("Price cannot be negative");

        Price = price;
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
