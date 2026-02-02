using AutoMapper;
using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.StockTransactions;
using SMIS.Application.Repositories.StockTransactions;

namespace SMIS.Application.Features.StockTransactions.Queries;

public record StockTransactionGetListQuery(int PageNumber = 1, int PageSize = 25, bool IncludeRelated = false) : IRequest<Result<PagedList<StockTransactionDto>>>;

internal sealed class StockTransactionGetListQueryHandler : IRequestHandler<StockTransactionGetListQuery, Result<PagedList<StockTransactionDto>>>
{
    private readonly IStockTransactionRepository _stockTransactionRepository;
    private readonly IMapper _mapper;

    public StockTransactionGetListQueryHandler(IStockTransactionRepository stockTransactionRepository, IMapper mapper)
    {
        _stockTransactionRepository = stockTransactionRepository;
        _mapper = mapper;
    }

    public async Task<Result<PagedList<StockTransactionDto>>> Handle(StockTransactionGetListQuery request, CancellationToken cancellationToken)
    {
        var query = _stockTransactionRepository.GetAllQueryable(includeProperties: request.IncludeRelated ? "Product,StockBatch,UnitOfMeasure" : null);
        var transactions = await query.ToPagedList(request.PageNumber, request.PageSize);

        if (!transactions.Items.Any())
        {
            return Result<PagedList<StockTransactionDto>>.EmptyResult(nameof(StockTransactionDto));
        }

        var transactionDtos = _mapper.Map<List<StockTransactionDto>>(transactions.Items);

        return Result<PagedList<StockTransactionDto>>.SuccessResult(new PagedList<StockTransactionDto>
        {
            Items = transactionDtos,
            TotalCount = transactions.TotalCount,
            PageNumber = transactions.PageNumber,
            PageSize = transactions.PageSize
        });
    }
}