using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Inventory;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Services;
using SMIS.Domain.Entities;
using SMIS.Domain.Enums;

namespace SMIS.Application.Features.Inventory.Queries;

public sealed record InventoryCurrentStockQuery(
    decimal? LowStockThresholdBase = null,
    bool OnlyLowStock = false,
    bool IncludePresentationUnits = true
)
    : IRequest<Result<List<CurrentStockReportDto>>>;

// Current stock is calculated from cached batch balances because that is the fast
// operational view. Reconciliation below exists specifically to prove those cached
// balances still agree with the immutable movement ledger.

internal sealed class InventoryCurrentStockQueryHandler
    : IRequestHandler<InventoryCurrentStockQuery, Result<List<CurrentStockReportDto>>>
{
    private readonly IApplicationDbContext _db;
    private readonly ICurrentUser _currentUser;

    public InventoryCurrentStockQueryHandler(
        IApplicationDbContext db,
        ICurrentUser currentUser
    )
    {
        _db = db;
        _currentUser = currentUser;
    }

    public async Task<Result<List<CurrentStockReportDto>>> Handle(
        InventoryCurrentStockQuery request,
        CancellationToken cancellationToken
    )
    {
        if (request.LowStockThresholdBase < 0)
            return Result<List<CurrentStockReportDto>>.FailureResult(
                "InvalidLowStockThreshold",
                "Low-stock threshold cannot be negative.");

        var products = await InventoryReportScope.Products(_db, _currentUser)
            .AsNoTracking()
            .Select(product => new ProductStockProjection(
                product.Id,
                product.Name,
                product.BaseUnitId,
                product.BaseUnitName ?? product.UnitOfMeasure.Name,
                product.ReorderPointBase,
                product.ReorderQuantityBase))
            .ToListAsync(cancellationToken);

        var productIds = products.Select(product => product.ProductId).ToList();
        var batches = productIds.Count == 0
            ? new List<BatchBalanceProjection>()
            : await InventoryReportScope.Batches(_db, _currentUser)
                .AsNoTracking()
                .Where(batch => productIds.Contains(batch.ProductId) && batch.RemainingQuantityBase > 0)
                .Select(batch => new BatchBalanceProjection(
                    batch.ProductId,
                    batch.RemainingQuantityBase,
                    batch.UnitCostBase,
                    batch.Status,
                    batch.ExpirationDate))
                .ToListAsync(cancellationToken);

        var presentationUnits = request.IncludePresentationUnits && productIds.Count > 0
            ? await _db.ProductUnits.AsNoTracking()
                .Where(unit => productIds.Contains(unit.ProductId))
                .Select(unit => new ProductUnitProjection(
                    unit.ProductId,
                    unit.Id,
                    unit.UnitOfMeasureId,
                    unit.UnitName ?? unit.UnitOfMeasure.Name,
                    unit.BaseUnitQuantity))
                .ToListAsync(cancellationToken)
            : new List<ProductUnitProjection>();

        var unitsByProduct = presentationUnits
            .GroupBy(unit => unit.ProductId)
            .ToDictionary(group => group.Key, group => (IReadOnlyList<ProductUnitProjection>)group.ToList());

        var batchesByProduct = batches
            .GroupBy(batch => batch.ProductId)
            .ToDictionary(group => group.Key, group => group.ToList());

        var rows = products
            .Select(product =>
            {
                batchesByProduct.TryGetValue(product.ProductId, out var productBatches);
                productBatches ??= new List<BatchBalanceProjection>();

                var quantityBase = productBatches.Sum(batch => batch.RemainingQuantityBase);
                var now = DateTime.UtcNow;
                var availableQuantityBase = productBatches
                    .Where(batch =>
                        batch.Status == StatusEnum.Active &&
                        (!batch.ExpirationDate.HasValue || batch.ExpirationDate.Value > now))
                    .Sum(batch => batch.RemainingQuantityBase);

                // Valuation is deliberately performed in normalized base units. A box,
                // carton, or bottle conversion is presentation information and must not
                // influence the stored inventory cost calculation.
                var value = productBatches.Sum(batch => batch.RemainingQuantityBase * batch.UnitCostBase);
                var effectiveThreshold = request.LowStockThresholdBase ?? product.ReorderPointBase;
                var isLowStock = availableQuantityBase <= effectiveThreshold;

                unitsByProduct.TryGetValue(product.ProductId, out var productUnits);
                return new CurrentStockReportDto
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    BaseUnitId = product.BaseUnitId,
                    BaseUnitName = product.BaseUnitName,
                    QuantityBase = quantityBase,
                    AvailableQuantityBase = availableQuantityBase,
                    UnavailableQuantityBase = quantityBase - availableQuantityBase,
                    BatchCount = productBatches.Count,
                    InventoryValueMinor = InventoryReportMath.ToMinorUnits(value),
                    ReorderPointBase = product.ReorderPointBase,
                    ReorderQuantityBase = product.ReorderQuantityBase,
                    IsLowStock = isLowStock,
                    PresentationUnits = InventoryReportPresentation.Convert(
                        quantityBase,
                        productUnits ?? Array.Empty<ProductUnitProjection>())
                };
            })
            .Where(row => !request.OnlyLowStock || row.IsLowStock)
            .OrderBy(row => row.ProductName)
            .ToList();

        return Result<List<CurrentStockReportDto>>.SuccessResult(rows);
    }
}

