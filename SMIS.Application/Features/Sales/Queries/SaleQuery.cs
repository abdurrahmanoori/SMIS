using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Sales;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Services;

namespace SMIS.Application.Features.Sales.Queries;

public sealed record SaleQuery(EntityDropdown<SaleQueryCriteria> Query)
    : IRequest<Result<PagedListNew<SaleDto>>>;

internal sealed class SaleQueryHandler
    : IRequestHandler<SaleQuery, Result<PagedListNew<SaleDto>>>
{
    private readonly IApplicationDbContext _context;
    private readonly ICurrentUser _currentUser;

    public SaleQueryHandler(
        IApplicationDbContext context,
        ICurrentUser currentUser
    )
    {
        _context = context;
        _currentUser = currentUser;
    }

    public async Task<Result<PagedListNew<SaleDto>>> Handle(
        SaleQuery request,
        CancellationToken cancellationToken
    )
    {
        var shopId = _currentUser.GetShopId();
        var query = _context.Sales
            .Where(sale => sale.ShopId == shopId)
            .OrderByDescending(sale => sale.SaleDateUtc)
            .ThenBy(sale => sale.Id)
            .Select(sale => new SaleDto
            {
                Id = sale.Id,
                ShopId = sale.ShopId,
                CustomerId = sale.CustomerId,
                SaleDateUtc = sale.SaleDateUtc,
                PaymentType = sale.PaymentType,
                TotalAmount = sale.TotalAmount,
                ReturnedAmount = sale.ReturnedAmount,
                NetAmount = sale.TotalAmount - sale.ReturnedAmount,
                Status = sale.Status,
                Notes = sale.Notes,
                ReceivableId = _context.LoanAccounts
                    .Where(receivable => receivable.SaleId == sale.Id)
                    .Select(receivable => (string?)receivable.Id)
                    .FirstOrDefault(),
                ReceivableRemainingAmount = _context.LoanAccounts
                    .Where(receivable => receivable.SaleId == sale.Id)
                    .Select(receivable => (long?)(
                        receivable.TotalAmount - receivable.CreditAmount -
                        (receivable.Payments.Sum(payment => (long?)payment.Amount) ?? 0) > 0
                            ? receivable.TotalAmount - receivable.CreditAmount -
                              (receivable.Payments.Sum(payment => (long?)payment.Amount) ?? 0)
                            : 0))
                    .FirstOrDefault(),
                Lines = sale.Lines
                    .OrderBy(line => line.Id)
                    .Select(line => new SaleLineDto
                    {
                        Id = line.Id,
                        SaleId = line.SaleId,
                        ProductId = line.ProductId,
                        ProductUnitId = line.ProductUnitId,
                        QuantityEntered = line.QuantityEntered,
                        ReturnedQuantityEntered = line.ReturnedQuantityEntered,
                        ReturnableQuantityEntered = line.QuantityEntered - line.ReturnedQuantityEntered,
                        UnitPrice = line.UnitPrice,
                        LineTotal = line.LineTotal
                    })
                    .ToList()
            });

        var page = await query
            .Filter(request.Query.Criteria)
            .Select(request.Query.Columns)
            .ToPagedList(
                request.Query.GetPageNumber(),
                request.Query.GetPageSize(),
                cancellationToken);

        return Result<PagedListNew<SaleDto>>.SuccessResult(page);
    }
}