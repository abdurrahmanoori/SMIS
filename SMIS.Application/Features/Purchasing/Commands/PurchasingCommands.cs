using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Purchasing;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Services;
using SMIS.Domain.Entities;
using SMIS.Domain.Enums;

namespace SMIS.Application.Features.Purchasing.Commands;

public sealed record SupplierCreateCommand(SupplierCreateDto Dto) : IRequest<Result<SupplierDto>>;

public sealed record PurchaseOrderCreateCommand(PurchaseOrderCreateDto Dto) : IRequest<Result<PurchaseOrderDto>>;

public sealed record PurchaseOrderReceiveCommand(string Id, PurchaseOrderReceiveDto Dto)
    : IRequest<Result<PurchaseOrderDto>>;

public sealed record PurchaseOrderSupplierReturnCommand(string Id, PurchaseOrderSupplierReturnDto Dto)
    : IRequest<Result<PurchaseOrderDto>>;

public sealed record PurchaseOrderCancelCommand(string Id) : IRequest<Result<PurchaseOrderDto>>;

internal sealed class PurchasingCommandHandler :
    IRequestHandler<SupplierCreateCommand, Result<SupplierDto>>,
    IRequestHandler<PurchaseOrderCreateCommand, Result<PurchaseOrderDto>>,
    IRequestHandler<PurchaseOrderReceiveCommand, Result<PurchaseOrderDto>>,
    IRequestHandler<PurchaseOrderSupplierReturnCommand, Result<PurchaseOrderDto>>,
    IRequestHandler<PurchaseOrderCancelCommand, Result<PurchaseOrderDto>>
{
    private readonly IApplicationDbContext _db;
    private readonly IInventoryService _inventory;
    private readonly IIdempotencyService _idempotency;
    private readonly ICurrentUser _currentUser;
    private readonly IUnitOfWork _unitOfWork;

    public PurchasingCommandHandler(
        IApplicationDbContext db,
        IInventoryService inventory,
        IIdempotencyService idempotency,
        ICurrentUser currentUser,
        IUnitOfWork unitOfWork
    )
    {
        _db = db;
        _inventory = inventory;
        _idempotency = idempotency;
        _currentUser = currentUser;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<SupplierDto>> Handle(
        SupplierCreateCommand request,
        CancellationToken cancellationToken
    )
    {
        var shopId = _currentUser.GetShopId();
        if (string.IsNullOrWhiteSpace(shopId))
            return Result<SupplierDto>.FailureResult("ShopContextRequired", "An active shop is required.");

        var duplicate = await _db.Suppliers.AnyAsync(
            supplier => supplier.ShopId == shopId && supplier.Name == request.Dto.Name,
            cancellationToken);
        if (duplicate)
            return Result<SupplierDto>.FailureResult("DuplicateSupplier",
                "A supplier with this name already exists in the shop.");

        var supplier = Supplier.Create(
            shopId,
            request.Dto.Name,
            request.Dto.PhoneNumber,
            request.Dto.Notes);

        await _db.Suppliers.AddAsync(supplier, cancellationToken);
        await _unitOfWork.SaveChanges(cancellationToken);
        return Result<SupplierDto>.SuccessResult(PurchasingDtoMapper.ToDto(supplier));
    }

    public async Task<Result<PurchaseOrderDto>> Handle(
        PurchaseOrderCreateCommand request,
        CancellationToken cancellationToken
    )
    {
        var dto = request.Dto;
        var shopId = _currentUser.GetShopId();
        if (string.IsNullOrWhiteSpace(shopId))
            return Result<PurchaseOrderDto>.FailureResult("ShopContextRequired", "An active shop is required.");

        var reservation = await _idempotency.ReserveAsync(
            "purchase-order:create",
            dto.IdempotencyKey,
            cancellationToken);
        if (!reservation.Success)
            return Failure<PurchaseOrderDto, bool>(reservation);

        var supplier = await _db.Suppliers.FirstOrDefaultAsync(
            item => item.Id == dto.SupplierId && item.ShopId == shopId,
            cancellationToken);
        if (supplier is null || !supplier.IsActive)
            return Result<PurchaseOrderDto>.FailureResult(
                "SupplierNotFoundOrInactive",
                "The selected supplier does not exist in this shop or is inactive.");

        if (dto.Lines.Count == 0)
            return Result<PurchaseOrderDto>.FailureResult("PurchaseOrderLinesRequired",
                "A purchase order requires at least one line.");

        if (dto.Lines.Select(line => line.ProductUnitId).Distinct(StringComparer.Ordinal).Count() != dto.Lines.Count)
            return Result<PurchaseOrderDto>.FailureResult(
                "DuplicatePurchaseOrderLine",
                "A product unit can appear only once in a purchase order.");

        var order = PurchaseOrder.Create(
            shopId,
            dto.SupplierId,
            dto.OrderedAtUtc ?? DateTime.UtcNow,
            dto.ReferenceNumber,
            dto.Notes);

        foreach (var lineDto in dto.Lines)
        {
            var productUnit = await _db.ProductUnits
                .Include(unit => unit.Product)
                .FirstOrDefaultAsync(unit =>
                        unit.Id == lineDto.ProductUnitId &&
                        unit.ProductId == lineDto.ProductId,
                    cancellationToken);

            if (productUnit?.Product is null || productUnit.Product.ShopId != shopId)
                return Result<PurchaseOrderDto>.FailureResult(
                    "PurchaseOrderProductMismatch",
                    "Every purchase-order product unit must belong to a product in the selected shop.");

            var orderLine = PurchaseOrderLine.Create(
                order.Id,
                lineDto.ProductId,
                lineDto.ProductUnitId,
                lineDto.QuantityEntered,
                lineDto.UnitCostBase);
            orderLine.Product = productUnit.Product;
            orderLine.ProductUnit = productUnit;
            order.Lines.Add(orderLine);
        }

        order.Supplier = supplier;
        await _db.PurchaseOrders.AddAsync(order, cancellationToken);
        await _unitOfWork.SaveChanges(cancellationToken);

        return Result<PurchaseOrderDto>.SuccessResult(PurchasingDtoMapper.ToDto(order));
    }

    public async Task<Result<PurchaseOrderDto>> Handle(
        PurchaseOrderReceiveCommand request,
        CancellationToken cancellationToken
    )
    {
        var order = await LoadOrderAsync(request.Id, cancellationToken);
        if (order is null)
            return Result<PurchaseOrderDto>.NotFoundResult(request.Id);
        if (order.Status == PurchaseOrderStatus.Cancelled)
            return Result<PurchaseOrderDto>.FailureResult("PurchaseOrderCancelled",
                "A cancelled purchase order cannot receive stock.");

        var reservation = await _idempotency.ReserveAsync(
            $"purchase-order:receive:{order.Id}",
            request.Dto.IdempotencyKey,
            cancellationToken);
        if (!reservation.Success)
            return Failure<PurchaseOrderDto, bool>(reservation);

        if (request.Dto.Lines.Count == 0)
            return Result<PurchaseOrderDto>.FailureResult("ReceiptLinesRequired",
                "At least one receipt line is required.");
        if (request.Dto.Lines.Select(line => line.PurchaseOrderLineId).Distinct(StringComparer.Ordinal).Count() !=
            request.Dto.Lines.Count)
            return Result<PurchaseOrderDto>.FailureResult("DuplicateReceiptLine",
                "A purchase-order line can appear only once per receipt.");

        var occurredAtUtc = request.Dto.OccurredAtUtc ?? DateTime.UtcNow;
        var operationId = Guid.NewGuid().ToString();
        foreach (var receipt in request.Dto.Lines)
        {
            var line = order.Lines.FirstOrDefault(item => item.Id == receipt.PurchaseOrderLineId);
            if (line is null)
                return Result<PurchaseOrderDto>.FailureResult(
                    "PurchaseOrderLineNotFound",
                    "A receipt line does not belong to this purchase order.");

            if (receipt.QuantityEntered <= 0 || receipt.QuantityEntered > line.RemainingToReceiveQuantityEntered)
                return Result<PurchaseOrderDto>.FailureResult(
                    "InvalidReceiptQuantity",
                    "Received quantity must be positive and cannot exceed the remaining ordered quantity.");

            var inventoryResult = await _inventory.ReceiveBatchAsync(
                new InventoryReceiptRequest(
                    line.ProductId,
                    line.ProductUnitId,
                    receipt.QuantityEntered,
                    line.UnitCostBase,
                    occurredAtUtc,
                    receipt.BatchNumber,
                    receipt.ExpirationDate,
                    nameof(PurchaseOrderLine),
                    line.Id,
                    operationId),
                cancellationToken);

            if (!inventoryResult.Success)
                return Failure<PurchaseOrderDto, StockBatch>(inventoryResult);

            line.RegisterReceipt(receipt.QuantityEntered);
        }

        order.RefreshReceiptStatus();
        await _unitOfWork.SaveChanges(cancellationToken);
        return Result<PurchaseOrderDto>.SuccessResult(PurchasingDtoMapper.ToDto(order));
    }

    public async Task<Result<PurchaseOrderDto>> Handle(
        PurchaseOrderSupplierReturnCommand request,
        CancellationToken cancellationToken
    )
    {
        var order = await LoadOrderAsync(request.Id, cancellationToken);
        if (order is null)
            return Result<PurchaseOrderDto>.NotFoundResult(request.Id);

        var dto = request.Dto;
        var reservation = await _idempotency.ReserveAsync(
            $"purchase-order:supplier-return:{order.Id}",
            dto.IdempotencyKey,
            cancellationToken);
        if (!reservation.Success)
            return Failure<PurchaseOrderDto, bool>(reservation);

        var line = order.Lines.FirstOrDefault(item => item.Id == dto.PurchaseOrderLineId);
        if (line is null)
            return Result<PurchaseOrderDto>.FailureResult(
                "PurchaseOrderLineNotFound",
                "The supplier-return line does not belong to this purchase order.");

        var batchBelongsToReceipt = await _db.StockMovements.AnyAsync(movement =>
                movement.ShopId == order.ShopId &&
                movement.StockBatchId == dto.StockBatchId &&
                movement.Reason == StockMovementReason.PurchaseReceipt &&
                movement.ReferenceType == nameof(PurchaseOrderLine) &&
                movement.ReferenceId == line.Id,
            cancellationToken);

        if (!batchBelongsToReceipt)
            return Result<PurchaseOrderDto>.FailureResult(
                "SupplierReturnBatchMismatch",
                "The selected batch was not received for this purchase-order line.");

        if (dto.QuantityEntered <= 0 || dto.QuantityEntered > line.NetReceivedQuantityEntered)
            return Result<PurchaseOrderDto>.FailureResult(
                "InvalidSupplierReturnQuantity",
                "Supplier-return quantity must be positive and cannot exceed net received quantity.");

        var inventoryResult = await _inventory.PostMovementAsync(
            new InventoryMovementRequest(
                dto.StockBatchId,
                line.ProductUnitId,
                dto.QuantityEntered,
                StockMovementDirection.Out,
                StockMovementReason.SupplierReturn,
                dto.OccurredAtUtc ?? DateTime.UtcNow,
                nameof(PurchaseOrderLine),
                line.Id,
                Guid.NewGuid().ToString()),
            cancellationToken);

        if (!inventoryResult.Success)
            return Failure<PurchaseOrderDto, StockMovement>(inventoryResult);

        line.RegisterSupplierReturn(dto.QuantityEntered);
        await _unitOfWork.SaveChanges(cancellationToken);
        return Result<PurchaseOrderDto>.SuccessResult(PurchasingDtoMapper.ToDto(order));
    }

    public async Task<Result<PurchaseOrderDto>> Handle(
        PurchaseOrderCancelCommand request,
        CancellationToken cancellationToken
    )
    {
        var order = await LoadOrderAsync(request.Id, cancellationToken);
        if (order is null)
            return Result<PurchaseOrderDto>.NotFoundResult(request.Id);

        order.Cancel();
        await _unitOfWork.SaveChanges(cancellationToken);
        return Result<PurchaseOrderDto>.SuccessResult(PurchasingDtoMapper.ToDto(order));
    }

    private Task<PurchaseOrder?> LoadOrderAsync(
        string id,
        CancellationToken cancellationToken
    ) =>
        _db.PurchaseOrders
            .Include(order => order.Supplier)
            .Include(order => order.Lines)
            .ThenInclude(line => line.Product)
            .FirstOrDefaultAsync(order => order.Id == id, cancellationToken);

    private bool CanAccessShop(
        string shopId
    ) =>
        string.Equals(shopId, _currentUser.GetShopId(), StringComparison.Ordinal);

    private static Result<TTarget> Failure<TTarget, TSource>(
        Result<TSource> source
    ) => new()
    {
        Success = false,
        Message = source.Message,
        Errors = source.Errors
    };
}

internal static class PurchasingDtoMapper
{
    public static SupplierDto ToDto(
        Supplier supplier
    ) => new()
    {
        Id = supplier.Id,
        ShopId = supplier.ShopId,
        Name = supplier.Name,
        PhoneNumber = supplier.PhoneNumber,
        Notes = supplier.Notes,
        IsActive = supplier.IsActive
    };

    public static PurchaseOrderDto ToDto(
        PurchaseOrder order
    ) => new()
    {
        Id = order.Id,
        ShopId = order.ShopId,
        SupplierId = order.SupplierId,
        SupplierName = order.Supplier?.Name ?? string.Empty,
        ReferenceNumber = order.ReferenceNumber,
        OrderedAtUtc = order.OrderedAtUtc,
        Status = order.Status,
        Notes = order.Notes,
        Lines = order.Lines.Select(line => new PurchaseOrderLineDto
        {
            Id = line.Id,
            ProductId = line.ProductId,
            ProductName = line.Product?.Name ?? string.Empty,
            ProductUnitId = line.ProductUnitId,
            OrderedQuantityEntered = line.OrderedQuantityEntered,
            ReceivedQuantityEntered = line.ReceivedQuantityEntered,
            ReturnedQuantityEntered = line.ReturnedQuantityEntered,
            RemainingToReceiveQuantityEntered = line.RemainingToReceiveQuantityEntered,
            NetReceivedQuantityEntered = line.NetReceivedQuantityEntered,
            UnitCostBase = line.UnitCostBase
        }).ToList()
    };
}