public sealed record InventoryExpirationReportQuery(int DaysAhead = 30, bool OnlyExpired = false)
    : IRequest<Result<List<ExpiringStockReportDto>>>;

internal sealed class InventoryExpirationReportQueryHandler
    : IRequestHandler<InventoryExpirationReportQuery, Result<List<ExpiringStockReportDto>>>
{
    private readonly IApplicationDbContext _db;
    private readonly ICurrentUser _currentUser;

    public InventoryExpirationReportQueryHandler(
        IApplicationDbContext db,
        ICurrentUser currentUser
    )
    {
        _db = db;
        _currentUser = currentUser;
    }

    public async Task<Result<List<ExpiringStockReportDto>>> Handle(
        InventoryExpirationReportQuery request,
        CancellationToken cancellationToken
    )
    {
        if (request.DaysAhead < 0)
            return Result<List<ExpiringStockReportDto>>.FailureResult(
                "InvalidExpirationWindow",
                "DaysAhead cannot be negative.");

        var now = DateTime.UtcNow;
        var through = now.AddDays(request.DaysAhead);
        var query = InventoryReportScope.Batches(_db, _currentUser)
            .AsNoTracking()
            .Where(batch => batch.RemainingQuantityBase > 0 && batch.ExpirationDate.HasValue);

        query = request.OnlyExpired
            ? query.Where(batch => batch.ExpirationDate!.Value < now)
            : query.Where(batch =>
                batch.ExpirationDate!.Value >= now &&
                batch.ExpirationDate.Value <= through);

        var raw = await query
            .OrderBy(batch => batch.ExpirationDate)
            .Select(batch => new
            {
                batch.Id,
                batch.ProductId,
                ProductName = batch.Product.Name,
                batch.BatchNumber,
                batch.RemainingQuantityBase,
                BaseUnitId = batch.Product.BaseUnitId,
                BaseUnitName = batch.Product.BaseUnitName ?? batch.Product.UnitOfMeasure.Name,
                ExpirationDate = batch.ExpirationDate!.Value,
                batch.UnitCostBase
            })
            .ToListAsync(cancellationToken);

        var rows = raw.Select(batch => new ExpiringStockReportDto
        {
            StockBatchId = batch.Id,
            ProductId = batch.ProductId,
            ProductName = batch.ProductName,
            BatchNumber = batch.BatchNumber,
            RemainingQuantityBase = batch.RemainingQuantityBase,
            BaseUnitId = batch.BaseUnitId,
            BaseUnitName = batch.BaseUnitName,
            ExpirationDate = batch.ExpirationDate,
            IsExpired = batch.ExpirationDate < now,
            DaysUntilExpiration = (int)Math.Floor((batch.ExpirationDate - now).TotalDays),
            UnitCostBase = batch.UnitCostBase,
            InventoryValueMinor = InventoryReportMath.ToMinorUnits(
                batch.RemainingQuantityBase * batch.UnitCostBase)
        }).ToList();

        return Result<List<ExpiringStockReportDto>>.SuccessResult(rows);
    }
}

