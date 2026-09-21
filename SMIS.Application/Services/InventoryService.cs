using SMIS.Application.Common.Response;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Products;
using SMIS.Application.Repositories.ProductUnits;
using SMIS.Application.Repositories.StockBatches;
using SMIS.Application.Repositories.StockMovements;
using SMIS.Domain.Entities;
using SMIS.Domain.Enums;

namespace SMIS.Application.Services;

/// <summary>
/// Coordinates every inventory change. The service owns validation, ProductUnit
/// conversion, batch balance mutation, and ledger creation. The MediatR command that
/// owns the business use case is responsible for the final SaveChanges call.
/// </summary>
public sealed class InventoryService : IInventoryService
{
    private readonly IProductRepository _products;
    private readonly IProductUnitRepository _productUnits;
    private readonly IStockBatchRepository _batches;
    private readonly IStockMovementRepository _movements;
    private readonly ICurrentUser _currentUser;

    public InventoryService(
        IProductRepository products,
        IProductUnitRepository productUnits,
        IStockBatchRepository batches,
        IStockMovementRepository movements,
        ICurrentUser currentUser
    )
    {
        _products = products;
        _productUnits = productUnits;
        _batches = batches;
        _movements = movements;
        _currentUser = currentUser;
    }

    public async Task<Result<StockBatch>> ReceiveBatchAsync(
        InventoryReceiptRequest request,
        CancellationToken cancellationToken = default
    )
    {
        var referenceFailure = ValidateReference(request.ReferenceType, request.ReferenceId);
        if (referenceFailure is not null)
            return Failure<StockBatch>(referenceFailure);

        var productResult = await GetAccessibleProductAndUnitAsync(
            request.ProductId,
            request.ProductUnitId,
            cancellationToken);
        if (productResult.Failure is not null)
            return Failure<StockBatch>(productResult.Failure);

        var product = productResult.Product!;
        var productUnit = productResult.ProductUnit!;

        // StockBatch.Create calculates ReceivedQuantityBase and the opening balance from
        // the validated ProductUnit. No feature outside this service creates live receipts.
        var batch = StockBatch.Create(
            product.ShopId,
            product.Id,
            productUnit.Id,
            request.QuantityEntered,
            productUnit.BaseUnitQuantity,
            request.UnitCostBase,
            request.OccurredAtUtc,
            request.BatchNumber,
            request.ExpirationDate);

        // If a purchase document is not available yet, the new batch itself is the
        // related entity. ReferenceId still remains an actual entity primary key.
        var referenceType = string.IsNullOrWhiteSpace(request.ReferenceType)
            ? nameof(StockBatch)
            : request.ReferenceType;
        var referenceId = string.IsNullOrWhiteSpace(request.ReferenceId)
            ? batch.Id
            : request.ReferenceId;

        var operationId = string.IsNullOrWhiteSpace(request.OperationId)
            ? Guid.NewGuid().ToString()
            : request.OperationId;
        var movement = StockMovement.Create(
            product.ShopId,
            batch.Id,
            productUnit.Id,
            request.QuantityEntered,
            batch.ReceivedQuantityBase,
            StockMovementDirection.In,
            StockMovementReason.PurchaseReceipt,
            request.OccurredAtUtc,
            referenceType,
            referenceId,
            operationId);

        await _batches.AddAsync(batch);
        await _movements.AddAsync(movement);

        return Result<StockBatch>.SuccessResult(batch);
    }

