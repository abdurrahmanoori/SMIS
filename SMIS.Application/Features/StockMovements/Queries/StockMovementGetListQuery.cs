using AutoMapper;
using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.StockMovements;
using SMIS.Application.Extensions;
using SMIS.Application.Repositories.StockMovements;
using SMIS.Application.Identity.IServices;

namespace SMIS.Application.Features.StockMovements.Queries;

public record StockMovementGetListQuery(int PageNumber = 1, int PageSize = 25)
    : IRequest<Result<PagedList<StockMovementDto>>>;

internal sealed class StockMovementGetListQueryHandler
    : IRequestHandler<StockMovementGetListQuery, Result<PagedList<StockMovementDto>>>
{
    private readonly IStockMovementRepository _repository;
    private readonly IMapper _mapper;
    private readonly ICurrentUser _currentUser;

    public StockMovementGetListQueryHandler(
        IStockMovementRepository repository,
        IMapper mapper,
        ICurrentUser currentUser) =>
        (_repository, _mapper, _currentUser) = (repository, mapper, currentUser);

    public async Task<Result<PagedList<StockMovementDto>>> Handle(
        StockMovementGetListQuery request,
        CancellationToken cancellationToken)
    {
        var query = _repository.GetAllQueryable();
        var shopId = _currentUser.GetShopId();
        query = query.Where(movement => movement.ShopId == shopId);

        var page = await query
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
