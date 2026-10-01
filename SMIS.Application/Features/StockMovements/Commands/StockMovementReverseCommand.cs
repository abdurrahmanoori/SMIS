using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.StockMovements;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Services;
using SMIS.Application.Mappings;

namespace SMIS.Application.Features.StockMovements.Commands;

/// <summary>
/// Reverses a posted movement through the shared inventory workflow. The original
/// movement remains untouched and the workflow posts an opposite ledger entry.
/// </summary>
public record StockMovementReverseCommand(string Id) : IRequest<Result<List<StockMovementDto>>>;

internal sealed class StockMovementReverseCommandHandler
    : IRequestHandler<StockMovementReverseCommand, Result<List<StockMovementDto>>>
{
    private readonly IInventoryService _inventory;
    private readonly IUnitOfWork _unitOfWork;

    public StockMovementReverseCommandHandler(
        IInventoryService inventory,
        IUnitOfWork unitOfWork
    )
    {
        _inventory = inventory;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<List<StockMovementDto>>> Handle(
        StockMovementReverseCommand request,
        CancellationToken cancellationToken
    )
    {
        var result = await _inventory.ReverseMovementAsync(request.Id, cancellationToken);
        if (!result.IsSuccess)
            return Result<List<StockMovementDto>>.Failure(result.Errors);

        await _unitOfWork.SaveChanges(cancellationToken);

        return Result<List<StockMovementDto>>.Success(
            result.Value!.Select(value => value.ToDto()).ToList());
    }
}