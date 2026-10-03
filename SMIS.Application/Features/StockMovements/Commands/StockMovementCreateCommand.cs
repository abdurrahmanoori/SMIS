using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.StockMovements;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Services;
using SMIS.Domain.Services;
using SMIS.Application.Mappings;

namespace SMIS.Application.Features.StockMovements.Commands;

/// <summary>
/// Thin command adapter for posting one movement against a known batch. All inventory
/// validation, conversion, balance mutation, and ledger creation live in
/// <see cref="IInventoryService"/>. This handler owns the final persistence boundary.
/// </summary>
public record StockMovementCreateCommand(StockMovementCreateDto Dto)
    : IRequest<Result<StockMovementDto>>;

internal sealed class StockMovementCreateCommandHandler
    : IRequestHandler<StockMovementCreateCommand, Result<StockMovementDto>>
{
    private readonly IInventoryService _inventory;
    private readonly IUnitOfWork _unitOfWork;

    public StockMovementCreateCommandHandler(
        IInventoryService inventory,
        IUnitOfWork unitOfWork
    )
    {
        _inventory = inventory;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<StockMovementDto>> Handle(
        StockMovementCreateCommand request,
        CancellationToken cancellationToken
    )
    {
        var dto = request.Dto;
        var result = await _inventory.PostMovementAsync(
            new InventoryMovementRequest(
                dto.StockBatchId,
                dto.ProductUnitId,
                dto.QuantityEntered,
                dto.Direction,
                dto.Reason,
                dto.OccurredAtUtc ?? DateTimeService.NowUtc,
                dto.ReferenceType,
                dto.ReferenceId),
            cancellationToken);

        if (!result.IsSuccess)
            return Result<StockMovementDto>.Failure(result.Errors);

        await _unitOfWork.SaveChanges(cancellationToken);

        return Result<StockMovementDto>.Success(result.Value!.ToDto());
    }
}