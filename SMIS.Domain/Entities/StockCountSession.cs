using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Enums;
using SMIS.Domain.Exceptions;
using SMIS.Domain.Services;

namespace SMIS.Domain.Entities;

public sealed class StockCountSession : BaseAuditableEntity, IShopEntity
{
    public string ShopId { get; private set; } = string.Empty;
    public DateTime StartedAtUtc { get; private set; }
    public DateTime? CompletedAtUtc { get; private set; }
    public StockCountStatus Status { get; private set; } = StockCountStatus.Draft;
    public string? Notes { get; private set; }

    public Shop Shop { get; set; } = null!;
    public ICollection<StockCountLine> Lines { get; set; } = new List<StockCountLine>();

    internal StockCountSession()
    {
    }

    public static StockCountSession Create(
        string shopId,
        DateTime startedAtUtc,
        string? notes = null
    )
    {
        if (string.IsNullOrWhiteSpace(shopId))
            throw new DomainValidationException("Shop ID cannot be empty");

        var utc = startedAtUtc.Kind == DateTimeKind.Utc ? startedAtUtc : startedAtUtc.ToUniversalTime();
        if (utc > DateTimeService.NowUtc.AddMinutes(5))
            throw new DomainValidationException("Stock count start time cannot be in the future");

        return new StockCountSession
        {
            ShopId = shopId.Trim(),
            StartedAtUtc = utc,
            Notes = string.IsNullOrWhiteSpace(notes) ? null : notes.Trim()
        };
    }

    public void Complete(
        DateTime completedAtUtc
    )
    {
        if (Status != StockCountStatus.Draft)
            throw new DomainValidationException("Only a draft stock count can be completed");
        if (Lines.Count == 0 || Lines.Any(line => !line.CountedQuantityBase.HasValue))
            throw new DomainValidationException("Every stock count line must be counted before completion");

        var utc = completedAtUtc.Kind == DateTimeKind.Utc ? completedAtUtc : completedAtUtc.ToUniversalTime();
        if (utc < StartedAtUtc)
            throw new DomainValidationException("Stock count completion time cannot be before its start time");
        if (utc > DateTimeService.NowUtc.AddMinutes(5))
            throw new DomainValidationException("Stock count completion time cannot be in the future");

        CompletedAtUtc = utc;
        Status = StockCountStatus.Completed;
    }

    public void Cancel()
    {
        if (Status != StockCountStatus.Draft)
            throw new DomainValidationException("Only a draft stock count can be cancelled");

        Status = StockCountStatus.Cancelled;
    }
}

public sealed class StockCountLine : BaseAuditableEntity
{
    public string StockCountSessionId { get; private set; } = string.Empty;
    public string StockBatchId { get; private set; } = string.Empty;
    public decimal ExpectedQuantityBase { get; private set; }
    public decimal? CountedQuantityBase { get; private set; }
    public decimal DifferenceBase { get; private set; }

    public StockCountSession StockCountSession { get; set; } = null!;
    public StockBatch StockBatch { get; set; } = null!;

    internal StockCountLine()
    {
    }

    public static StockCountLine Create(
        string stockCountSessionId,
        string stockBatchId,
        decimal expectedQuantityBase
    )
    {
        if (string.IsNullOrWhiteSpace(stockCountSessionId))
            throw new DomainValidationException("Stock count session ID cannot be empty");
        if (string.IsNullOrWhiteSpace(stockBatchId))
            throw new DomainValidationException("Stock batch ID cannot be empty");
        if (expectedQuantityBase < 0)
            throw new DomainValidationException("Expected stock quantity cannot be negative");

        return new StockCountLine
        {
            StockCountSessionId = stockCountSessionId.Trim(),
            StockBatchId = stockBatchId.Trim(),
            ExpectedQuantityBase = expectedQuantityBase
        };
    }

    public void RecordCount(
        decimal countedQuantityBase
    )
    {
        if (countedQuantityBase < 0)
            throw new DomainValidationException("Counted stock quantity cannot be negative");

        CountedQuantityBase = countedQuantityBase;
        DifferenceBase = countedQuantityBase - ExpectedQuantityBase;
    }
}