using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.StockMovements;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Services;

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
    private readonly IMapper _mapper;

    public StockMovementReverseCommandHandler(
        IInventoryService inventory,
        IUnitOfWork unitOfWork,
        IMapper mapper
    )
    {
        _inventory = inventory;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Result<List<StockMovementDto>>> Handle(
        StockMovementReverseCommand request,
        CancellationToken cancellationToken
    )
    {
        var result = await _inventory.ReverseMovementAsync(request.Id, cancellationToken);
        if (!result.Success)
            return new Result<List<StockMovementDto>>
            {
                Success = false,
                Message = result.Message,
                Errors = result.Errors
            };

        await _unitOfWork.SaveChanges(cancellationToken);

        return Result<List<StockMovementDto>>.SuccessResult(
            _mapper.Map<List<StockMovementDto>>(result.Response));
    }
}