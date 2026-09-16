using SMIS.Application.Common.Response;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Products;
using SMIS.Application.Repositories.ProductUnits;
using SMIS.Application.Repositories.StockBatches;
using SMIS.Application.Repositories.StockMovements;
using SMIS.Domain.Entities;
using SMIS.Domain.Enums;

namespace SMIS.Application.Services;

/// <summary>
/// Coordinates every persisted inventory change. The service owns validation,
/// ProductUnit conversion, batch balance mutation, ledger creation, and transaction
/// boundaries so feature handlers cannot accidentally update stock in different ways.
/// </summary>
public sealed class InventoryService : IInventoryService
{
    private readonly IProductRepository _products;
    private readonly IProductUnitRepository _productUnits;
    private readonly IStockBatchRepository _batches;
    private readonly IStockMovementRepository _movements;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICurrentUser _currentUser;

    public InventoryService(
        IProductRepository products,
        IProductUnitRepository productUnits,
        IStockBatchRepository batches,
        IStockMovementRepository movements,
        IUnitOfWork unitOfWork,
        ICurrentUser currentUser
    )
    {
        _products = products;
        _productUnits = productUnits;
        _batches = batches;
        _movements = movements;
        _unitOfWork = unitOfWork;
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
            referenceId);

        await _unitOfWork.StartTransactionAsync(cancellationToken);
        try
        {
            await _batches.AddAsync(batch);
            await _movements.AddAsync(movement);
            await _unitOfWork.CommitTransactionAsync(cancellationToken);
        }
        catch
        {
            await _unitOfWork.RollbackTransactionAsync(cancellationToken);
            throw;
        }

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
            request.ReferenceId);

        await _unitOfWork.StartTransactionAsync(cancellationToken);
        try
        {
            ApplyBalance(batch, movement.Direction, movement.QuantityBase);
            await _movements.AddAsync(movement);
            await _unitOfWork.CommitTransactionAsync(cancellationToken);
        }
        catch
        {
            await _unitOfWork.RollbackTransactionAsync(cancellationToken);
            throw;
        }

        return Result<StockMovement>.SuccessResult(movement);
    }

    public async Task<Result<IReadOnlyList<StockMovement>>> IssueFifoAsync(
        InventoryFifoIssueRequest request,
        CancellationToken cancellationToken = default
    )
    {
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
        var batches = await _batches.GetAvailableFifoAsync(product.ShopId, product.Id, cancellationToken);

        if (batches.Sum(batch => batch.RemainingQuantityBase) < totalBase)
            return Result<IReadOnlyList<StockMovement>>.FailureResult(
                "InsufficientStock",
                "Available FIFO stock is lower than the requested quantity.");

        var created = new List<StockMovement>();
        var remainingBase = totalBase;

        await _unitOfWork.StartTransactionAsync(cancellationToken);
        try
        {
            foreach (var batch in batches)
            {
                if (remainingBase <= 0) break;

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
                    request.ReferenceId);

                ApplyBalance(batch, movement.Direction, movement.QuantityBase);
                await _movements.AddAsync(movement);
                created.Add(movement);
                remainingBase -= allocatedBase;
            }

            await _unitOfWork.CommitTransactionAsync(cancellationToken);
        }
        catch
        {
            await _unitOfWork.RollbackTransactionAsync(cancellationToken);
            throw;
        }

        return Result<IReadOnlyList<StockMovement>>.SuccessResult(created);
    }

    public async Task<Result<StockMovement>> ReverseMovementAsync(
        string movementId,
        CancellationToken cancellationToken = default
    )
    {
        var original = await _movements.GetByIdAsync(movementId);
        if (original is null)
            return Result<StockMovement>.NotFoundResult(movementId);

        if (await _movements.HasReversalAsync(original.Id, cancellationToken))
            return Result<StockMovement>.FailureResult(
                "MovementAlreadyReversed",
                "This movement already has a reversal entry.");

        var contextResult = await GetExistingBatchContextAsync(
            original.StockBatchId,
            original.ProductUnitId,
            cancellationToken);
        if (contextResult.Failure is not null)
            return Failure<StockMovement>(contextResult.Failure);

        var batch = contextResult.Batch!;
        var reverseDirection = original.Direction == StockMovementDirection.In
            ? StockMovementDirection.Out
            : StockMovementDirection.In;

        // A reversal uses the original normalized quantity rather than re-running the
        // current conversion factor. That guarantees an exact undo even if packaging
        // definitions change after the original movement was posted.
        var reversal = StockMovement.Create(
            original.ShopId,
            original.StockBatchId,
            original.ProductUnitId,
            original.QuantityEntered,
            original.QuantityBase,
            reverseDirection,
            StockMovementReason.Adjustment,
            DateTime.UtcNow,
            nameof(StockMovement),
            original.Id);

        await _unitOfWork.StartTransactionAsync(cancellationToken);
        try
        {
            ApplyBalance(batch, reversal.Direction, reversal.QuantityBase);
            await _movements.AddAsync(reversal);
            await _unitOfWork.CommitTransactionAsync(cancellationToken);
        }
        catch
        {
            await _unitOfWork.RollbackTransactionAsync(cancellationToken);
            throw;
        }

        return Result<StockMovement>.SuccessResult(reversal);
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
        _currentUser.IsSuperAdmin() || string.Equals(shopId, _currentUser.GetShopId(), StringComparison.Ordinal);

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