    public async Task<Result<StockMovement>> PostMovementAsync(
        InventoryMovementRequest request,
        CancellationToken cancellationToken = default
    )
    {
        if (request.Reason == StockMovementReason.PurchaseReceipt)
            return Result<StockMovement>.FailureResult(
                "PurchaseReceiptUsesReceiptWorkflow",
                "Purchase receipts must be posted through the inventory receipt workflow.");

        if (request.Reason == StockMovementReason.Sale)
            return Result<StockMovement>.FailureResult(
                "SaleUsesFifoWorkflow",
                "Sale inventory must be issued through the FIFO/FEFO sale workflow.");

        if (request.Reason == StockMovementReason.Transfer)
            return Result<StockMovement>.FailureResult(
                "TransferUsesTransferWorkflow",
                "Transfers must be posted through the paired transfer workflow.");

        var referenceFailure = ValidateReference(request.ReferenceType, request.ReferenceId);
        if (referenceFailure is not null)
            return Failure<StockMovement>(referenceFailure);

        var contextResult = await GetExistingBatchContextAsync(
            request.StockBatchId,
            request.ProductUnitId,
            cancellationToken);
        if (contextResult.Failure is not null)
            return Failure<StockMovement>(contextResult.Failure);

        var batch = contextResult.Batch!;
        var productUnit = contextResult.ProductUnit!;
        var quantityBase = ConvertToBaseQuantity(request.QuantityEntered, productUnit);

        // Expiration is not merely another OUT reason. The batch itself must prove
        // that it is actually expired at the time of the movement; otherwise callers
        // could remove healthy stock simply by choosing the Expiration enum value.
        if (request.Reason == StockMovementReason.Expiration)
        {
            if (!batch.ExpirationDate.HasValue)
                return Result<StockMovement>.FailureResult(
                    "BatchHasNoExpirationDate",
                    "A batch without an expiration date cannot be posted as expired stock.");

            if (batch.ExpirationDate.Value > request.OccurredAtUtc)
                return Result<StockMovement>.FailureResult(
                    "BatchNotExpired",
                    "The selected batch has not reached its expiration date yet.");
        }

        // Constructing the immutable movement first validates direction/reason before
        // the cached batch balance is touched.
        var movement = StockMovement.Create(
            batch.ShopId,
            batch.Id,
            productUnit.Id,
            request.QuantityEntered,
            quantityBase,
            request.Direction,
            request.Reason,
            request.OccurredAtUtc,
            request.ReferenceType,
            request.ReferenceId,
            request.OperationId);

        ApplyBalance(batch, movement.Direction, movement.QuantityBase);
        await _movements.AddAsync(movement);

        return Result<StockMovement>.SuccessResult(movement);
    }

    public async Task<Result<IReadOnlyList<StockMovement>>> IssueFifoAsync(
        InventoryFifoIssueRequest request,
        CancellationToken cancellationToken = default
    )
    {
        if (request.Reason != StockMovementReason.Sale)
            return Result<IReadOnlyList<StockMovement>>.FailureResult(
                "FifoIssueReservedForSales",
                "FIFO/FEFO issuing is reserved for the sale workflow. Other stock changes must use their explicit inventory workflow.");

        var referenceFailure = ValidateReference(request.ReferenceType, request.ReferenceId);
        if (referenceFailure is not null)
            return Failure<IReadOnlyList<StockMovement>>(referenceFailure);

        var productResult = await GetAccessibleProductAndUnitAsync(
            request.ProductId,
            request.ProductUnitId,
            cancellationToken);
        if (productResult.Failure is not null)
            return Failure<IReadOnlyList<StockMovement>>(productResult.Failure);

        var product = productResult.Product!;
        var productUnit = productResult.ProductUnit!;
        var totalBase = ConvertToBaseQuantity(request.QuantityEntered, productUnit);
        var batches = await _batches.GetAvailableFifoAsync(
            product.ShopId,
            product.Id,
            request.OccurredAtUtc,
            cancellationToken);

        if (batches.Sum(batch => batch.RemainingQuantityBase) < totalBase)
            return Result<IReadOnlyList<StockMovement>>.FailureResult(
                "InsufficientStock",
                "Available FIFO stock is lower than the requested quantity.");

        var created = new List<StockMovement>();
        var remainingBase = totalBase;
        var operationId = Guid.NewGuid().ToString();

        foreach (var batch in batches)
        {
            if (remainingBase <= 0) break;
            if (batch.RemainingQuantityBase <= 0) continue;

            var allocatedBase = Math.Min(batch.RemainingQuantityBase, remainingBase);
            var allocatedEntered = allocatedBase / productUnit.BaseUnitQuantity;

            var movement = StockMovement.Create(
                product.ShopId,
                batch.Id,
                productUnit.Id,
                allocatedEntered,
                allocatedBase,
                StockMovementDirection.Out,
                request.Reason,
                request.OccurredAtUtc,
                request.ReferenceType,
                request.ReferenceId,
                operationId);

            ApplyBalance(batch, movement.Direction, movement.QuantityBase);
            await _movements.AddAsync(movement);
            created.Add(movement);
            remainingBase -= allocatedBase;
        }

        return Result<IReadOnlyList<StockMovement>>.SuccessResult(created);
    }

