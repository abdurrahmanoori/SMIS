using SMIS.Application.DTO.LoanAccounts;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.LoanAccounts;

internal static class LoanAccountMapping
{
    public static LoanAccountDto ToDto(LoanAccount receivable) => new()
    {
        Id = receivable.Id,
        SaleId = receivable.SaleId,
        CustomerId = receivable.CustomerId,
        CustomerName = receivable.CustomerName,
        ShopId = receivable.ShopId,
        ShopName = receivable.ShopName,
        TotalAmount = receivable.TotalAmount,
        LoanDate = receivable.LoanDate,
        DueDate = receivable.DueDate,
        Status = receivable.Status,
        Notes = receivable.Notes,
        IsActive = receivable.IsActive,
        PaidAmount = receivable.PaidAmount,
        RemainingAmount = receivable.RemainingAmount
    };
}
