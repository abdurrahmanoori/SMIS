using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.StockMovements;
using SMIS.Application.Services;

namespace SMIS.Application.Features.StockMovements.Commands;

/// <summary>
/// Thin command adapter for posting one movement against a known batch. All inventory
/// validation, conversion, balance mutation, ledger creation, and persistence live in
/// <see cref="IInventoryService"/>.
/// </summary>
public record StockMovementCreateCommand(StockMovementCreateDto Dto)
    : IRequest<Result<StockMovementDto>>;

internal sealed class StockMovementCreateCommandHandler
    : IRequestHandler<StockMovementCreateCommand, Result<StockMovementDto>>
{
    private readonly IInventoryService _inventory;
    private readonly IMapper _mapper;

    public StockMovementCreateCommandHandler(
        IInventoryService inventory,
        IMapper mapper)
    {
        _inventory = inventory;
        _mapper = mapper;
    }

    public async Task<Result<StockMovementDto>> Handle(
        StockMovementCreateCommand request,
        CancellationToken cancellationToken)
    {
        var dto = request.Dto;
        var result = await _inventory.PostMovementAsync(
            new InventoryMovementRequest(
                dto.StockBatchId,
                dto.ProductUnitId,
                dto.QuantityEntered,
                dto.Direction,
                dto.Reason,
                dto.OccurredAtUtc ?? DateTime.UtcNow,
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

        return Result<StockMovementDto>.SuccessResult(_mapper.Map<StockMovementDto>(result.Response));
    }
}