    public async Task<Result<IReadOnlyList<StockMovement>>> ReverseMovementAsync(
        string movementId,
        CancellationToken cancellationToken = default
    )
    {
        var original = await _movements.GetByIdAsync(movementId);
        if (original is null)
            return Result<IReadOnlyList<StockMovement>>.NotFoundResult(movementId);

        if (original.Reason is StockMovementReason.Sale
            or StockMovementReason.PurchaseReceipt
            or StockMovementReason.CustomerReturn
            or StockMovementReason.SupplierReturn)
            return Result<IReadOnlyList<StockMovement>>.FailureResult(
                "BusinessMovementRequiresWorkflowReversal",
                "This movement belongs to a higher-level sale or purchasing workflow and cannot be reversed independently.");

        if (original.ReferenceType is nameof(StockMovement) or "StockMovementReversal")
            return Result<IReadOnlyList<StockMovement>>.FailureResult(
                "ReversalCannotBeReversedDirectly",
                "A compensating reversal cannot itself be reversed through the generic movement endpoint.");

        var originals = string.IsNullOrWhiteSpace(original.OperationId)
            ? new List<StockMovement> { original }
            : await _movements.GetByOperationIdAsync(original.OperationId, cancellationToken);

        foreach (var movement in originals)
        {
            if (await _movements.HasReversalAsync(movement.Id, cancellationToken))
                return Result<IReadOnlyList<StockMovement>>.FailureResult(
                    "MovementAlreadyReversed",
                    "This inventory operation already has a reversal entry.");
        }

        var contexts = new List<(StockMovement Movement, StockBatch Batch)>();
        foreach (var movement in originals)
        {
            var contextResult = await GetExistingBatchContextAsync(
                movement.StockBatchId,
                movement.ProductUnitId,
                cancellationToken);
            if (contextResult.Failure is not null)
                return Failure<IReadOnlyList<StockMovement>>(contextResult.Failure);

            contexts.Add((movement, contextResult.Batch!));
        }

        var reversalOperationId = Guid.NewGuid().ToString();
        var reversals = new List<StockMovement>();
        foreach (var (movement, batch) in contexts)
        {
            var reverseDirection = movement.Direction == StockMovementDirection.In
                ? StockMovementDirection.Out
                : StockMovementDirection.In;

            // Reverse the exact historical normalized quantity. All movements belonging
            // to the same logical operation (FIFO split, transfer, etc.) are reversed
            // together so a business operation cannot be half-undone.
            var reversal = StockMovement.Create(
                movement.ShopId,
                movement.StockBatchId,
                movement.ProductUnitId,
                movement.QuantityEntered,
                movement.QuantityBase,
                reverseDirection,
                StockMovementReason.Adjustment,
                DateTime.UtcNow,
                "StockMovementReversal",
                movement.Id,
                reversalOperationId);

            ApplyBalance(batch, reversal.Direction, reversal.QuantityBase);
            await _movements.AddAsync(reversal);
            reversals.Add(reversal);
        }

        return Result<IReadOnlyList<StockMovement>>.SuccessResult(reversals);
    }

