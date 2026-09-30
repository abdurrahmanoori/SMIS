using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.StockMovements;
using SMIS.Application.Services;

namespace SMIS.Application.Features.StockMovements.Queries;

public record StockMovementQuery(EntityDropdown<StockMovementQueryCriteria> Query)
    : IRequest<Result<PagedListNew<StockMovementDto>>>;

internal sealed class StockMovementQueryHandler
    : IRequestHandler<StockMovementQuery, Result<PagedListNew<StockMovementDto>>>
{
    private readonly IApplicationDbContext _context;

    public StockMovementQueryHandler(
        IApplicationDbContext context
    )
    {
        _context = context;
    }

    public async Task<Result<PagedListNew<StockMovementDto>>> Handle(
        StockMovementQuery request,
        CancellationToken cancellationToken
    )
    {
        var query = _context.StockMovements
            .OrderByDescending(movement => movement.OccurredAtUtc)
            .Select(movement => new StockMovementDto
            {
                Id = movement.Id,
                ShopId = movement.ShopId,
                OperationId = movement.OperationId,
                StockBatchId = movement.StockBatchId,
                ProductUnitId = movement.ProductUnitId,
                QuantityEntered = movement.QuantityEntered,
                QuantityBase = movement.QuantityBase,
                Direction = movement.Direction,
                Reason = movement.Reason,
                OccurredAtUtc = movement.OccurredAtUtc,
                ReferenceType = movement.ReferenceType,
                ReferenceId = movement.ReferenceId
            });

        var pagedList = await query
            .Filter(request.Query.Criteria)
            .Select(request.Query.Columns)
            .ToPagedList(
                request.Query.GetPageNumber(),
                request.Query.GetPageSize(),
                cancellationToken);

        return Result<PagedListNew<StockMovementDto>>.SuccessResult(pagedList);
    }
}