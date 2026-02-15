using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Enums;
using SMIS.Domain.Exceptions;

namespace SMIS.Domain.Entities;

public class LoanAccount : BaseAuditableEntity, IShopEntity
{
    public string CustomerId { get; private set; } = string.Empty;
    public string? CustomerName { get; set; }
    public string ShopId { get; private set; } = string.Empty;
    public string? ShopName { get; set; }
    public string ProductId { get; private set; } = string.Empty;
    public string? ProductName { get; set; }
    public decimal Quantity { get; private set; }
    public string UnitId { get; private set; } = string.Empty;
    public string? UnitName { get; set; }
    public decimal PriceAtLoanTime { get; private set; }
    public long TotalAmount { get; private set; }
    public DateTime LoanDate { get; private set; }
    public DateTime? DueDate { get; private set; } = null;
    public LoanStatus Status { get; private set; } = LoanStatus.Unpaid;
    public string? Notes { get; private set; }
    public bool IsActive { get; private set; } = true;

    public Customer? Customer { get; set; }
    public Shop? Shop { get; set; }
    public Product? Product { get; set; }
    public UnitOfMeasure? UnitOfMeasure { get; set; }
    public ICollection<LoanAccountPayment> Payments { get; set; } = new List<LoanAccountPayment>();

    public long PaidAmount => Payments?.Sum(p => p.Amount) ?? 0;
    public long RemainingAmount => TotalAmount - PaidAmount;

    internal LoanAccount() { }

    public static LoanAccount Create(string customerId, string shopId, string productId, decimal quantity, string unitId, decimal priceAtLoanTime, long totalAmount, DateTime? dueDate = null, string? notes = null)
    {
        var loan = new LoanAccount();
        loan.SetCustomerId(customerId);
        loan.SetShopId(shopId);
        loan.SetProductId(productId);
        loan.SetQuantity(quantity);
        loan.SetUnitId(unitId);
        loan.SetPriceAtLoanTime(priceAtLoanTime);
        loan.SetTotalAmount(totalAmount);
        loan.SetLoanDate(DateTime.UtcNow);
        loan.SetDueDate(dueDate);
        loan.SetNotes(notes);
        return loan;
    }

    public void SetCustomerId(string customerId)
    {
        if (string.IsNullOrWhiteSpace(customerId))
            throw new DomainValidationException("Customer ID cannot be empty");
        CustomerId = customerId.Trim();
    }

    public void SetShopId(string shopId)
    {
        if (string.IsNullOrWhiteSpace(shopId))
            throw new DomainValidationException("Shop ID cannot be empty");
        ShopId = shopId.Trim();
    }

    public void SetProductId(string productId)
    {
        if (string.IsNullOrWhiteSpace(productId))
            throw new DomainValidationException("Product ID cannot be empty");
        ProductId = productId.Trim();
    }

    public void SetQuantity(decimal quantity)
    {
        if (quantity <= 0)
            throw new DomainValidationException("Quantity must be greater than zero");
        Quantity = quantity;
    }

    public void SetUnitId(string unitId)
    {
        if (string.IsNullOrWhiteSpace(unitId))
            throw new DomainValidationException("Unit ID cannot be empty");
        UnitId = unitId.Trim();
    }

    public void SetPriceAtLoanTime(decimal priceAtLoanTime)
    {
        if (priceAtLoanTime <= 0)
            throw new DomainValidationException("Price at loan time must be greater than zero");
        PriceAtLoanTime = priceAtLoanTime;
    }

    public void SetTotalAmount(long totalAmount)
    {
        if (totalAmount <= 0)
            throw new DomainValidationException("Total amount must be greater than zero");
        TotalAmount = totalAmount;
    }

    public void SetLoanDate(DateTime loanDate)
    {
        LoanDate = loanDate;
    }

    public void SetDueDate(DateTime? dueDate)
    {
        if (dueDate.HasValue && dueDate.Value <= LoanDate)
            throw new DomainValidationException("Due date must be after loan date");
        DueDate = dueDate;
    }

    public void SetNotes(string? notes)
    {
        if (!string.IsNullOrWhiteSpace(notes) && notes.Length > 500)
            throw new DomainValidationException("Notes cannot exceed 500 characters");
        Notes = string.IsNullOrWhiteSpace(notes) ? null : notes.Trim();
    }

    /// <summary>
    /// Records a payment and updates loan status. Call this AFTER adding payment to Payments collection.
    /// The status is automatically calculated based on PaidAmount vs TotalAmount.
    /// </summary>
    public void RecordPayment(long amount)
    {
        if (amount <= 0)
            throw new DomainValidationException("Payment amount must be greater than zero");

        if (amount > RemainingAmount)
            throw new DomainValidationException($"Payment amount ({amount}) cannot exceed remaining amount ({RemainingAmount})");

        UpdateStatus();
    }

    /// <summary>
    /// Calculates and sets the loan status based on payment state:
    /// - RemainingAmount = 0 → Paid
    /// - 0 < PaidAmount < TotalAmount → PartiallyPaid
    /// - PaidAmount = 0 → Unpaid
    /// - Past due date with remaining balance → Overdue
    /// </summary>
    private void UpdateStatus()
    {
        if (RemainingAmount == 0)
            Status = LoanStatus.Paid;
        else if (PaidAmount > 0 && RemainingAmount > 0)
            Status = LoanStatus.PartiallyPaid;
        else if (PaidAmount == 0)
            Status = LoanStatus.Unpaid;

        if (DueDate.HasValue && DateTime.UtcNow > DueDate.Value && RemainingAmount > 0)
            Status = LoanStatus.Overdue;
    }


    public void MarkAsOverdue()
    {
        if (DueDate.HasValue && DateTime.UtcNow > DueDate.Value && RemainingAmount > 0)
            Status = LoanStatus.Overdue;
    }

    public bool CanAcceptPayment() => Status != LoanStatus.Paid && RemainingAmount > 0;

    public bool IsFullyPaid() => Status == LoanStatus.Paid && RemainingAmount == 0;

    public void Activate() => IsActive = true;
    public void Deactivate() => IsActive = false;
}