    public async Task<Result<IReadOnlyList<StockMovement>>> TransferAsync(
        InventoryTransferRequest request,
        CancellationToken cancellationToken = default
    )
    {
        if (string.Equals(request.SourceStockBatchId, request.DestinationStockBatchId,
                StringComparison.Ordinal))
            return Result<IReadOnlyList<StockMovement>>.FailureResult(
                "SameTransferBatch",
                "Source and destination stock batches must be different.");

        var referenceFailure = ValidateReference(request.ReferenceType, request.ReferenceId);
        if (referenceFailure is not null)
            return Failure<IReadOnlyList<StockMovement>>(referenceFailure);

        var sourceResult = await GetExistingBatchContextAsync(
            request.SourceStockBatchId,
            request.ProductUnitId,
            cancellationToken);
        if (sourceResult.Failure is not null)
            return Failure<IReadOnlyList<StockMovement>>(sourceResult.Failure);

        var destinationResult = await GetExistingBatchContextAsync(
            request.DestinationStockBatchId,
            request.ProductUnitId,
            cancellationToken);
        if (destinationResult.Failure is not null)
            return Failure<IReadOnlyList<StockMovement>>(destinationResult.Failure);

        var source = sourceResult.Batch!;
        var destination = destinationResult.Batch!;
        var productUnit = sourceResult.ProductUnit!;

        // A batch-to-batch transfer is intentionally conservative. Different products,
        // shops, or costs would turn a physical move into an implicit product/cost
        // transformation and would make inventory valuation lie rather enthusiastically.
        if (!string.Equals(source.ProductId, destination.ProductId, StringComparison.Ordinal))
            return Result<IReadOnlyList<StockMovement>>.FailureResult(
                "TransferProductMismatch",
                "Source and destination batches must belong to the same product.");

        if (!string.Equals(source.ShopId, destination.ShopId, StringComparison.Ordinal))
            return Result<IReadOnlyList<StockMovement>>.FailureResult(
                "TransferShopMismatch",
                "Source and destination batches must belong to the same shop.");

        if (source.UnitCostBase != destination.UnitCostBase)
            return Result<IReadOnlyList<StockMovement>>.FailureResult(
                "TransferCostMismatch",
                "Source and destination batches must have the same base-unit cost.");

        if (!string.Equals(source.BatchNumber, destination.BatchNumber, StringComparison.Ordinal) ||
            source.ExpirationDate != destination.ExpirationDate)
            return Result<IReadOnlyList<StockMovement>>.FailureResult(
                "TransferLotMismatch",
                "Source and destination batches must represent the same lot and expiration date.");

        if (source.ExpirationDate.HasValue && source.ExpirationDate.Value <= request.OccurredAtUtc)
            return Result<IReadOnlyList<StockMovement>>.FailureResult(
                "ExpiredStockTransfer",
                "Expired stock cannot be transferred as available inventory.");

        // Transfers still accept the quantity in a user-facing ProductUnit, but both
        // sides of the transfer are posted with the same normalized base quantity.
        // This keeps the OUT and IN ledger entries exactly symmetrical.
        var quantityBase = ConvertToBaseQuantity(request.QuantityEntered, productUnit);
        if (source.RemainingQuantityBase < quantityBase)
            return Result<IReadOnlyList<StockMovement>>.FailureResult(
                "InsufficientStock",
                "The source batch does not contain enough stock for this transfer.");

        // If there is no higher-level transfer document yet, reference the opposite
        // batch. ReferenceId therefore remains an actual entity ID rather than an
        // invented correlation/document number.
        var sourceReferenceType = request.ReferenceType ?? nameof(StockBatch);
        var sourceReferenceId = request.ReferenceId ?? destination.Id;
        var destinationReferenceType = request.ReferenceType ?? nameof(StockBatch);
        var destinationReferenceId = request.ReferenceId ?? source.Id;

        var operationId = Guid.NewGuid().ToString();
        var sourceMovement = StockMovement.Create(
            source.ShopId,
            source.Id,
            productUnit.Id,
            request.QuantityEntered,
            quantityBase,
            StockMovementDirection.Out,
            StockMovementReason.Transfer,
            request.OccurredAtUtc,
            sourceReferenceType,
            sourceReferenceId,
            operationId);

        var destinationMovement = StockMovement.Create(
            destination.ShopId,
            destination.Id,
            productUnit.Id,
            request.QuantityEntered,
            quantityBase,
            StockMovementDirection.In,
            StockMovementReason.Transfer,
            request.OccurredAtUtc,
            destinationReferenceType,
            destinationReferenceId,
            operationId);

        // Both batch mutations are staged before the caller performs its single
        // SaveChanges. EF Core makes that SaveChanges atomic.
        ApplyBalance(source, StockMovementDirection.Out, quantityBase);
        ApplyBalance(destination, StockMovementDirection.In, quantityBase);
        await _movements.AddAsync(sourceMovement);
        await _movements.AddAsync(destinationMovement);

        return Result<IReadOnlyList<StockMovement>>.SuccessResult(
            new[] { sourceMovement, destinationMovement });
    }

