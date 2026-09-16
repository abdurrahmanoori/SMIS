using SMIS.Application.Common.Response;
using SMIS.Domain.Entities;
using SMIS.Domain.Enums;

namespace SMIS.Application.Services;

/// <summary>
/// The single application entry point for changing physical inventory.
/// Business features must request stock changes through this workflow instead of
/// changing <see cref="StockBatch.RemainingQuantityBase"/> themselves.
/// </summary>
public interface IInventoryService
{
    Task<Result<StockBatch>> ReceiveBatchAsync(
        InventoryReceiptRequest request,
        CancellationToken cancellationToken = default
    );

    Task<Result<StockMovement>> PostMovementAsync(
        InventoryMovementRequest request,
        CancellationToken cancellationToken = default
    );

    Task<Result<IReadOnlyList<StockMovement>>> IssueFifoAsync(
        InventoryFifoIssueRequest request,
        CancellationToken cancellationToken = default
    );

    Task<Result<StockMovement>> ReverseMovementAsync(
        string movementId,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// Creates a new stock batch and its opening purchase-receipt movement atomically.
/// ReferenceId, when supplied, is the primary key of the related purchase/receipt entity,
/// not a human-readable invoice or document number.
/// </summary>
public sealed record InventoryReceiptRequest(
    string ProductId,
    string ProductUnitId,
    decimal QuantityEntered,
    long UnitCostBase,
    DateTime OccurredAtUtc,
    string? BatchNumber = null,
    DateTime? ExpirationDate = null,
    string? ReferenceType = null,
    string? ReferenceId = null
);

/// <summary>
/// Posts one stock change against one existing batch. QuantityBase is deliberately
/// absent: the service derives it from ProductUnit.BaseUnitQuantity on the server.
/// </summary>
public sealed record InventoryMovementRequest(
    string StockBatchId,
    string ProductUnitId,
    decimal QuantityEntered,
    StockMovementDirection Direction,
    StockMovementReason Reason,
    DateTime OccurredAtUtc,
    string? ReferenceType = null,
    string? ReferenceId = null
);

/// <summary>
/// Represents one logical OUT operation that may consume several batches using FIFO.
/// Every generated movement keeps the same business reference so the split can still
/// be traced back to the entity that caused the issue.
/// </summary>
public sealed record InventoryFifoIssueRequest(
    string ProductId,
    string ProductUnitId,
    decimal QuantityEntered,
    StockMovementReason Reason,
    DateTime OccurredAtUtc,
    string? ReferenceType = null,
    string? ReferenceId = null
);