using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.StockMovements;
using SMIS.Application.Features.StockMovements;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Services;

namespace SMIS.Application.Features.StockMovements.Commands;

public record StockMovementReverseCommand(string Id) : IRequest<Result<List<StockMovementDto>>>;

internal sealed class StockMovementReverseCommandHandler
    : IRequestHandler<StockMovementReverseCommand, Result<List<StockMovementDto>>>
{
    private readonly IInventoryService _inventory;
    private readonly IUnitOfWork _unitOfWork;

    public StockMovementReverseCommandHandler(IInventoryService inventory, IUnitOfWork unitOfWork)
        => (_inventory, _unitOfWork) = (inventory, unitOfWork);

    public async Task<Result<List<StockMovementDto>>> Handle(
        StockMovementReverseCommand request,
        CancellationToken cancellationToken)
    {
        var result = await _inventory.ReverseMovementAsync(request.Id, cancellationToken);
        if (!result.IsSuccess)
            return Result<List<StockMovementDto>>.Failure(result.Errors);

        await _unitOfWork.SaveChanges(cancellationToken);
        return Result<List<StockMovementDto>>.Success(StockMovementMapping.ToDtos(result.Value));
    }
}
