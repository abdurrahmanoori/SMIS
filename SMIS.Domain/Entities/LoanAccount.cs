using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Enums;
using SMIS.Domain.Exceptions;
using SMIS.Domain.Services;

namespace SMIS.Domain.Entities;

/// <summary>
/// Customer receivable created for a credit sale. Merchandise belongs to Sale/SaleLine;
/// this entity is intentionally concerned only with the amount owed and its payments.
/// </summary>
public class LoanAccount : BaseAuditableEntity, IShopEntity
{
    public string SaleId { get; private set; } = string.Empty;
    public string CustomerId { get; private set; } = string.Empty;
    public string? CustomerName { get; set; }
    public string ShopId { get; private set; } = string.Empty;
    public string? ShopName { get; set; }

    /// <summary>
    /// Original receivable principal in minor monetary units. Payments never rewrite it.
    /// </summary>
    public long TotalAmount { get; private set; }

    public long CreditAmount { get; private set; }

    public DateTime LoanDate { get; private set; }
    public DateTime? DueDate { get; private set; }
    public LoanStatus Status { get; private set; } = LoanStatus.Unpaid;
    public string? Notes { get; private set; }
    public bool IsActive { get; private set; } = true;

    public Sale Sale { get; set; } = null!;
    public Customer? Customer { get; set; }
    public Shop? Shop { get; set; }
    public ICollection<LoanAccountPayment> Payments { get; set; } = new List<LoanAccountPayment>();

    /// <summary>
    /// Payment rows are the monetary audit trail. The receivable balance is derived from them.
    /// </summary>
    public long PaidAmount => Payments.Sum(payment => payment.Amount);

    public long NetReceivableAmount => TotalAmount - CreditAmount;

    public long RemainingAmount => Math.Max(0, NetReceivableAmount - PaidAmount);

    public long OverpaidAmount => Math.Max(0, PaidAmount - NetReceivableAmount);

    internal LoanAccount()
    {
    }

    public static LoanAccount Create(
        string saleId,
        string customerId,
        string shopId,
        long totalAmount,
        DateTime loanDateUtc,
        DateTime? dueDate = null,
        string? notes = null
    )
    {
        var loan = new LoanAccount();
        loan.SetSaleId(saleId);
        loan.SetCustomerId(customerId);
        loan.SetShopId(shopId);
        loan.SetTotalAmount(totalAmount);
        loan.SetLoanDate(loanDateUtc);
        loan.SetDueDate(dueDate);
        loan.SetNotes(notes);
        return loan;
    }

    private void SetSaleId(
        string saleId
    )
    {
        if (string.IsNullOrWhiteSpace(saleId))
            throw new DomainValidationException("Sale ID cannot be empty");
        SaleId = saleId.Trim();
    }

    private void SetCustomerId(
        string customerId
    )
    {
        if (string.IsNullOrWhiteSpace(customerId))
            throw new DomainValidationException("Customer ID cannot be empty");
        CustomerId = customerId.Trim();
    }

    private void SetShopId(
        string shopId
    )
    {
        if (string.IsNullOrWhiteSpace(shopId))
            throw new DomainValidationException("Shop ID cannot be empty");
        ShopId = shopId.Trim();
    }

    private void SetTotalAmount(
        long totalAmount
    )
    {
        if (totalAmount <= 0)
            throw new DomainValidationException("Receivable amount must be greater than zero");
        TotalAmount = totalAmount;
    }

    private void SetLoanDate(
        DateTime loanDate
    )
    {
        LoanDate = DateTimeService.NormalizeUtc(loanDate);
    }

    public void SetDueDate(
        DateTime? dueDate
    )
    {
        if (dueDate.HasValue && DateTimeService.NormalizeUtc(dueDate.Value) <= LoanDate)
            throw new DomainValidationException("Due date must be after receivable date");
        DueDate = dueDate.HasValue ? DateTimeService.NormalizeUtc(dueDate.Value) : null;
    }

    public void SetNotes(
        string? notes
    )
    {
        if (!string.IsNullOrWhiteSpace(notes) && notes.Length > 500)
            throw new DomainValidationException("Notes cannot exceed 500 characters");
        Notes = string.IsNullOrWhiteSpace(notes) ? null : notes.Trim();
    }

    /// <summary>
    /// Updates status after a payment row has been added to Payments. This operation
    /// changes debt state only and must never create or modify inventory records.
    /// </summary>
    public void RecordPayment(
        long amount
    )
    {
        if (amount <= 0)
            throw new DomainValidationException("Payment amount must be greater than zero");
        if (PaidAmount > NetReceivableAmount)
            throw new DomainValidationException("Payments cannot exceed the receivable amount");

        UpdateStatus();
    }

    public void ApplyCredit(
        long amount
    )
    {
        if (amount <= 0)
            throw new DomainValidationException("Receivable credit must be greater than zero");
        if (CreditAmount + amount > TotalAmount)
            throw new DomainValidationException("Receivable credits cannot exceed the original receivable amount");

        CreditAmount += amount;
        UpdateStatus();
    }

    private void UpdateStatus()
    {
        if (RemainingAmount == 0)
            Status = LoanStatus.Paid;
        else if (PaidAmount > 0)
            Status = LoanStatus.PartiallyPaid;
        else
            Status = LoanStatus.Unpaid;

        if (DueDate.HasValue && DateTimeService.NowUtc > DueDate.Value && RemainingAmount > 0)
            Status = LoanStatus.Overdue;
    }

    public void MarkAsOverdue()
    {
        if (DueDate.HasValue && DateTimeService.NowUtc > DueDate.Value && RemainingAmount > 0)
            Status = LoanStatus.Overdue;
    }

    public bool CanAcceptPayment() => IsActive && RemainingAmount > 0;
    public bool IsFullyPaid() => Status == LoanStatus.Paid && RemainingAmount == 0;
    public void Activate() => IsActive = true;
    public void Deactivate() => IsActive = false;
}