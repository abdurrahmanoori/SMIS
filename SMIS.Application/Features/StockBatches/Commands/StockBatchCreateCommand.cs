using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.StockBatches;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.ProductUnits;
using SMIS.Application.Repositories.StockBatches;
using SMIS.Application.Repositories.StockMovements;
using SMIS.Domain.Entities;
using SMIS.Domain.Enums;

namespace SMIS.Application.Features.StockBatches.Commands
{
    public record StockBatchCreateCommand(StockBatchCreateDto StockBatchCreateDto) : IRequest<Result<StockBatchDto>>;

    internal sealed class
        StockBatchCreateCommandHandler : IRequestHandler<StockBatchCreateCommand, Result<StockBatchDto>>
    {
        private readonly IStockBatchRepository _stockBatchRepository;
        private readonly IStockMovementRepository _stockMovementRepository;
        private readonly IProductUnitRepository _productUnitRepository;
        private readonly ICurrentUser _currentUser;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public StockBatchCreateCommandHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IStockBatchRepository stockBatchRepository,
            IStockMovementRepository stockMovementRepository,
            IProductUnitRepository productUnitRepository,
            ICurrentUser currentUser
        )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _stockBatchRepository = stockBatchRepository;
            _stockMovementRepository = stockMovementRepository;
            _productUnitRepository = productUnitRepository;
            _currentUser = currentUser;
        }

        public async Task<Result<StockBatchDto>> Handle(
            StockBatchCreateCommand request,
            CancellationToken cancellationToken
        )
        {
            // Receiving inventory is one business operation: create the batch and
            // create its opening PurchaseReceipt ledger entry in the same transaction.
            var dto = request.StockBatchCreateDto;
            var productUnit = await _productUnitRepository.GetFirstOrDefaultAsync(
                unit => unit.Id == dto.ReceivedProductUnitId,
                includeProperties: "Product");

            if (productUnit is null)
                return Result<StockBatchDto>.FailureResult(
                    "ProductUnitNotFound",
                    "The selected product unit does not exist.");

            if (productUnit.ProductId != dto.ProductId)
                return Result<StockBatchDto>.FailureResult(
                    "ProductUnitMismatch",
                    "The selected product unit does not belong to the selected product.");

            var shopId = _currentUser.GetShopId();
            if (!_currentUser.IsSuperAdmin() && productUnit.Product.ShopId != shopId)
                return Result<StockBatchDto>.FailureResult(
                    "Forbidden",
                    "The selected product belongs to another shop.");

            shopId = productUnit.Product.ShopId;
            var occurredAt = dto.ReceivedAtUtc ?? DateTime.UtcNow;
            var entity = StockBatch.Create(
                shopId,
                dto.ProductId,
                dto.ReceivedProductUnitId,
                dto.ReceivedQuantity,
                productUnit.BaseUnitQuantity,
                dto.UnitCostBase,
                occurredAt,
                dto.BatchNumber,
                dto.ExpirationDate);

            var receiptMovement = StockMovement.Create(
                shopId,
                entity.Id,
                productUnit.Id,
                dto.ReceivedQuantity,
                entity.ReceivedQuantityBase,
                StockMovementDirection.In,
                StockMovementReason.PurchaseReceipt,
                occurredAt,
                "StockBatch",
                entity.Id);

            await _unitOfWork.StartTransactionAsync(cancellationToken);
            try
            {
                await _stockBatchRepository.AddAsync(entity);
                await _stockMovementRepository.AddAsync(receiptMovement);
                await _unitOfWork.SaveChanges(cancellationToken);
                await _unitOfWork.CommitTransactionAsync(cancellationToken);
            }
            catch
            {
                await _unitOfWork.RollbackTransactionAsync(cancellationToken);
                throw;
            }

            return Result<StockBatchDto>.SuccessResult(_mapper.Map<StockBatchDto>(entity));
        }
    }
}
// Convert the received quantity once into the product's canonical stock unit.
// The opening movement mirrors the initial batch balance. If either save
// fails, the transaction is rolled back so batch and ledger cannot diverge.