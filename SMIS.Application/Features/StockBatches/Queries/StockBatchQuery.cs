using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.StockBatches;
using SMIS.Application.Services;

namespace SMIS.Application.Features.StockBatches.Queries;

public record StockBatchQuery(EntityDropdown<StockBatchQueryCriteria> Query)
    : IRequest<Result<PagedListNew<StockBatchDto>>>;

internal sealed class StockBatchQueryHandler
    : IRequestHandler<StockBatchQuery, Result<PagedListNew<StockBatchDto>>>
{
    private readonly IApplicationDbContext _context;

    public StockBatchQueryHandler(
        IApplicationDbContext context
    )
    {
        _context = context;
    }

    public async Task<Result<PagedListNew<StockBatchDto>>> Handle(
        StockBatchQuery request,
        CancellationToken cancellationToken
    )
    {
        var query = _context.StockBatches
            .OrderByDescending(batch => batch.ReceivedAtUtc)
            .Select(batch => new StockBatchDto
            {
                Id = batch.Id,
                ShopId = batch.ShopId,
                ProductId = batch.ProductId,
                ReceivedProductUnitId = batch.ReceivedProductUnitId,
                ReceivedQuantity = batch.ReceivedQuantity,
                ReceivedQuantityBase = batch.ReceivedQuantityBase,
                RemainingQuantityBase = batch.RemainingQuantityBase,
                UnitCostBase = batch.UnitCostBase,
                BatchNumber = batch.BatchNumber,
                ReceivedAtUtc = batch.ReceivedAtUtc,
                ExpirationDate = batch.ExpirationDate,
                Status = batch.Status
            });

        var pagedList = await query
            .Filter(request.Query.Criteria)
            .Select(request.Query.Columns)
            .ToPagedList(
                request.Query.GetPageNumber(),
                request.Query.GetPageSize(),
                cancellationToken);

        return Result<PagedListNew<StockBatchDto>>.Success(pagedList);
    }
}