public sealed record InventoryValuationQuery : IRequest<Result<InventoryValuationReportDto>>;

internal sealed class InventoryValuationQueryHandler
    : IRequestHandler<InventoryValuationQuery, Result<InventoryValuationReportDto>>
{
    private readonly IApplicationDbContext _db;
    private readonly ICurrentUser _currentUser;

    public InventoryValuationQueryHandler(
        IApplicationDbContext db,
        ICurrentUser currentUser
    )
    {
        _db = db;
        _currentUser = currentUser;
    }

    public async Task<Result<InventoryValuationReportDto>> Handle(
        InventoryValuationQuery request,
        CancellationToken cancellationToken
    )
    {
        var batches = await InventoryReportScope.Batches(_db, _currentUser)
            .AsNoTracking()
            .Where(batch => batch.RemainingQuantityBase > 0)
            .Select(batch => new
            {
                batch.ProductId,
                ProductName = batch.Product.Name,
                batch.RemainingQuantityBase,
                batch.UnitCostBase
            })
            .ToListAsync(cancellationToken);

        var products = batches
            .GroupBy(batch => new { batch.ProductId, batch.ProductName })
            .Select(group => new InventoryValuationItemDto
            {
                ProductId = group.Key.ProductId,
                ProductName = group.Key.ProductName,
                QuantityBase = group.Sum(batch => batch.RemainingQuantityBase),
                InventoryValueMinor = InventoryReportMath.ToMinorUnits(
                    group.Sum(batch => batch.RemainingQuantityBase * batch.UnitCostBase))
            })
            .OrderBy(item => item.ProductName)
            .ToList();

        return Result<InventoryValuationReportDto>.SuccessResult(new InventoryValuationReportDto
        {
            Products = products,
            TotalInventoryValueMinor = products.Sum(item => item.InventoryValueMinor)
        });
    }
}

public sealed record InventoryMovementHistoryQuery(
    string? ProductId = null,
    DateTime? FromUtc = null,
    DateTime? ToUtc = null,
    StockMovementReason? Reason = null,
    StockMovementDirection? Direction = null,
    int Limit = 250
)
    : IRequest<Result<List<InventoryMovementHistoryDto>>>;