    private async Task<InventoryContextResult> GetExistingBatchContextAsync(
        string batchId,
        string productUnitId,
        CancellationToken cancellationToken
    )
    {
        var batch = await _batches.GetByIdAsync(batchId);
        if (batch is null)
            return InventoryContextResult.Fail("StockBatchNotFound", "The selected stock batch does not exist.");

        var product = await _products.GetByIdAsync(batch.ProductId);
        if (product is null)
            return InventoryContextResult.Fail("ProductNotFound", "The batch product does not exist.");

        if (batch.ShopId != product.ShopId)
            return InventoryContextResult.Fail(
                "StockBatchProductShopMismatch",
                "The stock batch and product do not belong to the same shop.");

        if (!CanAccessShop(product.ShopId))
            return InventoryContextResult.Fail("Forbidden", "The selected stock belongs to another shop.");

        var productUnit = await _productUnits.GetByIdAsync(productUnitId);
        if (productUnit is null)
            return InventoryContextResult.Fail("ProductUnitNotFound", "The selected product unit does not exist.");

        if (productUnit.ProductId != product.Id)
            return InventoryContextResult.Fail(
                "ProductUnitMismatch",
                "The selected product unit does not belong to the batch product.");

        return InventoryContextResult.Success(batch, product, productUnit);
    }

    private async Task<ProductUnitContextResult> GetAccessibleProductAndUnitAsync(
        string productId,
        string productUnitId,
        CancellationToken cancellationToken
    )
    {
        var product = await _products.GetByIdAsync(productId);
        if (product is null)
            return ProductUnitContextResult.Fail("ProductNotFound", "The selected product does not exist.");

        if (!CanAccessShop(product.ShopId))
            return ProductUnitContextResult.Fail("Forbidden", "The selected product belongs to another shop.");

        var productUnit = await _productUnits.GetByIdAsync(productUnitId);
        if (productUnit is null)
            return ProductUnitContextResult.Fail("ProductUnitNotFound", "The selected product unit does not exist.");

        if (productUnit.ProductId != product.Id)
            return ProductUnitContextResult.Fail(
                "ProductUnitMismatch",
                "The selected product unit does not belong to the selected product.");

        return ProductUnitContextResult.Success(product, productUnit);
    }

    private bool CanAccessShop(
        string shopId
    ) =>
        string.Equals(shopId, _currentUser.GetShopId(), StringComparison.Ordinal);

    private static decimal ConvertToBaseQuantity(
        decimal quantityEntered,
        ProductUnit productUnit
    )
    {
        if (quantityEntered <= 0)
            throw new ArgumentOutOfRangeException(nameof(quantityEntered),
                "Entered quantity must be greater than zero.");

        return quantityEntered * productUnit.BaseUnitQuantity;
    }

    private static void ApplyBalance(
        StockBatch batch,
        StockMovementDirection direction,
        decimal quantityBase
    )
    {
        // These domain methods are intentionally called only from the shared inventory
        // workflow. Feature handlers should never manipulate the cached balance directly.
        if (direction == StockMovementDirection.Out)
            batch.ApplyOutMovement(quantityBase);
        else
            batch.ApplyInMovement(quantityBase);
    }

    private static InventoryFailure? ValidateReference(
        string? referenceType,
        string? referenceId
    )
    {
        var hasType = !string.IsNullOrWhiteSpace(referenceType);
        var hasId = !string.IsNullOrWhiteSpace(referenceId);

        if (hasType == hasId) return null;

        return new InventoryFailure(
            "IncompleteInventoryReference",
            "ReferenceType and ReferenceId must either both be supplied or both be empty. ReferenceId must be the related entity ID, not a document number.");
    }

    private static Result<T> Failure<T>(
        InventoryFailure failure
    ) =>
        Result<T>.FailureResult(failure.Code, failure.Description);

    private sealed record InventoryFailure(string Code, string Description);

    private sealed record InventoryContextResult(
        StockBatch? Batch,
        Product? Product,
        ProductUnit? ProductUnit,
        InventoryFailure? Failure
    )
    {
        public static InventoryContextResult Success(
            StockBatch batch,
            Product product,
            ProductUnit productUnit
        ) =>
            new(batch, product, productUnit, null);

        public static InventoryContextResult Fail(
            string code,
            string description
        ) =>
            new(null, null, null, new InventoryFailure(code, description));
    }

    private sealed record ProductUnitContextResult(
        Product? Product,
        ProductUnit? ProductUnit,
        InventoryFailure? Failure
    )
    {
        public static ProductUnitContextResult Success(
            Product product,
            ProductUnit productUnit
        ) =>
            new(product, productUnit, null);

        public static ProductUnitContextResult Fail(
            string code,
            string description
        ) =>
            new(null, null, new InventoryFailure(code, description));
    }
}