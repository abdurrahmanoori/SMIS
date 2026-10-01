using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Inventory;
using SMIS.Application.DTO.StockMovements;
using SMIS.Application.Features.StockMovements;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Services;
using SMIS.Domain.Enums;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.Inventory.Commands;

public sealed record InventoryBatchOperationCommand(
    InventoryBatchOperationDto Dto,
    StockMovementDirection Direction,
    StockMovementReason Reason)
    : IRequest<Result<StockMovementDto>>;

internal sealed class InventoryBatchOperationCommandHandler
    : IRequestHandler<InventoryBatchOperationCommand, Result<StockMovementDto>>
{
    private readonly IInventoryService _inventory;
    private readonly IIdempotencyService _idempotency;
    private readonly IUnitOfWork _unitOfWork;

    public InventoryBatchOperationCommandHandler(
        IInventoryService inventory,
        IIdempotencyService idempotency,
        IUnitOfWork unitOfWork)
    {
        _inventory = inventory;
        _idempotency = idempotency;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<StockMovementDto>> Handle(
        InventoryBatchOperationCommand request,
        CancellationToken cancellationToken)
    {
        var dto = request.Dto;
        var reservation = await _idempotency.ReserveAsync(
            $"inventory:{request.Reason}", dto.IdempotencyKey, cancellationToken);
        if (!reservation.IsSuccess) return Failure(reservation);

        var result = await _inventory.PostMovementAsync(
            new InventoryMovementRequest(
                dto.StockBatchId,
                dto.ProductUnitId,
                dto.QuantityEntered,
                request.Direction,
                request.Reason,
                dto.OccurredAtUtc ?? DateTimeService.NowUtc,
                dto.ReferenceType,
                dto.ReferenceId),
            cancellationToken);
        if (result.IsSuccess) return Failure(result);

        if (!result.IsSuccess)
            return Failure(result);

        // The inventory workflow stages both the batch balance change and immutable
        // movement. One SaveChanges persists them atomically.
        await _unitOfWork.SaveChanges(cancellationToken);
        return Result<StockMovementDto>.Success(StockMovementMapping.ToDto(result.Value));
    }

    private static Result<StockMovementDto> Failure<T>(Result<T> source) => Result<StockMovementDto>.Failure(source.Errors);
}

public sealed record InventoryTransferCommand(InventoryTransferDto Dto)
    : IRequest<Result<List<StockMovementDto>>>;

internal sealed class InventoryTransferCommandHandler
    : IRequestHandler<InventoryTransferCommand, Result<List<StockMovementDto>>>
{
    private readonly IInventoryService _inventory;
    private readonly IIdempotencyService _idempotency;
    private readonly IUnitOfWork _unitOfWork;

    public InventoryTransferCommandHandler(
        IInventoryService inventory,
        IIdempotencyService idempotency,
        IUnitOfWork unitOfWork)
    {
        _inventory = inventory;
        _idempotency = idempotency;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<List<StockMovementDto>>> Handle(
        InventoryTransferCommand request,
        CancellationToken cancellationToken)
    {
        var dto = request.Dto;
        var reservation = await _idempotency.ReserveAsync(
            "inventory:transfer", dto.IdempotencyKey, cancellationToken);
        if (!reservation.IsSuccess)
            return Result<List<StockMovementDto>>.Failure(reservation.Errors);

        var result = await _inventory.TransferAsync(
            new InventoryTransferRequest(
                dto.SourceStockBatchId,
                dto.DestinationStockBatchId,
                dto.ProductUnitId,
                dto.QuantityEntered,
                dto.OccurredAtUtc ?? DateTimeService.NowUtc,
                dto.ReferenceType,
                dto.ReferenceId),
            cancellationToken);
        if (!result.IsSuccess)
            return Result<List<StockMovementDto>>.Failure(result.Errors);

        await _unitOfWork.SaveChanges(cancellationToken);
        return Result<List<StockMovementDto>>.Success(StockMovementMapping.ToDtos(result.Value));
    }
}
