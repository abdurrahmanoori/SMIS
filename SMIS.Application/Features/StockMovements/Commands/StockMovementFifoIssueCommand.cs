using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.StockMovements;
using SMIS.Application.Features.StockMovements;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Services;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.StockMovements.Commands;

public record StockMovementFifoIssueCommand(FifoStockIssueDto Dto)
    : IRequest<Result<List<StockMovementDto>>>;

internal sealed class StockMovementFifoIssueCommandHandler
    : IRequestHandler<StockMovementFifoIssueCommand, Result<List<StockMovementDto>>>
{
    private readonly IInventoryService _inventory;
    private readonly IUnitOfWork _unitOfWork;

    public StockMovementFifoIssueCommandHandler(IInventoryService inventory, IUnitOfWork unitOfWork)
        => (_inventory, _unitOfWork) = (inventory, unitOfWork);

    public async Task<Result<List<StockMovementDto>>> Handle(
        StockMovementFifoIssueCommand request,
        CancellationToken cancellationToken)
    {
        var dto = request.Dto;
        var result = await _inventory.IssueFifoAsync(
            new InventoryFifoIssueRequest(
                dto.ProductId,
                dto.ProductUnitId,
                dto.QuantityEntered,
                dto.Reason,
                dto.OccurredAtUtc ?? DateTimeService.NowUtc,
                dto.ReferenceType,
                dto.ReferenceId),
            cancellationToken);

        if (!result.Success)
            return new Result<List<StockMovementDto>>
            {
                Success = false,
                Message = result.Message,
                Errors = result.Errors
            };

        await _unitOfWork.SaveChanges(cancellationToken);
        return Result<List<StockMovementDto>>.SuccessResult(StockMovementMapping.ToDtos(result.Response));
    }
}
