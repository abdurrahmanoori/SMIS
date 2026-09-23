using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Enums;
using SMIS.Domain.Exceptions;
using SMIS.Domain.Services;

namespace SMIS.Domain.Entities;

public class StockMovement : BaseAuditableEntityWithoutName, IShopEntity
{
    // StockMovement is intentionally immutable after posting. Corrections are made
    // by posting an opposite movement so inventory history remains auditable.
    public string ShopId { get; private set; } = string.Empty;
    public string OperationId { get; private set; } = string.Empty;
    public string StockBatchId { get; private set; } = string.Empty;
    public string ProductUnitId { get; private set; } = string.Empty;
    public decimal QuantityEntered { get; private set; }
    public decimal QuantityBase { get; private set; }
    public StockMovementDirection Direction { get; private set; }

    /// <summary>
    /// Business reason for the stock change, independent from IN/OUT direction.
    /// </summary>
    public StockMovementReason Reason { get; private set; }

    public DateTime OccurredAtUtc { get; private set; }

    /// <summary>
    /// Type of the business entity that caused the movement, for example Sale,
    /// PurchaseOrder, Return, or StockMovement when posting a reversal.
    /// </summary>
    public string? ReferenceType { get; private set; }

    /// <summary>
    /// Actual primary key of the related entity. Human-readable invoice/document
    /// numbers belong on their own business entity and must not be stored here.
    /// </summary>
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
        string? referenceId = null,
        string? operationId = null
    )
    {
        // QuantityEntered preserves what the user transacted (e.g. 2 boxes), while
        // QuantityBase is the normalized inventory impact (e.g. 24 bottles).
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

        var hasReferenceType = !string.IsNullOrWhiteSpace(referenceType);
        var hasReferenceId = !string.IsNullOrWhiteSpace(referenceId);
        if (hasReferenceType != hasReferenceId)
            throw new DomainValidationException(
                "Reference type and reference ID must either both be supplied or both be empty");

        ValidateDirectionReason(direction, reason);

        return new StockMovement
        {
            ShopId = shopId.Trim(),
            OperationId = string.IsNullOrWhiteSpace(operationId)
                ? Guid.NewGuid().ToString()
                : operationId.Trim(),
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

    private static DateTime NormalizeUtc(
        DateTime value
    )
    {
        if (value == default)
            throw new DomainValidationException("Movement time cannot be empty");

        var utc = value.Kind == DateTimeKind.Utc ? value : value.ToUniversalTime();
        if (utc > DateTimeService.NowUtc.AddMinutes(5))
            throw new DomainValidationException("Movement time cannot be in the future");

        return utc;
    }

    private static string? NormalizeOptional(
        string? value
    ) =>
        string.IsNullOrWhiteSpace(value) ? null : value.Trim();

    private static void ValidateDirectionReason(
        StockMovementDirection direction,
        StockMovementReason reason
    )
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