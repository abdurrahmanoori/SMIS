using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.StockBatches;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.StockBatches;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.StockBatches.Commands
{
    public record StockBatchCreateCommand(StockBatchCreateDto StockBatchCreateDto) : IRequest<Result<StockBatchDto>>;

    internal sealed class StockBatchCreateCommandHandler : IRequestHandler<StockBatchCreateCommand, Result<StockBatchDto>>
    {
        private readonly IStockBatchRepository _stockBatchRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public StockBatchCreateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IStockBatchRepository stockBatchRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _stockBatchRepository = stockBatchRepository;
        }

        public async Task<Result<StockBatchDto>> Handle(StockBatchCreateCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StockBatch>(request.StockBatchCreateDto);
            
            await _stockBatchRepository.AddAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);

            return Result<StockBatchDto>.SuccessResult(_mapper.Map<StockBatchDto>(entity));
        }
    }
}