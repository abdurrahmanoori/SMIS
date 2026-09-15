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

public record StockMovementFifoIssueCommand(FifoStockIssueDto Dto)
    : IRequest<Result<List<StockMovementDto>>>;

internal sealed class StockMovementFifoIssueCommandHandler
    : IRequestHandler<StockMovementFifoIssueCommand, Result<List<StockMovementDto>>>
{
    private readonly IStockMovementRepository _movements;
    private readonly IStockBatchRepository _batches;
    private readonly IProductUnitRepository _productUnits;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICurrentUser _currentUser;
    private readonly IMapper _mapper;

    public StockMovementFifoIssueCommandHandler(
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

    public async Task<Result<List<StockMovementDto>>> Handle(
        StockMovementFifoIssueCommand request,
        CancellationToken cancellationToken)
    {
        var dto = request.Dto;
        var productUnit = await _productUnits.GetFirstOrDefaultAsync(
            unit => unit.Id == dto.ProductUnitId,
            includeProperties: "Product");
        if (productUnit is null || productUnit.ProductId != dto.ProductId)
            return Result<List<StockMovementDto>>.FailureResult(
                "ProductUnitMismatch",
                "The selected product unit does not belong to the selected product.");

        var shopId = productUnit.Product.ShopId;
        if (!_currentUser.IsSuperAdmin() && shopId != _currentUser.GetShopId())
            return Result<List<StockMovementDto>>.FailureResult("Forbidden", "The selected product belongs to another shop.");

        var totalBase = dto.QuantityEntered * productUnit.BaseUnitQuantity;
        var batches = await _batches.GetAvailableFifoAsync(shopId, dto.ProductId, cancellationToken);
        if (batches.Sum(batch => batch.RemainingQuantityBase) < totalBase)
            return Result<List<StockMovementDto>>.FailureResult(
                "InsufficientStock",
                "Available FIFO stock is lower than the requested quantity.");

        var remainingBase = totalBase;
        var occurredAt = dto.OccurredAtUtc ?? DateTime.UtcNow;
        var created = new List<StockMovement>();

        await _unitOfWork.StartTransactionAsync(cancellationToken);
        try
        {
            foreach (var batch in batches)
            {
                if (remainingBase <= 0) break;

                var allocatedBase = Math.Min(batch.RemainingQuantityBase, remainingBase);
                var allocatedEntered = allocatedBase / productUnit.BaseUnitQuantity;
                batch.ApplyOutMovement(allocatedBase);

                var movement = StockMovement.Create(
                    shopId,
                    batch.Id,
                    productUnit.Id,
                    allocatedEntered,
                    allocatedBase,
                    StockMovementDirection.Out,
                    dto.Reason,
                    occurredAt,
                    dto.ReferenceType,
                    dto.ReferenceId);

                await _movements.AddAsync(movement);
                created.Add(movement);
                remainingBase -= allocatedBase;
            }

            await _unitOfWork.SaveChanges(cancellationToken);
            await _unitOfWork.CommitTransactionAsync(cancellationToken);
        }
        catch
        {
            await _unitOfWork.RollbackTransactionAsync(cancellationToken);
            throw;
        }

        return Result<List<StockMovementDto>>.SuccessResult(_mapper.Map<List<StockMovementDto>>(created));
    }
}
