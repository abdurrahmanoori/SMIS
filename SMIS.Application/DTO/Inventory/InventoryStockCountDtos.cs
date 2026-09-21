using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.Inventory;

public sealed class StockCountStartDto
{
    public List<string> StockBatchIds { get; set; } = [];
    public string? Notes { get; set; }
}

public sealed class StockCountCompleteDto
{
    public List<StockCountValueDto> Counts { get; set; } = [];
    public DateTime? OccurredAtUtc { get; set; }
    public string? IdempotencyKey { get; set; }
}

public sealed class StockCountValueDto
{
    public string StockBatchId { get; set; } = string.Empty;
    public decimal CountedQuantityBase { get; set; }
}

public sealed class StockCountSessionDto
{
    public string Id { get; set; } = string.Empty;
    public string ShopId { get; set; } = string.Empty;
    public DateTime StartedAtUtc { get; set; }
    public DateTime? CompletedAtUtc { get; set; }
    public StockCountStatus Status { get; set; }
    public string? Notes { get; set; }
    public List<StockCountLineDto> Lines { get; set; } = [];
}

public sealed class StockCountLineDto
{
    public string Id { get; set; } = string.Empty;
    public string StockBatchId { get; set; } = string.Empty;
    public string ProductId { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public string? BatchNumber { get; set; }
    public decimal ExpectedQuantityBase { get; set; }
    public decimal? CountedQuantityBase { get; set; }
    public decimal DifferenceBase { get; set; }
}
