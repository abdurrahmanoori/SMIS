using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.StockBatches;
using SMIS.Application.Repositories.StockBatches;
using SMIS.Application.Identity.IServices;

namespace SMIS.Application.Features.StockBatches.Queries
{
    public record StockBatchGetByIdQuery(string Id) : IRequest<Result<StockBatchDto>>;

    internal sealed class StockBatchGetByIdQueryHandler : IRequestHandler<StockBatchGetByIdQuery, Result<StockBatchDto>>
    {
        private readonly IStockBatchRepository _stockBatchRepository;
        private readonly IMapper _mapper;
        private readonly ICurrentUser _currentUser;

        public StockBatchGetByIdQueryHandler(
            IStockBatchRepository stockBatchRepository,
            IMapper mapper,
            ICurrentUser currentUser)
        {
            _stockBatchRepository = stockBatchRepository;
            _mapper = mapper;
            _currentUser = currentUser;
        }

        public async Task<Result<StockBatchDto>> Handle(StockBatchGetByIdQuery request, CancellationToken cancellationToken)
        {
            var shopId = _currentUser.GetShopId();
            var entity = await _stockBatchRepository.GetFirstOrDefaultAsync(batch =>
                batch.Id == request.Id &&
                batch.ShopId == shopId);
            if (entity == null)
            {
                return Result<StockBatchDto>.NotFoundResult(request.Id);
            }

            var dto = _mapper.Map<StockBatchDto>(entity);
            return Result<StockBatchDto>.SuccessResult(dto);
        }
    }
}