using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.StockMovements;
using SMIS.Application.Repositories.StockMovements;

namespace SMIS.Application.Features.StockMovements.Queries;

public record StockMovementGetByIdQuery(string Id) : IRequest<Result<StockMovementDto>>;

internal sealed class StockMovementGetByIdQueryHandler
    : IRequestHandler<StockMovementGetByIdQuery, Result<StockMovementDto>>
{
    private readonly IStockMovementRepository _repository;
    private readonly IMapper _mapper;

    public StockMovementGetByIdQueryHandler(IStockMovementRepository repository, IMapper mapper) =>
        (_repository, _mapper) = (repository, mapper);

    public async Task<Result<StockMovementDto>> Handle(
        StockMovementGetByIdQuery request,
        CancellationToken cancellationToken)
    {
        var movement = await _repository.GetByIdAsync(request.Id);
        return movement is null
            ? Result<StockMovementDto>.NotFoundResult(request.Id)
            : Result<StockMovementDto>.SuccessResult(_mapper.Map<StockMovementDto>(movement));
    }
}