internal sealed class InventoryMovementHistoryQueryHandler
    : IRequestHandler<InventoryMovementHistoryQuery, Result<List<InventoryMovementHistoryDto>>>
{
    private readonly IApplicationDbContext _db;
    private readonly ICurrentUser _currentUser;

    public InventoryMovementHistoryQueryHandler(
        IApplicationDbContext db,
        ICurrentUser currentUser
    )
    {
        _db = db;
        _currentUser = currentUser;
    }

    public async Task<Result<List<InventoryMovementHistoryDto>>> Handle(
        InventoryMovementHistoryQuery request,
        CancellationToken cancellationToken
    )
    {
        var query = InventoryReportScope.Movements(_db, _currentUser).AsNoTracking();
        if (!string.IsNullOrWhiteSpace(request.ProductId))
            query = query.Where(movement => movement.StockBatch.ProductId == request.ProductId);
        if (request.FromUtc.HasValue)
            query = query.Where(movement => movement.OccurredAtUtc >= request.FromUtc.Value);
        if (request.ToUtc.HasValue)
            query = query.Where(movement => movement.OccurredAtUtc <= request.ToUtc.Value);
        if (request.Reason.HasValue)
            query = query.Where(movement => movement.Reason == request.Reason.Value);
        if (request.Direction.HasValue)
            query = query.Where(movement => movement.Direction == request.Direction.Value);

        var limit = Math.Clamp(request.Limit, 1, 1000);
        var rows = await query
            .OrderByDescending(movement => movement.OccurredAtUtc)
            .Take(limit)
            .Select(movement => new InventoryMovementHistoryDto
            {
                Id = movement.Id,
                OperationId = movement.OperationId,
                StockBatchId = movement.StockBatchId,
                ProductId = movement.StockBatch.ProductId,
                ProductName = movement.StockBatch.Product.Name,
                ProductUnitId = movement.ProductUnitId,
                UnitName = movement.ProductUnit.UnitName ?? movement.ProductUnit.UnitOfMeasure.Name,
                QuantityEntered = movement.QuantityEntered,
                QuantityBase = movement.QuantityBase,
                Direction = movement.Direction,
                Reason = movement.Reason,
                OccurredAtUtc = movement.OccurredAtUtc,
                ReferenceType = movement.ReferenceType,
                ReferenceId = movement.ReferenceId
            })
            .ToListAsync(cancellationToken);

        return Result<List<InventoryMovementHistoryDto>>.SuccessResult(rows);
    }
}

public sealed record InventoryReconciliationQuery(string? StockBatchId = null, bool OnlyMismatches = false)
    : IRequest<Result<List<InventoryReconciliationDto>>>;

internal sealed class InventoryReconciliationQueryHandler
    : IRequestHandler<InventoryReconciliationQuery, Result<List<InventoryReconciliationDto>>>
{
    // Decimal quantities can involve fractional ProductUnit conversions. This tiny
    // tolerance prevents harmless arithmetic residue from being reported as corruption.
    private const decimal BalanceTolerance = 0.0001m;
    private readonly IApplicationDbContext _db;
    private readonly ICurrentUser _currentUser;

    public InventoryReconciliationQueryHandler(
        IApplicationDbContext db,
        ICurrentUser currentUser
    )
    {
        _db = db;
        _currentUser = currentUser;
    }

    public async Task<Result<List<InventoryReconciliationDto>>> Handle(
        InventoryReconciliationQuery request,
        CancellationToken cancellationToken
    )
    {
        var batchQuery = InventoryReportScope.Batches(_db, _currentUser).AsNoTracking();
        if (!string.IsNullOrWhiteSpace(request.StockBatchId))
            batchQuery = batchQuery.Where(batch => batch.Id == request.StockBatchId);

        var batches = await batchQuery
            .Select(batch => new
            {
                batch.Id,
                batch.ProductId,
                ProductName = batch.Product.Name,
                batch.BatchNumber,
                batch.RemainingQuantityBase
            })
            .ToListAsync(cancellationToken);

        var batchIds = batches.Select(batch => batch.Id).ToList();
        var movements = batchIds.Count == 0
            ? new List<MovementBalanceProjection>()
            : await InventoryReportScope.Movements(_db, _currentUser)
                .AsNoTracking()
                .Where(movement => batchIds.Contains(movement.StockBatchId))
                .Select(movement => new MovementBalanceProjection(
                    movement.StockBatchId,
                    movement.Direction,
                    movement.QuantityBase))
                .ToListAsync(cancellationToken);

        // The movement ledger is the historical truth. IN contributes positively and
        // OUT negatively, so the resulting sum is the balance the batch should have.
        var ledgerByBatch = movements
            .GroupBy(movement => movement.StockBatchId)
            .ToDictionary(
                group => group.Key,
                group => group.Sum(movement =>
                    movement.Direction == StockMovementDirection.In
                        ? movement.QuantityBase
                        : -movement.QuantityBase));

        var rows = batches.Select(batch =>
            {
                var ledgerBalance = ledgerByBatch.GetValueOrDefault(batch.Id, 0m);
                var difference = batch.RemainingQuantityBase - ledgerBalance;
                return new InventoryReconciliationDto
                {
                    StockBatchId = batch.Id,
                    ProductId = batch.ProductId,
                    ProductName = batch.ProductName,
                    BatchNumber = batch.BatchNumber,
                    CachedRemainingQuantityBase = batch.RemainingQuantityBase,
                    LedgerBalanceBase = ledgerBalance,
                    DifferenceBase = difference,
                    IsBalanced = Math.Abs(difference) <= BalanceTolerance
                };
            })
            .Where(row => !request.OnlyMismatches || !row.IsBalanced)
            .OrderBy(row => row.ProductName)
            .ThenBy(row => row.BatchNumber)
            .ToList();

        return Result<List<InventoryReconciliationDto>>.SuccessResult(rows);
    }
}

