using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Exceptions;

namespace SMIS.Domain.Entities;

public class LoanAccountPayment : BaseAuditableEntity
{
    public string LoanAccountId { get; private set; } = string.Empty;
    public long Amount { get; private set; }
    public DateTime PaymentDate { get; private set; }
    public string PaymentMethod { get; private set; } = "Cash";
    public string? Notes { get; private set; }
    public bool IsActive { get; private set; } = true;

    public LoanAccount? LoanAccount { get; set; }

    internal LoanAccountPayment() { }

    public static LoanAccountPayment Create(string loanAccountId, long amount, DateTime paymentDate, string paymentMethod = "Cash", string? notes = null)
    {
        var payment = new LoanAccountPayment();
        payment.SetLoanAccountId(loanAccountId);
        payment.SetAmount(amount);
        payment.SetPaymentDate(paymentDate);
        payment.SetPaymentMethod(paymentMethod);
        payment.SetNotes(notes);
        return payment;
    }

    public void SetLoanAccountId(string loanAccountId)
    {
        if (string.IsNullOrWhiteSpace(loanAccountId))
            throw new DomainValidationException("Loan account ID cannot be empty");
        LoanAccountId = loanAccountId.Trim();
    }

    public void SetAmount(long amount)
    {
        if (amount <= 0)
            throw new DomainValidationException("Payment amount must be greater than zero");
        Amount = amount;
    }

    public void SetPaymentDate(DateTime paymentDate)
    {
        PaymentDate = paymentDate;
    }

    public void SetPaymentMethod(string paymentMethod)
    {
        if (string.IsNullOrWhiteSpace(paymentMethod))
            throw new DomainValidationException("Payment method cannot be empty");
        PaymentMethod = paymentMethod.Trim();
    }

    public void SetNotes(string? notes)
    {
        if (!string.IsNullOrWhiteSpace(notes) && notes.Length > 500)
            throw new DomainValidationException("Notes cannot exceed 500 characters");
        Notes = string.IsNullOrWhiteSpace(notes) ? null : notes.Trim();
    }

    public void Activate() => IsActive = true;
    public void Deactivate() => IsActive = false;
}