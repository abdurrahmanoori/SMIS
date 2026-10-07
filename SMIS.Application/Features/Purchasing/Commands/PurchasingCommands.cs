using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Purchasing;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Services;
using SMIS.Domain.Entities;
using SMIS.Domain.Enums;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.Purchasing.Commands;

public sealed record SupplierCreateCommand(SupplierCreateDto Dto) : IRequest<Result<SupplierDto>>;

public sealed record SupplierUpdateCommand(string Id, SupplierUpdateDto Dto) : IRequest<Result<SupplierDto>>;

public sealed record SupplierStatusUpdateCommand(string Id, SupplierStatusUpdateDto Dto)
    : IRequest<Result<SupplierDto>>;

public sealed record PurchaseOrderCreateCommand(PurchaseOrderCreateDto Dto) : IRequest<Result<PurchaseOrderDto>>;

public sealed record PurchaseOrderReceiveCommand(string Id, PurchaseOrderReceiveDto Dto)
    : IRequest<Result<PurchaseOrderDto>>;

public sealed record PurchaseOrderSupplierReturnCommand(string Id, PurchaseOrderSupplierReturnDto Dto)
    : IRequest<Result<PurchaseOrderDto>>;

public sealed record PurchaseOrderCancelCommand(string Id) : IRequest<Result<PurchaseOrderDto>>;

