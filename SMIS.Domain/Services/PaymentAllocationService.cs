using SMIS.Domain.Entities;
using SMIS.Domain.Exceptions;

namespace SMIS.Domain.Services;

/// <summary>
/// Domain service that handles payment allocation across multiple loans using FIFO strategy.
/// Example: Customer has 3 loans (100, 50, 150) and pays 130 → Loan1 gets 100, Loan2 gets 30
/// </summary>
public class PaymentAllocationService
{
    /// <summary>
    /// Distributes a single payment amount across multiple unpaid loans (oldest first).
    /// </summary>
    /// <param name="unpaidLoans">List of loans that can accept payment (Status != Paid)</param>
    /// <param name="paymentAmount">Total amount customer is paying (e.g., 130 Afghani)</param>
    /// <returns>List of allocations showing how much each loan received</returns>
    public List<PaymentAllocation> AllocatePayment(List<LoanAccount> unpaidLoans, long paymentAmount)
    {
        if (paymentAmount <= 0)
            throw new DomainValidationException("Payment amount must be greater than zero");

        if (!unpaidLoans.Any())
            throw new DomainValidationException("No unpaid loans available for payment allocation");

        var allocations = new List<PaymentAllocation>();
        var remainingPayment = paymentAmount; // Track how much payment is left to distribute

        // FIFO Strategy: Pay oldest loans first (ordered by LoanDate)
        // Example: Loan1(Jan 1), Loan2(Jan 2), Loan3(Jan 3) → Process in this order
        foreach (var loan in unpaidLoans.OrderBy(l => l.LoanDate))
        {
            // Stop if we've distributed all the payment
            if (remainingPayment <= 0) break;
            
            // Skip loans that are already fully paid or can't accept payment
            if (!loan.CanAcceptPayment()) continue;

            // Allocate either the full remaining payment OR what the loan needs (whichever is smaller)
            // Example: RemainingPayment=130, Loan needs 100 → Allocate 100
            //          RemainingPayment=30, Loan needs 50 → Allocate 30
            var amountToAllocate = Math.Min(remainingPayment, loan.RemainingAmount);
            
            allocations.Add(new PaymentAllocation

            {
                LoanAccount = loan,
                AllocatedAmount = amountToAllocate
            });

            // Reduce remaining payment by what we just allocated
            remainingPayment -= amountToAllocate;
        }

        return allocations;
    }
}

/// <summary>
/// Represents how much of a payment was allocated to a specific loan.
/// Example: LoanAccount=Loan1, AllocatedAmount=100 means Loan1 received 100 from this payment.
/// </summary>
public class PaymentAllocation
{
    public LoanAccount LoanAccount { get; set; } = null!;
    public long AllocatedAmount { get; set; }
}
