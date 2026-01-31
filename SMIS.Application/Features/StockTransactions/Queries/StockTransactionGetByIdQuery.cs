using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.StockTransactions;
using SMIS.Application.Repositories.StockTransactions;

namespace SMIS.Application.Features.StockTransactions.Queries;

public record StockTransactionGetByIdQuery(string Id, bool IncludeRelated = false) : IRequest<Result<StockTransactionDto>>;

internal sealed class StockTransactionGetByIdQueryHandler : IRequestHandler<StockTransactionGetByIdQuery, Result<StockTransactionDto>>
{
    private readonly IStockTransactionRepository _stockTransactionRepository;
    private readonly IMapper _mapper;

    public StockTransactionGetByIdQueryHandler(IStockTransactionRepository stockTransactionRepository, IMapper mapper)
    {
        _stockTransactionRepository = stockTransactionRepository;
        _mapper = mapper;
    }

    public async Task<Result<StockTransactionDto>> Handle(StockTransactionGetByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _stockTransactionRepository.GetFirstOrDefaultAsync(
            x => x.Id == request.Id,
            includeProperties: request.IncludeRelated ? "Product,StockBatch,UnitOfMeasure" : null);

        if (entity == null)
            return Result<StockTransactionDto>.NotFoundResult(request.Id);

        var dto = _mapper.Map<StockTransactionDto>(entity);
        return Result<StockTransactionDto>.SuccessResult(dto);
    }
}