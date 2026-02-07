using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Exceptions;

namespace SMIS.Domain.Entities;

public class CustomerLoanPayment : BaseAuditableEntity
{
    public string CustomerLoanId { get; private set; } = string.Empty;
    public long Amount { get; private set; }
    public DateTime PaymentDate { get; private set; }
    public string PaymentMethod { get; private set; } = "Cash";
    public string? Notes { get; private set; }
    public bool IsActive { get; private set; } = true;

    public CustomerLoan? CustomerLoan { get; set; }

    internal CustomerLoanPayment() { }

    public static CustomerLoanPayment Create(string customerLoanId, long amount, DateTime paymentDate, string paymentMethod = "Cash", string? notes = null)
    {
        var payment = new CustomerLoanPayment();
        payment.SetCustomerLoanId(customerLoanId);
        payment.SetAmount(amount);
        payment.SetPaymentDate(paymentDate);
        payment.SetPaymentMethod(paymentMethod);
        payment.SetNotes(notes);
        return payment;
    }

    public void SetCustomerLoanId(string customerLoanId)
    {
        if (string.IsNullOrWhiteSpace(customerLoanId))
            throw new DomainValidationException("Customer loan ID cannot be empty");
        CustomerLoanId = customerLoanId.Trim();
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