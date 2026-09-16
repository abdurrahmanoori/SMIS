using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.StockMovements;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.StockBatches;
using SMIS.Application.Repositories.StockMovements;
using SMIS.Domain.Entities;
using SMIS.Domain.Enums;

namespace SMIS.Application.Features.StockMovements.Commands;

// Corrects a posted movement by adding an opposite movement. The original ledger row
// is preserved so inventory history remains auditable instead of being rewritten.

public record StockMovementReverseCommand(string Id) : IRequest<Result<StockMovementDto>>;

internal sealed class StockMovementReverseCommandHandler
    : IRequestHandler<StockMovementReverseCommand, Result<StockMovementDto>>
{
    private readonly IStockMovementRepository _movements;
    private readonly IStockBatchRepository _batches;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public StockMovementReverseCommandHandler(
        IStockMovementRepository movements,
        IStockBatchRepository batches,
        IUnitOfWork unitOfWork,
        IMapper mapper
    )
    {
        _movements = movements;
        _batches = batches;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Result<StockMovementDto>> Handle(
        StockMovementReverseCommand request,
        CancellationToken cancellationToken
    )
    {
        var original = await _movements.GetByIdAsync(request.Id);
        if (original is null)
            return Result<StockMovementDto>.NotFoundResult(request.Id);

        if (await _movements.HasReversalAsync(original.Id, cancellationToken))
            return Result<StockMovementDto>.FailureResult(
                "MovementAlreadyReversed",
                "This movement already has a reversal entry.");

        var batch = await _batches.GetByIdAsync(original.StockBatchId);
        if (batch is null)
            return Result<StockMovementDto>.FailureResult("StockBatchNotFound", "The movement batch no longer exists.");

        var reverseDirection = original.Direction == StockMovementDirection.In
            ? StockMovementDirection.Out
            : StockMovementDirection.In;

        var reversal = StockMovement.Create(
            original.ShopId,
            original.StockBatchId,
            original.ProductUnitId,
            original.QuantityEntered,
            original.QuantityBase,
            reverseDirection,
            StockMovementReason.Adjustment,
            DateTime.UtcNow,
            "StockMovementReversal",
            original.Id);

        await _unitOfWork.StartTransactionAsync(cancellationToken);
        try
        {
            if (reverseDirection == StockMovementDirection.Out)
                batch.ApplyOutMovement(original.QuantityBase);
            else
                batch.ApplyInMovement(original.QuantityBase);

            await _movements.AddAsync(reversal);
            await _unitOfWork.SaveChanges(cancellationToken);
            await _unitOfWork.CommitTransactionAsync(cancellationToken);
        }
        catch
        {
            await _unitOfWork.RollbackTransactionAsync(cancellationToken);
            throw;
        }

        return Result<StockMovementDto>.SuccessResult(_mapper.Map<StockMovementDto>(reversal));
    }
}