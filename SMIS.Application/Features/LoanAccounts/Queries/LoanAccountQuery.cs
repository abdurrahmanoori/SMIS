using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.LoanAccounts;
using SMIS.Application.Services;

namespace SMIS.Application.Features.LoanAccounts.Queries;

public sealed record LoanAccountQuery(EntityDropdown<LoanAccountQueryCriteria> Query)
    : IRequest<Result<PagedListNew<LoanAccountDto>>>;

internal sealed class LoanAccountQueryHandler
    : IRequestHandler<LoanAccountQuery, Result<PagedListNew<LoanAccountDto>>>
{
    private readonly IApplicationDbContext _context;

    public LoanAccountQueryHandler(
        IApplicationDbContext context
    )
    {
        _context = context;
    }

    public async Task<Result<PagedListNew<LoanAccountDto>>> Handle(
        LoanAccountQuery request,
        CancellationToken cancellationToken
    )
    {
        var query = _context.LoanAccounts
            .OrderByDescending(loan => loan.LoanDate)
            .ThenBy(loan => loan.Id)
            .Select(loan => new LoanAccountDto
            {
                Id = loan.Id,
                SaleId = loan.SaleId,
                CustomerId = loan.CustomerId,
                CustomerName = loan.CustomerName,
                ShopId = loan.ShopId,
                ShopName = loan.ShopName,
                TotalAmount = loan.TotalAmount,
                LoanDate = loan.LoanDate,
                DueDate = loan.DueDate,
                Status = loan.Status,
                Notes = loan.Notes,
                IsActive = loan.IsActive,
                PaidAmount = loan.Payments.Sum(payment => (long?)payment.Amount) ?? 0,
                RemainingAmount = loan.TotalAmount - loan.CreditAmount -
                    (loan.Payments.Sum(payment => (long?)payment.Amount) ?? 0) > 0
                        ? loan.TotalAmount - loan.CreditAmount -
                          (loan.Payments.Sum(payment => (long?)payment.Amount) ?? 0)
                        : 0
            });

        var page = await query
            .Filter(request.Query.Criteria)
            .Select(request.Query.Columns)
            .ToPagedList(
                request.Query.GetPageNumber(),
                request.Query.GetPageSize(),
                cancellationToken);

        return Result<PagedListNew<LoanAccountDto>>.Success(page);
    }
}