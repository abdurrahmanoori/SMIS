using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Sales;
using SMIS.Application.DTO.StockMovements;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Services;
using SMIS.Application.Identity.IServices;
using SMIS.Domain.Entities;
using SMIS.Domain.Enums;

namespace SMIS.Application.Features.Sales.Commands;

public sealed record SaleReturnCommand(string SaleId, SaleReturnDto Dto)
    : IRequest<Result<SaleReturnResultDto>>;

public sealed record SaleVoidCommand(string SaleId, SaleVoidDto Dto)
    : IRequest<Result<SaleReturnResultDto>>;

internal sealed class SaleReturnCommandHandler :
    IRequestHandler<SaleReturnCommand, Result<SaleReturnResultDto>>,
    IRequestHandler<SaleVoidCommand, Result<SaleReturnResultDto>>
{
    private const decimal QuantityTolerance = 0.0001m;
    private readonly IApplicationDbContext _db;
    private readonly IInventoryService _inventory;
    private readonly IIdempotencyService _idempotency;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly ICurrentUser _currentUser;

    public SaleReturnCommandHandler(
        IApplicationDbContext db,
        IInventoryService inventory,
        IIdempotencyService idempotency,
        IUnitOfWork unitOfWork,
        IMapper mapper,
        ICurrentUser currentUser)
    {
        _db = db;
        _inventory = inventory;
        _idempotency = idempotency;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _currentUser = currentUser;
    }

    public Task<Result<SaleReturnResultDto>> Handle(
        SaleReturnCommand request,
        CancellationToken cancellationToken) =>
        ExecuteAsync(
            request.SaleId,
            request.Dto.Lines,
            request.Dto.OccurredAtUtc ?? DateTime.UtcNow,
            request.Dto.IdempotencyKey,
            isVoid: false,
            cancellationToken);

    public Task<Result<SaleReturnResultDto>> Handle(
        SaleVoidCommand request,
        CancellationToken cancellationToken) =>
        ExecuteAsync(
            request.SaleId,
            requestedLines: null,
            request.Dto.OccurredAtUtc ?? DateTime.UtcNow,
            request.Dto.IdempotencyKey,
            isVoid: true,
            cancellationToken);

    private async Task<Result<SaleReturnResultDto>> ExecuteAsync(
        string saleId,
        IReadOnlyCollection<SaleReturnLineDto>? requestedLines,
        DateTime occurredAtUtc,
        string? idempotencyKey,
        bool isVoid,
        CancellationToken cancellationToken)
    {
        var sale = await _db.Sales
            .Include(item => item.Lines)
                .ThenInclude(line => line.ProductUnit)
            .Include(item => item.Receivable)
                .ThenInclude(receivable => receivable!.Payments)
            .FirstOrDefaultAsync(item => item.Id == saleId, cancellationToken);

        if (sale is null)
            return Result<SaleReturnResultDto>.NotFoundResult(saleId);

        if (!string.Equals(sale.ShopId, _currentUser.GetShopId(), StringComparison.Ordinal))
            return Result<SaleReturnResultDto>.NotFoundResult(saleId);

        if (sale.Status == SaleStatus.Voided)
            return Result<SaleReturnResultDto>.FailureResult(
                "SaleAlreadyVoided",
                "The sale has already been voided.");

        var idempotency = await _idempotency.ReserveAsync(
            isVoid ? $"sale-void:{sale.Id}" : $"sale-return:{sale.Id}",
            idempotencyKey,
            cancellationToken);
        if (!idempotency.Success)
            return Failure(idempotency);

        var linesToReturn = isVoid
            ? sale.Lines
                .Where(line => line.ReturnableQuantityEntered > 0)
                .Select(line => new SaleReturnLineDto
                {
                    SaleLineId = line.Id,
                    QuantityEntered = line.ReturnableQuantityEntered
                })
                .ToList()
            : requestedLines?.ToList() ?? [];

        if (linesToReturn.Count == 0)
            return Result<SaleReturnResultDto>.FailureResult(
                "NothingToReturn",
                "The sale has no remaining quantity to return.");

        if (linesToReturn.Select(line => line.SaleLineId).Distinct(StringComparer.Ordinal).Count() != linesToReturn.Count)
            return Result<SaleReturnResultDto>.FailureResult(
                "DuplicateSaleReturnLine",
                "A sale line can appear only once in a return request.");

        var operationId = Guid.NewGuid().ToString();
        var createdMovements = new List<StockMovement>();
        long returnedAmount = 0;

        foreach (var requestedLine in linesToReturn)
        {
            var line = sale.Lines.FirstOrDefault(item => item.Id == requestedLine.SaleLineId);
            if (line is null)
                return Result<SaleReturnResultDto>.FailureResult(
                    "SaleLineNotFound",
                    "A requested return line does not belong to this sale.");

            if (requestedLine.QuantityEntered <= 0 ||
                requestedLine.QuantityEntered > line.ReturnableQuantityEntered)
                return Result<SaleReturnResultDto>.FailureResult(
                    "InvalidReturnQuantity",
                    "Return quantity must be positive and cannot exceed the remaining returnable quantity.");

            var originalMovements = await _db.StockMovements
                .Where(movement =>
                    movement.ReferenceType == nameof(SaleLine) &&
                    movement.ReferenceId == line.Id &&
                    movement.Reason == StockMovementReason.Sale &&
                    movement.Direction == StockMovementDirection.Out)
                .OrderBy(movement => movement.OccurredAtUtc)
                .ThenBy(movement => movement.Id)
                .ToListAsync(cancellationToken);

            if (originalMovements.Count == 0)
                return Result<SaleReturnResultDto>.FailureResult(
                    "SaleInventoryHistoryMissing",
                    "The original sale inventory allocation could not be found.");

            var priorReturns = await _db.StockMovements
                .Where(movement =>
                    movement.ReferenceType == nameof(SaleLine) &&
                    movement.ReferenceId == line.Id &&
                    movement.Reason == StockMovementReason.CustomerReturn &&
                    movement.Direction == StockMovementDirection.In)
                .ToListAsync(cancellationToken);

            var remainingBase = requestedLine.QuantityEntered * line.ProductUnit.BaseUnitQuantity;
            foreach (var originalMovement in originalMovements)
            {
                if (remainingBase <= QuantityTolerance) break;

                var alreadyReturnedBase = priorReturns
                    .Where(returnMovement => returnMovement.StockBatchId == originalMovement.StockBatchId)
                    .Sum(returnMovement => returnMovement.QuantityBase);
                var returnableFromBatch = originalMovement.QuantityBase - alreadyReturnedBase;
                if (returnableFromBatch <= QuantityTolerance) continue;

                var allocatedBase = Math.Min(returnableFromBatch, remainingBase);
                var allocatedEntered = allocatedBase / line.ProductUnit.BaseUnitQuantity;
                var inventoryResult = await _inventory.PostMovementAsync(
                    new InventoryMovementRequest(
                        originalMovement.StockBatchId,
                        line.ProductUnitId,
                        allocatedEntered,
                        StockMovementDirection.In,
                        StockMovementReason.CustomerReturn,
                        occurredAtUtc,
                        nameof(SaleLine),
                        line.Id,
                        operationId),
                    cancellationToken);

                if (!inventoryResult.Success)
                    return Failure(inventoryResult);

                createdMovements.Add(inventoryResult.Response!);
                remainingBase -= allocatedBase;
            }

            if (remainingBase > QuantityTolerance)
                return Result<SaleReturnResultDto>.FailureResult(
                    "ReturnAllocationMismatch",
                    "The requested return quantity exceeds the quantity that can be traced to original sale batches.");

            returnedAmount = checked(returnedAmount + line.RegisterReturn(requestedLine.QuantityEntered));
        }

        var allLinesReturned = sale.Lines.All(line => line.ReturnableQuantityEntered <= QuantityTolerance);
        sale.RegisterReturn(returnedAmount, allLinesReturned, isVoid);

        long refundDue = sale.PaymentType == SalePaymentType.Cash ? returnedAmount : 0;
        if (sale.Receivable is not null && returnedAmount > 0)
        {
            var overpaidBefore = sale.Receivable.OverpaidAmount;
            sale.Receivable.ApplyCredit(returnedAmount);
            refundDue = Math.Max(0, sale.Receivable.OverpaidAmount - overpaidBefore);
        }

        await _unitOfWork.SaveChanges(cancellationToken);

        return Result<SaleReturnResultDto>.SuccessResult(new SaleReturnResultDto
        {
            SaleId = sale.Id,
            Status = sale.Status,
            ReturnedAmountMinor = returnedAmount,
            RefundDueMinor = refundDue,
            ReceivableRemainingAmount = sale.Receivable?.RemainingAmount,
            InventoryMovements = _mapper.Map<List<StockMovementDto>>(createdMovements)
        });
    }

    private static Result<SaleReturnResultDto> Failure<T>(Result<T> source) => new()
    {
        Success = false,
        Message = source.Message,
        Errors = source.Errors
    };
}
