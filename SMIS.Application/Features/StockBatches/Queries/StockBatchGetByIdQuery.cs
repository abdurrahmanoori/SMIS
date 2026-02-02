using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.StockBatches;
using SMIS.Application.Repositories.StockBatches;

namespace SMIS.Application.Features.StockBatches.Queries
{
    public record StockBatchGetByIdQuery(string Id) : IRequest<Result<StockBatchDto>>;

    internal sealed class StockBatchGetByIdQueryHandler : IRequestHandler<StockBatchGetByIdQuery, Result<StockBatchDto>>
    {
        private readonly IStockBatchRepository _stockBatchRepository;
        private readonly IMapper _mapper;

        public StockBatchGetByIdQueryHandler(IStockBatchRepository stockBatchRepository, IMapper mapper)
        {
            _stockBatchRepository = stockBatchRepository;
            _mapper = mapper;
        }

        public async Task<Result<StockBatchDto>> Handle(StockBatchGetByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _stockBatchRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<StockBatchDto>.NotFoundResult(request.Id);
            }

            var dto = _mapper.Map<StockBatchDto>(entity);
            return Result<StockBatchDto>.SuccessResult(dto);
        }
    }
}