internal sealed class PurchasingCommandHandler :
    IRequestHandler<SupplierCreateCommand, Result<SupplierDto>>,
    IRequestHandler<SupplierUpdateCommand, Result<SupplierDto>>,
    IRequestHandler<SupplierStatusUpdateCommand, Result<SupplierDto>>,
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
            return Result<SupplierDto>.Forbidden("supplier.shop_context_required", "An active shop is required.");

        var name = request.Dto.Name.Trim();
        var duplicate = await _db.Suppliers.AnyAsync(
            supplier => supplier.ShopId == shopId && supplier.Name == name,
            cancellationToken);
        if (duplicate)
            return Result<SupplierDto>.Conflict("supplier.name_conflict",
                "A supplier with this name already exists in the shop.");

        var supplier = Supplier.Create(
            shopId,
            name,
            request.Dto.PhoneNumber,
            request.Dto.Notes);

        await _db.Suppliers.AddAsync(supplier, cancellationToken);
        await _unitOfWork.SaveChanges(cancellationToken);
        return Result<SupplierDto>.Success(PurchasingDtoMapper.ToDto(supplier));
    }

    public async Task<Result<SupplierDto>> Handle(
        SupplierUpdateCommand request,
        CancellationToken cancellationToken
    )
    {
        var shopId = _currentUser.GetShopId();
        if (string.IsNullOrWhiteSpace(shopId))
            return Result<SupplierDto>.Forbidden("supplier.shop_context_required", "An active shop is required.");

        var supplier = await _db.Suppliers.FirstOrDefaultAsync(
            item => item.Id == request.Id && item.ShopId == shopId,
            cancellationToken);
        if (supplier is null)
            return Result<SupplierDto>.NotFound(
                "supplier.not_found",
                "The supplier does not exist in the active shop.");

        var name = request.Dto.Name.Trim();
        var duplicate = await _db.Suppliers.AnyAsync(
            item => item.Id != supplier.Id && item.ShopId == shopId && item.Name == name,
            cancellationToken);
        if (duplicate)
            return Result<SupplierDto>.Conflict(
                "supplier.name_conflict",
                "A supplier with this name already exists in the shop.");

        supplier.Update(name, request.Dto.PhoneNumber, request.Dto.Notes);
        supplier.ClearClientModificationMetadata();
        await _unitOfWork.SaveChanges(cancellationToken);

        return Result<SupplierDto>.Success(PurchasingDtoMapper.ToDto(supplier));
    }

    public async Task<Result<SupplierDto>> Handle(
        SupplierStatusUpdateCommand request,
        CancellationToken cancellationToken
    )
    {
        var shopId = _currentUser.GetShopId();
        if (string.IsNullOrWhiteSpace(shopId))
            return Result<SupplierDto>.Forbidden("supplier.shop_context_required", "An active shop is required.");

        var supplier = await _db.Suppliers.FirstOrDefaultAsync(
            item => item.Id == request.Id && item.ShopId == shopId,
            cancellationToken);
        if (supplier is null)
            return Result<SupplierDto>.NotFound(
                "supplier.not_found",
                "The supplier does not exist in the active shop.");

        if (request.Dto.IsActive == true)
            supplier.Activate();
        else
            supplier.Deactivate();

        supplier.ClearClientModificationMetadata();
        await _unitOfWork.SaveChanges(cancellationToken);
        return Result<SupplierDto>.Success(PurchasingDtoMapper.ToDto(supplier));
    }

    public async Task<Result<PurchaseOrderDto>> Handle(
        PurchaseOrderCreateCommand request,
        CancellationToken cancellationToken
    )
    {
        var dto = request.Dto;
        var shopId = _currentUser.GetShopId();
        if (string.IsNullOrWhiteSpace(shopId))
            return Result<PurchaseOrderDto>.Forbidden("purchase_order.shop_context_required",
                "An active shop is required.");

        var reservation = await _idempotency.BeginReplayableAsync(
            "purchase-order:create",
            dto.IdempotencyKey,
            new { ShopId = shopId, Request = dto },
            cancellationToken);
        if (!reservation.IsSuccess)
            return Failure<PurchaseOrderDto, IdempotencyRecord?>(reservation);
        if (reservation.Value?.ResponseJson is not null)
            return _idempotency.Replay<PurchaseOrderDto>(reservation.Value);

        var supplier = await _db.Suppliers.FirstOrDefaultAsync(
            item => item.Id == dto.SupplierId && item.ShopId == shopId,
            cancellationToken);
        if (supplier is null || !supplier.IsActive)
            return Result<PurchaseOrderDto>.NotFound(
                "SupplierNotFoundOrInactive",
                "The selected supplier does not exist in this shop or is inactive.");

        if (dto.Lines.Count == 0)
            return Result<PurchaseOrderDto>.BusinessRule("PurchaseOrderLinesRequired",
                "A purchase order requires at least one line.");

        if (dto.Lines.Select(line => line.ProductUnitId).Distinct(StringComparer.Ordinal).Count() != dto.Lines.Count)
            return Result<PurchaseOrderDto>.Conflict(
                "purchase_order.duplicate_line",
                "A product unit can appear only once in a purchase order.");

        var order = PurchaseOrder.Create(
            shopId,
            dto.SupplierId,
            dto.OrderedAtUtc ?? DateTimeService.NowUtc,
            dto.ReferenceNumber,
            dto.Notes);
        if (!string.IsNullOrWhiteSpace(dto.Id))
            order.Id = dto.Id.Trim();

        foreach (var lineDto in dto.Lines)
        {
            var productUnit = await _db.ProductUnits
                .Include(unit => unit.Product)
                .FirstOrDefaultAsync(unit =>
                        unit.Id == lineDto.ProductUnitId &&
                        unit.ProductId == lineDto.ProductId,
                    cancellationToken);

            if (productUnit?.Product is null || productUnit.Product.ShopId != shopId)
                return Result<PurchaseOrderDto>.BusinessRule(
                    "PurchaseOrderProductMismatch",
                    "Every purchase-order product unit must belong to a product in the selected shop.");

            var orderLine = PurchaseOrderLine.Create(
                order.Id,
                lineDto.ProductId,
                lineDto.ProductUnitId,
                lineDto.QuantityEntered,
                lineDto.UnitCostBase);
            if (!string.IsNullOrWhiteSpace(lineDto.Id))
                orderLine.Id = lineDto.Id.Trim();
            orderLine.Product = productUnit.Product;
            orderLine.ProductUnit = productUnit;
            order.Lines.Add(orderLine);
        }

        order.Supplier = supplier;
        await _db.PurchaseOrders.AddAsync(order, cancellationToken);
        var response = PurchasingDtoMapper.ToDto(order);
        _idempotency.Complete(reservation.Value, response);
        await _unitOfWork.SaveChanges(cancellationToken);

        return Result<PurchaseOrderDto>.Success(response);
    }

    public async Task<Result<PurchaseOrderDto>> Handle(
        PurchaseOrderReceiveCommand request,
        CancellationToken cancellationToken
    )
    {
        var order = await LoadOrderAsync(request.Id, cancellationToken);
        if (order is null)
            return Result<PurchaseOrderDto>.NotFound(request.Id);
        var reservation = await _idempotency.BeginReplayableAsync(
            $"purchase-order:receive:{order.Id}",
            request.Dto.IdempotencyKey,
            request.Dto,
            cancellationToken);
        if (!reservation.IsSuccess)
            return Failure<PurchaseOrderDto, IdempotencyRecord?>(reservation);
        if (reservation.Value?.ResponseJson is not null)
            return _idempotency.Replay<PurchaseOrderDto>(reservation.Value);
        if (order.Status == PurchaseOrderStatus.Cancelled)
            return Result<PurchaseOrderDto>.BusinessRule("PurchaseOrderCancelled",
                "A cancelled purchase order cannot receive stock.");

        if (request.Dto.Lines.Count == 0)
            return Result<PurchaseOrderDto>.BusinessRule("ReceiptLinesRequired",
                "At least one receipt line is required.");
        if (request.Dto.Lines.Select(line => line.PurchaseOrderLineId).Distinct(StringComparer.Ordinal).Count() !=
            request.Dto.Lines.Count)
            return Result<PurchaseOrderDto>.Conflict("purchase_receipt.duplicate_line",
                "A purchase-order line can appear only once per receipt.");

        var occurredAtUtc = request.Dto.OccurredAtUtc ?? DateTimeService.NowUtc;
        var operationId = Guid.NewGuid().ToString();
        foreach (var receipt in request.Dto.Lines)
        {
            var line = order.Lines.FirstOrDefault(item => item.Id == receipt.PurchaseOrderLineId);
            if (line is null)
                return Result<PurchaseOrderDto>.NotFound(
                    "PurchaseOrderLineNotFound",
                    "A receipt line does not belong to this purchase order.");

            if (receipt.QuantityEntered <= 0 || receipt.QuantityEntered > line.RemainingToReceiveQuantityEntered)
                return Result<PurchaseOrderDto>.BusinessRule(
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

            if (!inventoryResult.IsSuccess)
                return Failure<PurchaseOrderDto, StockBatch>(inventoryResult);

            line.RegisterReceipt(receipt.QuantityEntered);
        }

        order.RefreshReceiptStatus();
        var response = PurchasingDtoMapper.ToDto(order);
        _idempotency.Complete(reservation.Value, response);
        await _unitOfWork.SaveChanges(cancellationToken);
        return Result<PurchaseOrderDto>.Success(response);
    }

    public async Task<Result<PurchaseOrderDto>> Handle(
        PurchaseOrderSupplierReturnCommand request,
        CancellationToken cancellationToken
    )
    {
        var order = await LoadOrderAsync(request.Id, cancellationToken);
        if (order is null)
            return Result<PurchaseOrderDto>.NotFound(request.Id);

        var dto = request.Dto;
        var reservation = await _idempotency.BeginReplayableAsync(
            $"purchase-order:supplier-return:{order.Id}",
            dto.IdempotencyKey,
            dto,
            cancellationToken);
        if (!reservation.IsSuccess)
            return Failure<PurchaseOrderDto, IdempotencyRecord?>(reservation);
        if (reservation.Value?.ResponseJson is not null)
            return _idempotency.Replay<PurchaseOrderDto>(reservation.Value);

        var line = order.Lines.FirstOrDefault(item => item.Id == dto.PurchaseOrderLineId);
        if (line is null)
            return Result<PurchaseOrderDto>.NotFound(
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
            return Result<PurchaseOrderDto>.BusinessRule(
                "SupplierReturnBatchMismatch",
                "The selected batch was not received for this purchase-order line.");

        if (dto.QuantityEntered <= 0 || dto.QuantityEntered > line.NetReceivedQuantityEntered)
            return Result<PurchaseOrderDto>.BusinessRule(
                "InvalidSupplierReturnQuantity",
                "Supplier-return quantity must be positive and cannot exceed net received quantity.");

        var inventoryResult = await _inventory.PostMovementAsync(
            new InventoryMovementRequest(
                dto.StockBatchId,
                line.ProductUnitId,
                dto.QuantityEntered,
                StockMovementDirection.Out,
                StockMovementReason.SupplierReturn,
                dto.OccurredAtUtc ?? DateTimeService.NowUtc,
                nameof(PurchaseOrderLine),
                line.Id,
                Guid.NewGuid().ToString()),
            cancellationToken);

        if (!inventoryResult.IsSuccess)
            return Failure<PurchaseOrderDto, StockMovement>(inventoryResult);

        line.RegisterSupplierReturn(dto.QuantityEntered);
        var response = PurchasingDtoMapper.ToDto(order);
        _idempotency.Complete(reservation.Value, response);
        await _unitOfWork.SaveChanges(cancellationToken);
        return Result<PurchaseOrderDto>.Success(response);
    }

    public async Task<Result<PurchaseOrderDto>> Handle(
        PurchaseOrderCancelCommand request,
        CancellationToken cancellationToken
    )
    {
        var order = await LoadOrderAsync(request.Id, cancellationToken);
        if (order is null)
            return Result<PurchaseOrderDto>.NotFound(request.Id);

        if (order.Status == PurchaseOrderStatus.Cancelled)
            return Result<PurchaseOrderDto>.Success(PurchasingDtoMapper.ToDto(order));

        order.Cancel();
        await _unitOfWork.SaveChanges(cancellationToken);
        return Result<PurchaseOrderDto>.Success(PurchasingDtoMapper.ToDto(order));
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
    ) => Result<TTarget>.Failure(source.Errors);
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