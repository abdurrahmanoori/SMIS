using AutoMapper;
using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.StockBatches;
using SMIS.Application.Extensions;
using SMIS.Application.Repositories.StockBatches;

namespace SMIS.Application.Features.StockBatches.Queries
{
    public record StockBatchGetListQuery(int PageNumber = 1, int PageSize = 25) : IRequest<Result<PagedList<StockBatchDto>>>;

    internal sealed class StockBatchGetListQueryHandler : IRequestHandler<StockBatchGetListQuery, Result<PagedList<StockBatchDto>>>
    {
        private readonly IStockBatchRepository _stockBatchRepository;
        private readonly IMapper _mapper;

        public StockBatchGetListQueryHandler(IStockBatchRepository stockBatchRepository, IMapper mapper)
        {
            _stockBatchRepository = stockBatchRepository;
            _mapper = mapper;
        }

        public async Task<Result<PagedList<StockBatchDto>>> Handle(StockBatchGetListQuery request, CancellationToken cancellationToken)
        {
            var stockBatches = await _stockBatchRepository.GetAllQueryable()
                .ToPagedList(request.PageNumber, request.PageSize);

            if (!stockBatches.Items.Any())
            {
                return Result<PagedList<StockBatchDto>>.EmptyResult(nameof(StockBatchDto));
            }

            var stockBatchDtos = _mapper.Map<List<StockBatchDto>>(stockBatches.Items);

            return Result<PagedList<StockBatchDto>>.SuccessResult(new PagedList<StockBatchDto>
            {
                Items = stockBatchDtos,
                TotalCount = stockBatches.TotalCount,
                PageNumber = stockBatches.PageNumber,
                PageSize = stockBatches.PageSize,
                TotalPages = stockBatches.TotalPages
            });
        }
    }
}