using SMIS.Application.DTO.Sales;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.Sales;

internal static class SaleMapping
{
    public static SaleDto ToDto(Sale sale) => new()
    {
        Id = sale.Id,
        ShopId = sale.ShopId,
        CustomerId = sale.CustomerId,
        SaleDateUtc = sale.SaleDateUtc,
        PaymentType = sale.PaymentType,
        TotalAmount = sale.TotalAmount,
        ReturnedAmount = sale.ReturnedAmount,
        NetAmount = sale.NetAmount,
        Status = sale.Status,
        Notes = sale.Notes,
        ReceivableId = sale.Receivable?.Id,
        ReceivableRemainingAmount = sale.Receivable?.RemainingAmount,
        Lines = sale.Lines.Select(ToDto).ToList()
    };

    private static SaleLineDto ToDto(SaleLine line) => new()
    {
        Id = line.Id,
        SaleId = line.SaleId,
        ProductId = line.ProductId,
        ProductUnitId = line.ProductUnitId,
        QuantityEntered = line.QuantityEntered,
        ReturnedQuantityEntered = line.ReturnedQuantityEntered,
        ReturnableQuantityEntered = line.ReturnableQuantityEntered,
        UnitPrice = line.UnitPrice,
        LineTotal = line.LineTotal
    };
}
