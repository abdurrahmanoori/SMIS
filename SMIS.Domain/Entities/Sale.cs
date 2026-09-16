using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Enums;
using SMIS.Domain.Exceptions;
using SMIS.Domain.Services;

namespace SMIS.Domain.Entities;

/// <summary>
/// Commercial record of goods sold to a customer. Sale describes what happened at the
/// checkout; inventory movements and any resulting receivable are separate records.
/// </summary>
public class Sale : BaseAuditableEntityWithoutName, IShopEntity
{
    public string ShopId { get; private set; } = string.Empty;
    public string? CustomerId { get; private set; }
    public DateTime SaleDateUtc { get; private set; }
    public SalePaymentType PaymentType { get; private set; }
    public long TotalAmount { get; private set; }
    public long ReturnedAmount { get; private set; }
    public SaleStatus Status { get; private set; } = SaleStatus.Completed;
    public string? Notes { get; private set; }

    public Shop Shop { get; set; } = null!;
    public Customer? Customer { get; set; }
    public ICollection<SaleLine> Lines { get; set; } = new List<SaleLine>();
    public LoanAccount? Receivable { get; set; }

    internal Sale()
    {
    }

    public static Sale Create(
        string shopId,
        string? customerId,
        SalePaymentType paymentType,
        DateTime saleDateUtc,
        string? notes = null
    )
    {
        if (string.IsNullOrWhiteSpace(shopId))
            throw new DomainValidationException("Shop ID cannot be empty");

        if (paymentType == SalePaymentType.Credit && string.IsNullOrWhiteSpace(customerId))
            throw new DomainValidationException("Credit sales require a customer");

        return new Sale
        {
            ShopId = shopId.Trim(),
            CustomerId = string.IsNullOrWhiteSpace(customerId) ? null : customerId.Trim(),
            PaymentType = paymentType,
            SaleDateUtc = DateTimeService.NormalizeUtc(saleDateUtc),
            Notes = string.IsNullOrWhiteSpace(notes) ? null : notes.Trim()
        };
    }

    /// <summary>
    /// Sale total is derived from immutable line snapshots rather than accepted from the client.
    /// </summary>
    public void RecalculateTotal()
    {
        TotalAmount = Lines.Sum(line => line.LineTotal);
    }

    public long NetAmount => TotalAmount - ReturnedAmount;

    public void RegisterReturn(long amount, bool allLinesReturned, bool markVoided = false)
    {
        if (amount < 0)
            throw new DomainValidationException("Returned sale amount cannot be negative");
        if (ReturnedAmount + amount > TotalAmount)
            throw new DomainValidationException("Returned amount cannot exceed the original sale total");

        ReturnedAmount += amount;

        if (markVoided)
        {
            if (!allLinesReturned)
                throw new DomainValidationException("A voided sale must return all remaining sale quantities");

            Status = SaleStatus.Voided;
            return;
        }

        Status = allLinesReturned
            ? SaleStatus.Returned
            : SaleStatus.PartiallyReturned;
    }
}