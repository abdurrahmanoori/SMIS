using SMIS.Domain.Enums;

namespace SMIS.Application.DTO.Sales;

public sealed class SaleCreateDto
{
    public string ShopId { get; set; } = string.Empty;
    public string? CustomerId { get; set; }
    public SalePaymentType PaymentType { get; set; } = SalePaymentType.Cash;
    public DateTime? SaleDateUtc { get; set; }
    public DateTime? DueDate { get; set; }
    public string? Notes { get; set; }
    public List<SaleLineCreateDto> Lines { get; set; } = [];
}

public sealed class SaleLineCreateDto
{
    public string ProductId { get; set; } = string.Empty;
    public string ProductUnitId { get; set; } = string.Empty;
    public decimal QuantityEntered { get; set; }
    public long UnitPrice { get; set; }
}