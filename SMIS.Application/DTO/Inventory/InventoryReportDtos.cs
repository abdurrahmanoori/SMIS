using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.Inventory;

public sealed class InventoryUnitPresentationDto
{
    public string ProductUnitId { get; set; } = string.Empty;
    public string UnitOfMeasureId { get; set; } = string.Empty;
    public string? UnitName { get; set; }
    public decimal BaseUnitQuantity { get; set; }

    /// <summary>
    /// Display-only equivalent of the normalized base quantity in this ProductUnit.
    /// It must never be used as the source for stock or valuation calculations.
    /// </summary>
    public decimal EquivalentQuantity { get; set; }
}

public sealed class CurrentStockReportDto
{
    public string ProductId { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public string BaseUnitId { get; set; } = string.Empty;
    public string? BaseUnitName { get; set; }

    /// <summary>
    /// Authoritative normalized stock quantity expressed in the product's base unit.
    /// </summary>
    public decimal QuantityBase { get; set; }

    public int BatchCount { get; set; }
    public long InventoryValueMinor { get; set; }
    public bool IsLowStock { get; set; }
    public List<InventoryUnitPresentationDto> PresentationUnits { get; set; } = new();
}

public sealed class ExpiringStockReportDto
{
    public string StockBatchId { get; set; } = string.Empty;
    public string ProductId { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public string? BatchNumber { get; set; }
    public decimal RemainingQuantityBase { get; set; }
    public string BaseUnitId { get; set; } = string.Empty;
    public string? BaseUnitName { get; set; }
    public DateTime ExpirationDate { get; set; }
    public bool IsExpired { get; set; }
    public int DaysUntilExpiration { get; set; }
    public long UnitCostBase { get; set; }
    public long InventoryValueMinor { get; set; }
}

public sealed class InventoryValuationItemDto
{
    public string ProductId { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public decimal QuantityBase { get; set; }
    public long InventoryValueMinor { get; set; }
}

public sealed class InventoryValuationReportDto
{
    public long TotalInventoryValueMinor { get; set; }
    public List<InventoryValuationItemDto> Products { get; set; } = new();
}

public sealed class InventoryMovementHistoryDto
{
    public string Id { get; set; } = string.Empty;
    public string StockBatchId { get; set; } = string.Empty;
    public string ProductId { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public string ProductUnitId { get; set; } = string.Empty;
    public string? UnitName { get; set; }
    public decimal QuantityEntered { get; set; }
    public decimal QuantityBase { get; set; }
    public StockMovementDirection Direction { get; set; }
    public StockMovementReason Reason { get; set; }
    public DateTime OccurredAtUtc { get; set; }
    public string? ReferenceType { get; set; }
    public string? ReferenceId { get; set; }
}

public sealed class InventoryReconciliationDto
{
    public string StockBatchId { get; set; } = string.Empty;
    public string ProductId { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public string? BatchNumber { get; set; }

    /// <summary>
    /// Fast operational balance stored on StockBatch.
    /// </summary>
    public decimal CachedRemainingQuantityBase { get; set; }

    /// <summary>
    /// Balance independently rebuilt from SUM(IN QuantityBase) - SUM(OUT QuantityBase).
    /// </summary>
    public decimal LedgerBalanceBase { get; set; }

    /// <summary>
    /// Cached balance minus ledger-derived balance. A non-zero value beyond the small
    /// reconciliation tolerance indicates an inventory integrity problem.
    /// </summary>
    public decimal DifferenceBase { get; set; }

    public bool IsBalanced { get; set; }
}