internal static class InventoryReportScope
{
    // Reports repeat the same tenant boundary in one place. This prevents individual
    // report handlers from accidentally omitting ShopId filtering while still allowing
    // super administrators to inspect all shops.
    public static IQueryable<Product> Products(
        IApplicationDbContext db,
        ICurrentUser currentUser
    )
    {
        var query = db.Products.AsQueryable();
        return currentUser.IsSuperAdmin()
            ? query
            : query.Where(product => product.ShopId == currentUser.GetShopId());
    }

    public static IQueryable<StockBatch> Batches(
        IApplicationDbContext db,
        ICurrentUser currentUser
    )
    {
        var query = db.StockBatches.AsQueryable();
        return currentUser.IsSuperAdmin()
            ? query
            : query.Where(batch => batch.ShopId == currentUser.GetShopId());
    }

    public static IQueryable<StockMovement> Movements(
        IApplicationDbContext db,
        ICurrentUser currentUser
    )
    {
        var query = db.StockMovements.AsQueryable();
        return currentUser.IsSuperAdmin()
            ? query
            : query.Where(movement => movement.ShopId == currentUser.GetShopId());
    }
}

internal static class InventoryReportPresentation
{
    /// <summary>
    /// Conversion happens only after normalized quantities have been calculated. These
    /// values are display equivalents and never feed inventory or valuation math.
    /// </summary>
    public static List<InventoryUnitPresentationDto> Convert(
        decimal quantityBase,
        IReadOnlyList<ProductUnitProjection> units
    ) =>
        units
            .Where(unit => unit.BaseUnitQuantity > 0)
            .OrderBy(unit => unit.BaseUnitQuantity)
            .Select(unit => new InventoryUnitPresentationDto
            {
                ProductUnitId = unit.ProductUnitId,
                UnitOfMeasureId = unit.UnitOfMeasureId,
                UnitName = unit.UnitName,
                BaseUnitQuantity = unit.BaseUnitQuantity,
                EquivalentQuantity = quantityBase / unit.BaseUnitQuantity
            })
            .ToList();
}

internal static class InventoryReportMath
{
    /// <summary>
    /// Converts a decimal cost calculation back into the project's long minor-unit
    /// money convention only after all quantity/cost multiplication is complete.
    /// </summary>
    public static long ToMinorUnits(
        decimal value
    ) =>
        checked((long)Math.Round(value, 0, MidpointRounding.AwayFromZero));
}

internal sealed record ProductStockProjection(
    string ProductId,
    string ProductName,
    string BaseUnitId,
    string? BaseUnitName,
    decimal ReorderPointBase,
    decimal ReorderQuantityBase
);

internal sealed record BatchBalanceProjection(
    string ProductId,
    decimal RemainingQuantityBase,
    long UnitCostBase,
    StatusEnum Status,
    DateTime? ExpirationDate
);

internal sealed record ProductUnitProjection(
    string ProductId,
    string ProductUnitId,
    string UnitOfMeasureId,
    string? UnitName,
    decimal BaseUnitQuantity
);

internal sealed record MovementBalanceProjection(
    string StockBatchId,
    StockMovementDirection Direction,
    decimal QuantityBase
);