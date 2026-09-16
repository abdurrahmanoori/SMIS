using SMIS.Application.DTO.StockMovements;
using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.Sales;

public sealed class SaleReturnDto
{
    public List<SaleReturnLineDto> Lines { get; set; } = [];
    public DateTime? OccurredAtUtc { get; set; }
    public string? IdempotencyKey { get; set; }
}

public sealed class SaleReturnLineDto
{
    public string SaleLineId { get; set; } = string.Empty;
    public decimal QuantityEntered { get; set; }
}

public sealed class SaleVoidDto
{
    public DateTime? OccurredAtUtc { get; set; }
    public string? IdempotencyKey { get; set; }
}

public sealed class SaleReturnResultDto
{
    public string SaleId { get; set; } = string.Empty;
    public SaleStatus Status { get; set; }
    public long ReturnedAmountMinor { get; set; }
    public long RefundDueMinor { get; set; }
    public long? ReceivableRemainingAmount { get; set; }
    public List<StockMovementDto> InventoryMovements { get; set; } = [];
}
