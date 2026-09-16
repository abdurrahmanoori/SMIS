using AutoMapper;
using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.StockBatches;
using SMIS.Application.Extensions;
using SMIS.Application.Repositories.StockBatches;
using SMIS.Application.Identity.IServices;

namespace SMIS.Application.Features.StockBatches.Queries
{
    public record StockBatchGetListQuery(int PageNumber = 1, int PageSize = 25) : IRequest<Result<PagedList<StockBatchDto>>>;

    internal sealed class StockBatchGetListQueryHandler : IRequestHandler<StockBatchGetListQuery, Result<PagedList<StockBatchDto>>>
    {
        private readonly IStockBatchRepository _stockBatchRepository;
        private readonly IMapper _mapper;
        private readonly ICurrentUser _currentUser;

        public StockBatchGetListQueryHandler(
            IStockBatchRepository stockBatchRepository,
            IMapper mapper,
            ICurrentUser currentUser)
        {
            _stockBatchRepository = stockBatchRepository;
            _mapper = mapper;
            _currentUser = currentUser;
        }

        public async Task<Result<PagedList<StockBatchDto>>> Handle(StockBatchGetListQuery request, CancellationToken cancellationToken)
        {
            var query = _stockBatchRepository.GetAllQueryable();
            if (!_currentUser.IsSuperAdmin())
            {
                var shopId = _currentUser.GetShopId();
                query = query.Where(batch => batch.ShopId == shopId);
            }

            var stockBatches = await query
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