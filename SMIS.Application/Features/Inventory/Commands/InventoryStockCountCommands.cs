using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Inventory;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Services;
using SMIS.Domain.Entities;
using SMIS.Domain.Enums;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.Inventory.Commands;

public sealed record StockCountStartCommand(StockCountStartDto Dto)
    : IRequest<Result<StockCountSessionDto>>;

public sealed record StockCountCompleteCommand(string Id, StockCountCompleteDto Dto)
    : IRequest<Result<StockCountSessionDto>>;

public sealed record StockCountCancelCommand(string Id)
    : IRequest<Result<StockCountSessionDto>>;

internal sealed class StockCountCommandHandler :
    IRequestHandler<StockCountStartCommand, Result<StockCountSessionDto>>,
    IRequestHandler<StockCountCompleteCommand, Result<StockCountSessionDto>>,
    IRequestHandler<StockCountCancelCommand, Result<StockCountSessionDto>>
{
    private const decimal QuantityTolerance = 0.0001m;
    private readonly IApplicationDbContext _db;
    private readonly IInventoryService _inventory;
    private readonly IIdempotencyService _idempotency;
    private readonly ICurrentUser _currentUser;
    private readonly IUnitOfWork _unitOfWork;

    public StockCountCommandHandler(
        IApplicationDbContext db,
        IInventoryService inventory,
        IIdempotencyService idempotency,
        ICurrentUser currentUser,
        IUnitOfWork unitOfWork
    )
    {
        _db = db;
        _inventory = inventory;
        _idempotency = idempotency;
        _currentUser = currentUser;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<StockCountSessionDto>> Handle(
        StockCountStartCommand request,
        CancellationToken cancellationToken
    )
    {
        var shopId = _currentUser.GetShopId();

        if (string.IsNullOrWhiteSpace(shopId))
            return Result<StockCountSessionDto>.FailureResult(
                "StockCountShopRequired",
                "A shop is required to start a stock count.");

        var batchQuery = _db.StockBatches
            .Where(batch => batch.ShopId == shopId && batch.Status != StatusEnum.Cancelled);

        var requestedBatchIds = request.Dto.StockBatchIds
            .Where(id => !string.IsNullOrWhiteSpace(id))
            .Distinct(StringComparer.Ordinal)
            .ToList();

        if (requestedBatchIds.Count > 0)
            batchQuery = batchQuery.Where(batch => requestedBatchIds.Contains(batch.Id));

        var batches = await batchQuery
            .Include(batch => batch.Product)
            .OrderBy(batch => batch.Product.Name)
            .ThenBy(batch => batch.BatchNumber)
            .ToListAsync(cancellationToken);

        if (requestedBatchIds.Count > 0 && batches.Count != requestedBatchIds.Count)
            return Result<StockCountSessionDto>.FailureResult(
                "StockCountBatchNotFound",
                "One or more requested stock batches do not exist in the selected shop.");

        if (batches.Count == 0)
            return Result<StockCountSessionDto>.FailureResult(
                "NoStockBatches",
                "No stock batches are available to count.");

        var session = StockCountSession.Create(shopId, DateTimeService.NowUtc, request.Dto.Notes);
        foreach (var batch in batches)
        {
            session.Lines.Add(StockCountLine.Create(
                session.Id,
                batch.Id,
                batch.RemainingQuantityBase));
        }

        await _db.StockCountSessions.AddAsync(session, cancellationToken);
        await _unitOfWork.SaveChanges(cancellationToken);

        return Result<StockCountSessionDto>.SuccessResult(StockCountDtoMapper.ToDto(session, batches));
    }

    public async Task<Result<StockCountSessionDto>> Handle(
        StockCountCompleteCommand request,
        CancellationToken cancellationToken
    )
    {
        var session = await _db.StockCountSessions
            .Include(item => item.Lines)
            .ThenInclude(line => line.StockBatch)
            .ThenInclude(batch => batch.Product)
            .FirstOrDefaultAsync(item => item.Id == request.Id, cancellationToken);

        if (session is null)
            return Result<StockCountSessionDto>.NotFoundResult(request.Id);

        if (session.Status != StockCountStatus.Draft)
            return Result<StockCountSessionDto>.FailureResult(
                "StockCountNotDraft",
                "Only a draft stock count can be completed.");

        var reservation = await _idempotency.ReserveAsync(
            $"stock-count:complete:{session.Id}",
            request.Dto.IdempotencyKey,
            cancellationToken);
        if (!reservation.Success)
            return Failure(reservation);

        var counts = request.Dto.Counts;
        if (counts.Count != session.Lines.Count ||
            counts.Select(count => count.StockBatchId).Distinct(StringComparer.Ordinal).Count() != counts.Count)
            return Result<StockCountSessionDto>.FailureResult(
                "IncompleteStockCount",
                "Every stock-count batch must be supplied exactly once.");

        var countByBatch = counts.ToDictionary(count => count.StockBatchId, StringComparer.Ordinal);
        if (session.Lines.Any(line => !countByBatch.ContainsKey(line.StockBatchId)))
            return Result<StockCountSessionDto>.FailureResult(
                "IncompleteStockCount",
                "The submitted count set does not match the stock-count snapshot.");

        var occurredAtUtc = request.Dto.OccurredAtUtc ?? DateTimeService.NowUtc;
        var operationId = Guid.NewGuid().ToString();

        foreach (var line in session.Lines)
        {
            var currentBalance = line.StockBatch.RemainingQuantityBase;
            if (Math.Abs(currentBalance - line.ExpectedQuantityBase) > QuantityTolerance)
                return Result<StockCountSessionDto>.FailureResult(
                    "StockChangedDuringCount",
                    $"Stock batch '{line.StockBatchId}' changed after the count started. Restart or recount before posting adjustments.");

            var submitted = countByBatch[line.StockBatchId];
            line.RecordCount(submitted.CountedQuantityBase);
            if (Math.Abs(line.DifferenceBase) <= QuantityTolerance)
                continue;

            var baseProductUnit = await _db.ProductUnits
                .FirstOrDefaultAsync(unit =>
                        unit.ProductId == line.StockBatch.ProductId &&
                        unit.UnitOfMeasureId == line.StockBatch.Product.BaseUnitId,
                    cancellationToken);

            if (baseProductUnit is null)
                return Result<StockCountSessionDto>.FailureResult(
                    "BaseProductUnitMissing",
                    "The product base-unit conversion required for stock-count adjustment is missing.");

            var inventoryResult = await _inventory.PostMovementAsync(
                new InventoryMovementRequest(
                    line.StockBatchId,
                    baseProductUnit.Id,
                    Math.Abs(line.DifferenceBase),
                    line.DifferenceBase > 0
                        ? StockMovementDirection.In
                        : StockMovementDirection.Out,
                    StockMovementReason.Adjustment,
                    occurredAtUtc,
                    nameof(StockCountLine),
                    line.Id,
                    operationId),
                cancellationToken);

            if (!inventoryResult.Success)
                return Failure(inventoryResult);
        }

        session.Complete(occurredAtUtc);
        await _unitOfWork.SaveChanges(cancellationToken);

        return Result<StockCountSessionDto>.SuccessResult(
            StockCountDtoMapper.ToDto(session, session.Lines.Select(line => line.StockBatch).ToList()));
    }

    public async Task<Result<StockCountSessionDto>> Handle(
        StockCountCancelCommand request,
        CancellationToken cancellationToken
    )
    {
        var session = await _db.StockCountSessions
            .Include(item => item.Lines)
            .ThenInclude(line => line.StockBatch)
            .ThenInclude(batch => batch.Product)
            .FirstOrDefaultAsync(item => item.Id == request.Id, cancellationToken);

        if (session is null)
            return Result<StockCountSessionDto>.NotFoundResult(request.Id);

        session.Cancel();
        await _unitOfWork.SaveChanges(cancellationToken);

        return Result<StockCountSessionDto>.SuccessResult(
            StockCountDtoMapper.ToDto(
                session,
                session.Lines.Select(line => line.StockBatch).ToList()));
    }

    private static Result<StockCountSessionDto> Failure<T>(
        Result<T> source
    ) => new()
    {
        Success = false,
        Message = source.Message,
        Errors = source.Errors
    };
}

internal static class StockCountDtoMapper
{
    public static StockCountSessionDto ToDto(
        StockCountSession session,
        IReadOnlyCollection<StockBatch> batches
    )
    {
        var batchById = batches.ToDictionary(batch => batch.Id, StringComparer.Ordinal);
        return new StockCountSessionDto
        {
            Id = session.Id,
            ShopId = session.ShopId,
            StartedAtUtc = session.StartedAtUtc,
            CompletedAtUtc = session.CompletedAtUtc,
            Status = session.Status,
            Notes = session.Notes,
            Lines = session.Lines.Select(line =>
            {
                batchById.TryGetValue(line.StockBatchId, out var batch);
                return new StockCountLineDto
                {
                    Id = line.Id,
                    StockBatchId = line.StockBatchId,
                    ProductId = batch?.ProductId ?? string.Empty,
                    ProductName = batch?.Product?.Name ?? string.Empty,
                    BatchNumber = batch?.BatchNumber,
                    ExpectedQuantityBase = line.ExpectedQuantityBase,
                    CountedQuantityBase = line.CountedQuantityBase,
                    DifferenceBase = line.DifferenceBase
                };
            }).ToList()
        };
    }
}