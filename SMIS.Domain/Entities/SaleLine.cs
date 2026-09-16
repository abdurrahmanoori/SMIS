using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Exceptions;

namespace SMIS.Domain.Entities;

/// <summary>
/// Transaction-time snapshot of one product/unit sold. Stock allocation is represented
/// separately by StockMovement rows that reference this SaleLine.Id.
/// </summary>
public class SaleLine : BaseAuditableEntityWithoutName
{
    public string SaleId { get; private set; } = string.Empty;
    public string ProductId { get; private set; } = string.Empty;
    public string ProductUnitId { get; private set; } = string.Empty;
    public decimal QuantityEntered { get; private set; }
    public long UnitPrice { get; private set; }
    public long LineTotal { get; private set; }

    public Sale Sale { get; set; } = null!;
    public Product Product { get; set; } = null!;
    public ProductUnit ProductUnit { get; set; } = null!;

    internal SaleLine()
    {
    }

    public static SaleLine Create(
        string saleId,
        string productId,
        string productUnitId,
        decimal quantityEntered,
        long unitPrice
    )
    {
        if (string.IsNullOrWhiteSpace(saleId))
            throw new DomainValidationException("Sale ID cannot be empty");
        if (string.IsNullOrWhiteSpace(productId))
            throw new DomainValidationException("Product ID cannot be empty");
        if (string.IsNullOrWhiteSpace(productUnitId))
            throw new DomainValidationException("Product unit ID cannot be empty");
        if (quantityEntered <= 0)
            throw new DomainValidationException("Sale quantity must be greater than zero");
        if (unitPrice < 0)
            throw new DomainValidationException("Sale unit price cannot be negative");

        var exactTotal = quantityEntered * unitPrice;
        var roundedTotal = decimal.Round(exactTotal, 0, MidpointRounding.AwayFromZero);
        if (roundedTotal > long.MaxValue)
            throw new DomainValidationException("Sale line total is too large");

        return new SaleLine
        {
            SaleId = saleId.Trim(),
            ProductId = productId.Trim(),
            ProductUnitId = productUnitId.Trim(),
            QuantityEntered = quantityEntered,
            UnitPrice = unitPrice,
            LineTotal = (long)roundedTotal
        };
    }
}