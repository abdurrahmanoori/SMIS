using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.StockMovements;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Services;
using SMIS.Domain.Services;
using SMIS.Application.Mappings;

namespace SMIS.Application.Features.StockMovements.Commands;

/// <summary>
/// Requests one logical FIFO issue. The inventory workflow decides which batches are
/// consumed and creates one immutable movement for each allocated batch.
/// </summary>
public record StockMovementFifoIssueCommand(FifoStockIssueDto Dto)
    : IRequest<Result<List<StockMovementDto>>>;

internal sealed class StockMovementFifoIssueCommandHandler
    : IRequestHandler<StockMovementFifoIssueCommand, Result<List<StockMovementDto>>>
{
    private readonly IInventoryService _inventory;
    private readonly IUnitOfWork _unitOfWork;

    public StockMovementFifoIssueCommandHandler(
        IInventoryService inventory,
        IUnitOfWork unitOfWork
    )
    {
        _inventory = inventory;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<List<StockMovementDto>>> Handle(
        StockMovementFifoIssueCommand request,
        CancellationToken cancellationToken
    )
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

        if (!result.IsSuccess)
            return Result<List<StockMovementDto>>.Failure(result.Errors);

        // All FIFO batch deductions and generated movements are committed together.
        await _unitOfWork.SaveChanges(cancellationToken);

        return Result<List<StockMovementDto>>.Success(
            result.Value!.Select(value => value.ToDto()).ToList());
    }
}