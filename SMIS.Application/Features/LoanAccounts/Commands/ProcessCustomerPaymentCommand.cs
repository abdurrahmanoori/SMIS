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
        // Step 1: Fetch all unpaid/partially paid loans for this customer
        var unpaidLoans = await _loanAccountRepository
            .GetAllQueryable()
            .Where(l => l.CustomerId == request.CustomerId
                     && l.Status != LoanStatus.Paid
                     && l.IsActive)
            .ToListAsync(cancellationToken);

        if (!unpaidLoans.Any())
            return Result<PaymentAllocationResultDto>.FailureResult("No unpaid loans found for this customer");

        // Step 2: Validate payment doesn't exceed total debt
        var totalDebt = unpaidLoans.Sum(l => l.RemainingAmount);
        if (request.PaymentAmount > totalDebt)
            return Result<PaymentAllocationResultDto>.FailureResult($"Payment amount ({request.PaymentAmount}) exceeds total debt ({totalDebt})");

        // Step 3: Use domain service to allocate payment across loans (FIFO)
        // Example: Payment=130, Loans=[100, 50, 150] → Allocations=[Loan1:100, Loan2:30]
        var allocations = _paymentAllocationService.AllocatePayment(unpaidLoans, request.PaymentAmount);

        var resultAllocations = new List<LoanPaymentAllocationDto>();

        // Step 4: Process each allocation - create payment record and update loan status
        foreach (var allocation in allocations)
        {
            // Create payment record for audit trail
            var payment = LoanAccountPayment.Create(
                allocation.LoanAccount.Id,
                allocation.AllocatedAmount,
                request.PaymentDate,
                request.PaymentMethod,
                request.Notes
            );

            // Add payment to loan's collection (this updates PaidAmount calculation)
            allocation.LoanAccount.Payments.Add(payment);
            
            // Validate and update loan status (Unpaid → PartiallyPaid → Paid)
            allocation.LoanAccount.RecordPayment(allocation.AllocatedAmount);

            // Build response DTO
            resultAllocations.Add(new LoanPaymentAllocationDto
            {
                LoanAccountId = allocation.LoanAccount.Id,
                ProductName = allocation.LoanAccount.ProductName ?? "Unknown",
                AllocatedAmount = allocation.AllocatedAmount,
                RemainingAfterPayment = allocation.LoanAccount.RemainingAmount,
                Status = allocation.LoanAccount.Status.ToString()
            });
        }

        // Step 5: Persist all changes to database
        await _unitOfWork.SaveChanges(cancellationToken);

        // Step 6: Return result with allocation details
        var result = new PaymentAllocationResultDto
        {
            TotalPaid = request.PaymentAmount,
            Allocations = resultAllocations,
            RemainingUnallocated = request.PaymentAmount - allocations.Sum(a => a.AllocatedAmount)
        };

        return Result<PaymentAllocationResultDto>.SuccessResult(result, "Payment processed successfully");
    }
}
