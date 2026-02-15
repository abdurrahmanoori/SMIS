using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.LoanAccounts;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.LoanAccounts;
using SMIS.Domain.Entities;
using SMIS.Domain.Enums;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.LoanAccounts.Commands;

public class ProcessCustomerPaymentCommand : IRequest<Result<PaymentAllocationResultDto>>
{
    public string CustomerId { get; set; } = string.Empty;
    public long PaymentAmount { get; set; }
    public DateTime PaymentDate { get; set; }
    public string PaymentMethod { get; set; } = "Cash";
    public string? Notes { get; set; }
}

public class ProcessCustomerPaymentHandler : IRequestHandler<ProcessCustomerPaymentCommand, Result<PaymentAllocationResultDto>>
{
    private readonly ILoanAccountRepository _loanAccountRepository;
    private readonly PaymentAllocationService _paymentAllocationService;
    private readonly IUnitOfWork _unitOfWork;

    public ProcessCustomerPaymentHandler(
        ILoanAccountRepository loanAccountRepository,
        PaymentAllocationService paymentAllocationService,
        IUnitOfWork unitOfWork)
    {
        _loanAccountRepository = loanAccountRepository;
        _paymentAllocationService = paymentAllocationService;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<PaymentAllocationResultDto>> Handle(ProcessCustomerPaymentCommand request, CancellationToken cancellationToken)
    {
        var unpaidLoans = await _loanAccountRepository
            .GetAllQueryable()
            .Where(l => l.CustomerId == request.CustomerId
                     && l.Status != LoanStatus.Paid
                     && l.IsActive)
            .ToListAsync(cancellationToken);

        if (!unpaidLoans.Any())
            return Result<PaymentAllocationResultDto>.FailureResult("No unpaid loans found for this customer");

        var totalDebt = unpaidLoans.Sum(l => l.RemainingAmount);
        if (request.PaymentAmount > totalDebt)
            return Result<PaymentAllocationResultDto>.FailureResult($"Payment amount ({request.PaymentAmount}) exceeds total debt ({totalDebt})");

        var allocations = _paymentAllocationService.AllocatePayment(unpaidLoans, request.PaymentAmount);

        var resultAllocations = new List<LoanPaymentAllocationDto>();

        foreach (var allocation in allocations)
        {
            var payment = LoanAccountPayment.Create(
                allocation.LoanAccount.Id,
                allocation.AllocatedAmount,
                request.PaymentDate,
                request.PaymentMethod,
                request.Notes
            );

            allocation.LoanAccount.Payments.Add(payment);
            allocation.LoanAccount.RecordPayment(allocation.AllocatedAmount);

            resultAllocations.Add(new LoanPaymentAllocationDto
            {
                LoanAccountId = allocation.LoanAccount.Id,
                ProductName = allocation.LoanAccount.ProductName ?? "Unknown",
                AllocatedAmount = allocation.AllocatedAmount,
                RemainingAfterPayment = allocation.LoanAccount.RemainingAmount,
                Status = allocation.LoanAccount.Status.ToString()
            });
        }

        await _unitOfWork.SaveChanges(cancellationToken);

        var result = new PaymentAllocationResultDto
        {
            TotalPaid = request.PaymentAmount,
            Allocations = resultAllocations,
            RemainingUnallocated = request.PaymentAmount - allocations.Sum(a => a.AllocatedAmount)
        };

        return Result<PaymentAllocationResultDto>.SuccessResult(result, "Payment processed successfully");
    }
}
