using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Purchasing;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Services;

namespace SMIS.Application.Features.Purchasing.Queries;

public sealed record SupplierPayablesQuery(string SupplierId) : IRequest<Result<List<SupplierPayableDto>>>;
public sealed record SupplierPaymentsQuery(string SupplierId) : IRequest<Result<List<SupplierPaymentDto>>>;
public sealed record SupplierBalanceQuery(string SupplierId) : IRequest<Result<SupplierBalanceDto>>;

internal sealed class SupplierFinanceQueryHandler :
    IRequestHandler<SupplierPayablesQuery, Result<List<SupplierPayableDto>>>,
    IRequestHandler<SupplierPaymentsQuery, Result<List<SupplierPaymentDto>>>,
    IRequestHandler<SupplierBalanceQuery, Result<SupplierBalanceDto>>
{
    private readonly IApplicationDbContext _db;
    private readonly ICurrentUser _currentUser;

    public SupplierFinanceQueryHandler(IApplicationDbContext db, ICurrentUser currentUser)
    {
        _db = db;
        _currentUser = currentUser;
    }

    private IQueryable<SMIS.Domain.Entities.SupplierPayable> Payables(string supplierId)
    {
        var shopId = _currentUser.GetShopId();
        return _db.SupplierPayables.Where(x => x.ShopId == shopId && x.SupplierId == supplierId);
    }

    public async Task<Result<List<SupplierPayableDto>>> Handle(SupplierPayablesQuery request,
        CancellationToken cancellationToken)
    {
        var result = await Payables(request.SupplierId)
            .OrderBy(x => x.CreatedDate).ThenBy(x => x.Id)
            .Select(x => new SupplierPayableDto
            {
                Id = x.Id, ShopId = x.ShopId, SupplierId = x.SupplierId,
                PurchaseOrderId = x.PurchaseOrderId, TotalAmount = x.TotalAmount,
                CreditAmount = x.CreditAmount,
                PaidAmount = x.Allocations.Sum(a => (long?)a.Amount) ?? 0
            }).ToListAsync(cancellationToken);
        // A negative signed balance is supplier credit, not a negative debt.
        foreach (var payable in result)
        {
            var balance = payable.TotalAmount - payable.CreditAmount - payable.PaidAmount;
            payable.RemainingAmount = Math.Max(0, balance);
            payable.CreditDue = Math.Max(0, -balance);
        }
        return Result<List<SupplierPayableDto>>.Success(result);
    }

    public async Task<Result<List<SupplierPaymentDto>>> Handle(SupplierPaymentsQuery request,
        CancellationToken cancellationToken)
    {
        var shopId = _currentUser.GetShopId();
        var result = await _db.SupplierPayments.Where(x => x.ShopId == shopId && x.SupplierId == request.SupplierId)
            .OrderByDescending(x => x.PaidAtUtc)
            .Select(x => new SupplierPaymentDto
            {
                Id = x.Id, ShopId = x.ShopId, SupplierId = x.SupplierId,
                Amount = x.Amount, PaidAtUtc = x.PaidAtUtc,
                PaymentMethod = x.PaymentMethod, ReferenceNumber = x.ReferenceNumber, Notes = x.Notes,
                Allocations = x.Allocations.Select(a => new SupplierPaymentAllocationDto
                {
                    SupplierPayableId = a.SupplierPayableId,
                    PurchaseOrderId = a.Payable.PurchaseOrderId, Amount = a.Amount
                }).ToList()
            }).ToListAsync(cancellationToken);
        return Result<List<SupplierPaymentDto>>.Success(result);
    }

    public async Task<Result<SupplierBalanceDto>> Handle(SupplierBalanceQuery request,
        CancellationToken cancellationToken)
    {
        var payables = await Handle(new SupplierPayablesQuery(request.SupplierId), cancellationToken);
        if (!payables.IsSuccess)
            return Result<SupplierBalanceDto>.Failure(payables.Errors);
        var rows = payables.Value!;
        return Result<SupplierBalanceDto>.Success(new SupplierBalanceDto
        {
            SupplierId = request.SupplierId,
            TotalReceived = rows.Sum(x => x.TotalAmount),
            TotalReturns = rows.Sum(x => x.CreditAmount),
            TotalPaid = rows.Sum(x => x.PaidAmount),
            Outstanding = rows.Sum(x => x.RemainingAmount),
            SupplierCredit = rows.Sum(x => x.CreditDue)
        });
    }
}
