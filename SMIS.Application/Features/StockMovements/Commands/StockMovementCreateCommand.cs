using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.StockMovements;
using SMIS.Application.Features.StockMovements;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Services;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.StockMovements.Commands;

public record StockMovementCreateCommand(StockMovementCreateDto Dto)
    : IRequest<Result<StockMovementDto>>;

internal sealed class StockMovementCreateCommandHandler
    : IRequestHandler<StockMovementCreateCommand, Result<StockMovementDto>>
{
    private readonly IInventoryService _inventory;
    private readonly IUnitOfWork _unitOfWork;

    public StockMovementCreateCommandHandler(IInventoryService inventory, IUnitOfWork unitOfWork)
        => (_inventory, _unitOfWork) = (inventory, unitOfWork);

    public async Task<Result<StockMovementDto>> Handle(StockMovementCreateCommand request, CancellationToken cancellationToken)
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

        if (!result.Success)
            return new Result<StockMovementDto>
            {
                Success = false,
                Message = result.Message,
                Errors = result.Errors
            };

        await _unitOfWork.SaveChanges(cancellationToken);
        return Result<StockMovementDto>.SuccessResult(StockMovementMapping.ToDto(result.Response));
    }
}
