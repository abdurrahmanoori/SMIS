using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.StockBatches;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Products;
using SMIS.Application.Repositories.StockBatches;
using SMIS.Application.Repositories.UnitOfMeasures;

namespace SMIS.Application.Features.StockBatches.Commands
{
    public record StockBatchUpdateCommand(string Id, StockBatchCreateDto StockBatchCreateDto) : IRequest<Result<StockBatchDto>>;

    internal sealed class StockBatchUpdateCommandHandler : IRequestHandler<StockBatchUpdateCommand, Result<StockBatchDto>>
    {
        private readonly IStockBatchRepository _stockBatchRepository;
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public StockBatchUpdateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IStockBatchRepository stockBatchRepository, IProductRepository productRepository, IUnitOfMeasureRepository unitOfMeasureRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _stockBatchRepository = stockBatchRepository;
            _productRepository = productRepository;
            _unitOfMeasureRepository = unitOfMeasureRepository;
        }

        public async Task<Result<StockBatchDto>> Handle(StockBatchUpdateCommand request, CancellationToken cancellationToken)
        {
            var entity = await _stockBatchRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<StockBatchDto>.NotFoundResult(nameof(StockBatchDto.Id));
            }
            
            // Update existing entity using domain methods
            entity.SetProductId(request.StockBatchCreateDto.ProductId);
            entity.SetUnitId(request.StockBatchCreateDto.UnitId);
            entity.SetQuantity(request.StockBatchCreateDto.Quantity);
            entity.SetPurchasePrice(request.StockBatchCreateDto.PurchasePrice);
            if (request.StockBatchCreateDto.ReceivedDate.HasValue)
                entity.SetReceivedDate(request.StockBatchCreateDto.ReceivedDate.Value);
            entity.SetBatchNumber(request.StockBatchCreateDto.BatchNumber);
            entity.SetExpirationDate(request.StockBatchCreateDto.ExpirationDate);
            
            // Update name fields
            var product = await _productRepository.GetByIdAsync(request.StockBatchCreateDto.ProductId);
            entity.ProductName = product?.Name;
            
            var unit = await _unitOfMeasureRepository.GetByIdAsync(request.StockBatchCreateDto.UnitId);
            entity.UnitName = unit?.Name;
            
            switch (request.StockBatchCreateDto.Status)
            {
                case Domain.Enums.StatusEnum.Active:
                    entity.Activate();
                    break;
                case Domain.Enums.StatusEnum.Inactive:
                    entity.Deactivate();
                    break;
                case Domain.Enums.StatusEnum.Completed:
                    entity.MarkAsCompleted();
                    break;
                case Domain.Enums.StatusEnum.Cancelled:
                    entity.MarkAsCancelled();
                    break;
            }
            
            await _unitOfWork.SaveChanges(cancellationToken);

            var dto = _mapper.Map<StockBatchDto>(entity);
            return Result<StockBatchDto>.SuccessResult(dto);
        }
    }
}