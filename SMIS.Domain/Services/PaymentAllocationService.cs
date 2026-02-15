using SMIS.Domain.Entities;
using SMIS.Domain.Exceptions;

namespace SMIS.Domain.Services;

public class PaymentAllocationService
{
    public List<PaymentAllocation> AllocatePayment(List<LoanAccount> unpaidLoans, long paymentAmount)
    {
        if (paymentAmount <= 0)
            throw new DomainValidationException("Payment amount must be greater than zero");

        if (!unpaidLoans.Any())
            throw new DomainValidationException("No unpaid loans available for payment allocation");

        var allocations = new List<PaymentAllocation>();
        var remainingPayment = paymentAmount;

        foreach (var loan in unpaidLoans.OrderBy(l => l.LoanDate))
        {
            if (remainingPayment <= 0) break;
            if (!loan.CanAcceptPayment()) continue;

            var amountToAllocate = Math.Min(remainingPayment, loan.RemainingAmount);
            
            allocations.Add(new PaymentAllocation
            {
                LoanAccount = loan,
                AllocatedAmount = amountToAllocate
            });

            remainingPayment -= amountToAllocate;
        }

        return allocations;
    }
}

public class PaymentAllocation
{
    public LoanAccount LoanAccount { get; set; } = null!;
    public long AllocatedAmount { get; set; }
}
