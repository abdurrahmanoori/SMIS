using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Enums;
using SMIS.Domain.Exceptions;

namespace SMIS.Domain.Entities;

public class StockMovement : BaseAuditableEntityWithoutName, IShopEntity
{
    public string ShopId { get; private set; } = string.Empty;
    public string StockBatchId { get; private set; } = string.Empty;
    public string ProductUnitId { get; private set; } = string.Empty;
    public decimal QuantityEntered { get; private set; }
    public decimal QuantityBase { get; private set; }
    public StockMovementDirection Direction { get; private set; }
    public StockMovementReason Reason { get; private set; }
    public DateTime OccurredAtUtc { get; private set; }
    public string? ReferenceType { get; private set; }
    public string? ReferenceId { get; private set; }

    public virtual Shop Shop { get; set; } = null!;
    public virtual StockBatch StockBatch { get; set; } = null!;
    public virtual ProductUnit ProductUnit { get; set; } = null!;

    internal StockMovement()
    {
    }

    public static StockMovement Create(
        string shopId,
        string stockBatchId,
        string productUnitId,
        decimal quantityEntered,
        decimal quantityBase,
        StockMovementDirection direction,
        StockMovementReason reason,
        DateTime occurredAtUtc,
        string? referenceType = null,
        string? referenceId = null)
    {
        if (string.IsNullOrWhiteSpace(shopId))
            throw new DomainValidationException("Shop ID cannot be empty");
        if (string.IsNullOrWhiteSpace(stockBatchId))
            throw new DomainValidationException("Stock batch ID cannot be empty");
        if (string.IsNullOrWhiteSpace(productUnitId))
            throw new DomainValidationException("Product unit ID cannot be empty");
        if (quantityEntered <= 0)
            throw new DomainValidationException("Entered quantity must be greater than zero");
        if (quantityBase <= 0)
            throw new DomainValidationException("Base quantity must be greater than zero");

        ValidateDirectionReason(direction, reason);

        return new StockMovement
        {
            ShopId = shopId.Trim(),
            StockBatchId = stockBatchId.Trim(),
            ProductUnitId = productUnitId.Trim(),
            QuantityEntered = quantityEntered,
            QuantityBase = quantityBase,
            Direction = direction,
            Reason = reason,
            OccurredAtUtc = NormalizeUtc(occurredAtUtc),
            ReferenceType = NormalizeOptional(referenceType),
            ReferenceId = NormalizeOptional(referenceId)
        };
    }

    private static DateTime NormalizeUtc(DateTime value)
    {
        if (value == default)
            throw new DomainValidationException("Movement time cannot be empty");

        return value.Kind == DateTimeKind.Utc ? value : value.ToUniversalTime();
    }

    private static string? NormalizeOptional(string? value) =>
        string.IsNullOrWhiteSpace(value) ? null : value.Trim();

    private static void ValidateDirectionReason(
        StockMovementDirection direction,
        StockMovementReason reason)
    {
        var valid = reason switch
        {
            StockMovementReason.PurchaseReceipt => direction == StockMovementDirection.In,
            StockMovementReason.CustomerReturn => direction == StockMovementDirection.In,
            StockMovementReason.Sale => direction == StockMovementDirection.Out,
            StockMovementReason.SupplierReturn => direction == StockMovementDirection.Out,
            StockMovementReason.Damage => direction == StockMovementDirection.Out,
            StockMovementReason.Expiration => direction == StockMovementDirection.Out,
            StockMovementReason.Adjustment => true,
            StockMovementReason.Transfer => true,
            _ => false
        };

        if (!valid)
            throw new DomainValidationException(
                $"Movement direction '{direction}' is not valid for reason '{reason}'.");
    }
}
