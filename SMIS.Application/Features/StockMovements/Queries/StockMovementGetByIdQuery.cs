using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.StockMovements;
using SMIS.Application.Repositories.StockMovements;
using SMIS.Application.Identity.IServices;

namespace SMIS.Application.Features.StockMovements.Queries;

public record StockMovementGetByIdQuery(string Id) : IRequest<Result<StockMovementDto>>;

internal sealed class StockMovementGetByIdQueryHandler
    : IRequestHandler<StockMovementGetByIdQuery, Result<StockMovementDto>>
{
    private readonly IStockMovementRepository _repository;
    private readonly IMapper _mapper;
    private readonly ICurrentUser _currentUser;

    public StockMovementGetByIdQueryHandler(
        IStockMovementRepository repository,
        IMapper mapper,
        ICurrentUser currentUser
    ) =>
        (_repository, _mapper, _currentUser) = (repository, mapper, currentUser);

    public async Task<Result<StockMovementDto>> Handle(
        StockMovementGetByIdQuery request,
        CancellationToken cancellationToken
    )
    {
        var shopId = _currentUser.GetShopId();
        var movement = await _repository.GetFirstOrDefaultAsync(item =>
            item.Id == request.Id &&
            item.ShopId == shopId);
        return movement is null
            ? Result<StockMovementDto>.NotFoundResult(request.Id)
            : Result<StockMovementDto>.SuccessResult(_mapper.Map<StockMovementDto>(movement));
    }
}