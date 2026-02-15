using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.Repositories.LoanAccounts;
using SMIS.Domain.Enums;

namespace SMIS.Application.Features.LoanAccounts.Queries;

public class GetCustomerDebtSummaryQuery : IRequest<Result<CustomerDebtSummaryDto>>
{
    public string CustomerId { get; set; } = string.Empty;
}

public class CustomerDebtSummaryDto
{
    public string CustomerId { get; set; } = string.Empty;
    public string CustomerName { get; set; } = string.Empty;
    public long TotalDebt { get; set; }
    public long TotalPaid { get; set; }
    public long TotalRemaining { get; set; }
    public int UnpaidLoansCount { get; set; }
    public int PartiallyPaidLoansCount { get; set; }
    public int PaidLoansCount { get; set; }
}

public class GetCustomerDebtSummaryHandler : IRequestHandler<GetCustomerDebtSummaryQuery, Result<CustomerDebtSummaryDto>>
{
    private readonly ILoanAccountRepository _loanAccountRepository;

    public GetCustomerDebtSummaryHandler(ILoanAccountRepository loanAccountRepository)
    {
        _loanAccountRepository = loanAccountRepository;
    }

    public async Task<Result<CustomerDebtSummaryDto>> Handle(GetCustomerDebtSummaryQuery request, CancellationToken cancellationToken)
    {
        var loans = await _loanAccountRepository
            .GetAllQueryable()
            .Where(l => l.CustomerId == request.CustomerId && l.IsActive)
            .ToListAsync(cancellationToken);

        if (!loans.Any())
            return Result<CustomerDebtSummaryDto>.NotFoundResult(request.CustomerId);

        var summary = new CustomerDebtSummaryDto
        {
            CustomerId = request.CustomerId,
            CustomerName = loans.First().CustomerName ?? "Unknown",
            TotalDebt = loans.Sum(l => l.TotalAmount),
            TotalPaid = loans.Sum(l => l.PaidAmount),
            TotalRemaining = loans.Sum(l => l.RemainingAmount),
            UnpaidLoansCount = loans.Count(l => l.Status == LoanStatus.Unpaid),
            PartiallyPaidLoansCount = loans.Count(l => l.Status == LoanStatus.PartiallyPaid),
            PaidLoansCount = loans.Count(l => l.Status == LoanStatus.Paid)
        };

        return Result<CustomerDebtSummaryDto>.SuccessResult(summary);
    }
}
