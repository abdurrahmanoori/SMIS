using AutoMapper;
using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.StockMovements;
using SMIS.Application.Extensions;
using SMIS.Application.Repositories.StockMovements;

namespace SMIS.Application.Features.StockMovements.Queries;

public record StockMovementGetListQuery(int PageNumber = 1, int PageSize = 25)
    : IRequest<Result<PagedList<StockMovementDto>>>;

internal sealed class StockMovementGetListQueryHandler
    : IRequestHandler<StockMovementGetListQuery, Result<PagedList<StockMovementDto>>>
{
    private readonly IStockMovementRepository _repository;
    private readonly IMapper _mapper;

    public StockMovementGetListQueryHandler(IStockMovementRepository repository, IMapper mapper) =>
        (_repository, _mapper) = (repository, mapper);

    public async Task<Result<PagedList<StockMovementDto>>> Handle(
        StockMovementGetListQuery request,
        CancellationToken cancellationToken)
    {
        var page = await _repository.GetAllQueryable()
            .OrderByDescending(movement => movement.OccurredAtUtc)
            .ToPagedList(request.PageNumber, request.PageSize);

        var result = new PagedList<StockMovementDto>
        {
            Items = _mapper.Map<List<StockMovementDto>>(page.Items),
            TotalCount = page.TotalCount,
            PageNumber = page.PageNumber,
            PageSize = page.PageSize,
            TotalPages = page.TotalPages
        };

        return Result<PagedList<StockMovementDto>>.SuccessResult(result);
    }
}
