using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.StockMovements;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.ProductUnits;
using SMIS.Application.Repositories.StockBatches;
using SMIS.Application.Repositories.StockMovements;
using SMIS.Domain.Entities;
using SMIS.Domain.Enums;

namespace SMIS.Application.Features.StockMovements.Commands;

public record StockMovementCreateCommand(StockMovementCreateDto Dto) : IRequest<Result<StockMovementDto>>;

internal sealed class StockMovementCreateCommandHandler
    : IRequestHandler<StockMovementCreateCommand, Result<StockMovementDto>>
{
    private readonly IStockMovementRepository _movements;
    private readonly IStockBatchRepository _batches;
    private readonly IProductUnitRepository _productUnits;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICurrentUser _currentUser;
    private readonly IMapper _mapper;

    public StockMovementCreateCommandHandler(
        IStockMovementRepository movements,
        IStockBatchRepository batches,
        IProductUnitRepository productUnits,
        IUnitOfWork unitOfWork,
        ICurrentUser currentUser,
        IMapper mapper)
    {
        _movements = movements;
        _batches = batches;
        _productUnits = productUnits;
        _unitOfWork = unitOfWork;
        _currentUser = currentUser;
        _mapper = mapper;
    }

    public async Task<Result<StockMovementDto>> Handle(
        StockMovementCreateCommand request,
        CancellationToken cancellationToken)
    {
        var dto = request.Dto;
        if (dto.Reason == StockMovementReason.PurchaseReceipt)
            return Result<StockMovementDto>.FailureResult(
                "PurchaseReceiptUsesBatchCreation",
                "Purchase receipts must be posted by creating a stock batch.");

        var batch = await _batches.GetByIdAsync(dto.StockBatchId);
        if (batch is null)
            return Result<StockMovementDto>.NotFoundResult(dto.StockBatchId);

        if (!_currentUser.IsSuperAdmin() && batch.ShopId != _currentUser.GetShopId())
            return Result<StockMovementDto>.FailureResult("Forbidden", "The stock batch belongs to another shop.");

        var productUnit = await _productUnits.GetByIdAsync(dto.ProductUnitId);
        if (productUnit is null)
            return Result<StockMovementDto>.FailureResult("ProductUnitNotFound", "The selected product unit does not exist.");
        if (productUnit.ProductId != batch.ProductId)
            return Result<StockMovementDto>.FailureResult(
                "ProductUnitMismatch",
                "The selected product unit does not belong to the batch product.");

        var quantityBase = dto.QuantityEntered * productUnit.BaseUnitQuantity;
        var movement = StockMovement.Create(
            batch.ShopId,
            batch.Id,
            productUnit.Id,
            dto.QuantityEntered,
            quantityBase,
            dto.Direction,
            dto.Reason,
            dto.OccurredAtUtc ?? DateTime.UtcNow,
            dto.ReferenceType,
            dto.ReferenceId);

        await _unitOfWork.StartTransactionAsync(cancellationToken);
        try
        {
            if (dto.Direction == StockMovementDirection.Out)
                batch.ApplyOutMovement(quantityBase);
            else
                batch.ApplyInMovement(quantityBase);

            await _movements.AddAsync(movement);
            await _unitOfWork.SaveChanges(cancellationToken);
            await _unitOfWork.CommitTransactionAsync(cancellationToken);
        }
        catch
        {
            await _unitOfWork.RollbackTransactionAsync(cancellationToken);
            throw;
        }

        return Result<StockMovementDto>.SuccessResult(_mapper.Map<StockMovementDto>(movement));
    }
}
