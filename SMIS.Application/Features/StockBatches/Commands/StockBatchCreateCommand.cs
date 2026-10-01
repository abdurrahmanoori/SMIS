using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.StockBatches;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Services;
using SMIS.Domain.Services;
using SMIS.Application.Mappings;

namespace SMIS.Application.Features.StockBatches.Commands;

public record StockBatchCreateCommand(StockBatchCreateDto StockBatchCreateDto)
    : IRequest<Result<StockBatchDto>>;

internal sealed class StockBatchCreateCommandHandler
    : IRequestHandler<StockBatchCreateCommand, Result<StockBatchDto>>
{
    private readonly IInventoryService _inventory;
    private readonly IIdempotencyService _idempotency;
    private readonly IUnitOfWork _unitOfWork;

    public StockBatchCreateCommandHandler(
        IInventoryService inventory,
        IIdempotencyService idempotency,
        IUnitOfWork unitOfWork
    )
    {
        _inventory = inventory;
        _idempotency = idempotency;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<StockBatchDto>> Handle(
        StockBatchCreateCommand request,
        CancellationToken cancellationToken
    )
    {
        var dto = request.StockBatchCreateDto;
        var reservation = await _idempotency.ReserveAsync(
            "inventory:purchase-receipt",
            dto.IdempotencyKey,
            cancellationToken);
        if (!reservation.IsSuccess)
            return Result<StockBatchDto>.Failure(reservation.Errors);

        var result = await _inventory.ReceiveBatchAsync(
            new InventoryReceiptRequest(
                dto.ProductId,
                dto.ReceivedProductUnitId,
                dto.ReceivedQuantity,
                dto.UnitCostBase,
                dto.ReceivedAtUtc ?? DateTimeService.NowUtc,
                dto.BatchNumber,
                dto.ExpirationDate,
                dto.ReferenceType,
                dto.ReferenceId),
            cancellationToken);

        if (!result.IsSuccess)
            return Result<StockBatchDto>.Failure(result.Errors);

        // Batch and opening movement are already staged in the same DbContext.
        // One SaveChanges call is sufficient; EF Core wraps it in a transaction.
        await _unitOfWork.SaveChanges(cancellationToken);

        return Result<StockBatchDto>.Success(result.Value!.ToDto());
    }
}