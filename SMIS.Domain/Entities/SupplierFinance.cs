using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Exceptions;
using SMIS.Domain.Services;

namespace SMIS.Domain.Entities;

/// <summary>One payable per purchase order. Only successfully received stock creates debt.</summary>
public sealed class SupplierPayable : BaseAuditableEntity, IShopEntity
{
    public string ShopId { get; private set; } = string.Empty;
    public string SupplierId { get; private set; } = string.Empty;
    public string PurchaseOrderId { get; private set; } = string.Empty;
    public long TotalAmount { get; private set; }
    public long CreditAmount { get; private set; }
    public Supplier Supplier { get; set; } = null!;
    public PurchaseOrder PurchaseOrder { get; set; } = null!;
    public ICollection<SupplierPayableEntry> Entries { get; set; } = new List<SupplierPayableEntry>();
    public ICollection<SupplierPaymentAllocation> Allocations { get; set; } = new List<SupplierPaymentAllocation>();
    // A return reduces what we owe; payments settle the rest. If returns exceed
    // the unpaid portion, the negative balance becomes credit owed by the supplier.
    public long PaidAmount => Allocations.Sum(x => x.Amount);
    public long SignedBalance => TotalAmount - CreditAmount - PaidAmount;
    public long RemainingAmount => Math.Max(0, SignedBalance);
    public long CreditDue => Math.Max(0, -SignedBalance);

    internal SupplierPayable() { }

    public static SupplierPayable Create(string shopId, string supplierId, string purchaseOrderId)
    {
        if (string.IsNullOrWhiteSpace(shopId) || string.IsNullOrWhiteSpace(supplierId) ||
            string.IsNullOrWhiteSpace(purchaseOrderId))
            throw new DomainValidationException("Payable requires a shop, supplier, and purchase order.");
        return new SupplierPayable
        {
            ShopId = shopId.Trim(),
            SupplierId = supplierId.Trim(),
            PurchaseOrderId = purchaseOrderId.Trim()
        };
    }

    public void RecordReceipt(long amount, string operationId, DateTime occurredAtUtc)
    {
        if (amount <= 0) throw new DomainValidationException("Receipt value must be positive.");
        // Keep the running total and an audit entry for the same receipt operation.
        TotalAmount = checked(TotalAmount + amount);
        Entries.Add(SupplierPayableEntry.Create(ShopId, Id, operationId, amount,
            SupplierPayableEntryKind.Receipt, occurredAtUtc));
        Version++;
    }

    public void RecordReturn(long amount, string operationId, DateTime occurredAtUtc)
    {
        if (amount <= 0 || amount > TotalAmount - CreditAmount)
            throw new DomainValidationException("Supplier credit exceeds the received purchase value.");
        // Do not rewrite the original receipt value; record its offset separately.
        CreditAmount = checked(CreditAmount + amount);
        Entries.Add(SupplierPayableEntry.Create(ShopId, Id, operationId, amount,
            SupplierPayableEntryKind.SupplierReturn, occurredAtUtc));
        Version++;
    }

    public void RecordAllocation(long amount)
    {
        if (amount <= 0 || amount > RemainingAmount)
            throw new DomainValidationException("Payment exceeds the outstanding payable.");
        // Payment rows carry the amounts; changing Version marks this payable as
        // touched so concurrent allocations can be detected by EF Core.
        Version++;
    }
}

public enum SupplierPayableEntryKind { Receipt = 1, SupplierReturn = 2 }

/// <summary>Append-only monetary history for receipt and supplier-return operations.</summary>
public sealed class SupplierPayableEntry : BaseAuditableEntity, IShopEntity
{
    public string ShopId { get; private set; } = string.Empty;
    public string SupplierPayableId { get; private set; } = string.Empty;
    public string OperationId { get; private set; } = string.Empty;
    public SupplierPayableEntryKind Kind { get; private set; }
    public long Amount { get; private set; }
    public DateTime OccurredAtUtc { get; private set; }
    public SupplierPayable Payable { get; set; } = null!;

    internal SupplierPayableEntry() { }

    public static SupplierPayableEntry Create(string shopId, string payableId, string operationId,
        long amount, SupplierPayableEntryKind kind, DateTime occurredAtUtc)
    {
        if (string.IsNullOrWhiteSpace(shopId) || string.IsNullOrWhiteSpace(payableId) ||
            string.IsNullOrWhiteSpace(operationId) || amount <= 0 ||
            !Enum.IsDefined(kind))
            throw new DomainValidationException("Invalid supplier payable entry.");
        return new SupplierPayableEntry
        {
            ShopId = shopId.Trim(), SupplierPayableId = payableId.Trim(),
            OperationId = operationId.Trim(), Amount = amount, Kind = kind,
            OccurredAtUtc = DateTimeService.NormalizeUtc(occurredAtUtc)
        };
    }
}

/// <summary>A posted supplier payment. Never overwrite or delete financial history.</summary>
public sealed class SupplierPayment : BaseAuditableEntity, IShopEntity
{
    public string ShopId { get; private set; } = string.Empty;
    public string SupplierId { get; private set; } = string.Empty;
    public long Amount { get; private set; }
    public DateTime PaidAtUtc { get; private set; }
    public string PaymentMethod { get; private set; } = string.Empty;
    public string? ReferenceNumber { get; private set; }
    public string? Notes { get; private set; }
    public Supplier Supplier { get; set; } = null!;
    public ICollection<SupplierPaymentAllocation> Allocations { get; set; } = new List<SupplierPaymentAllocation>();

    internal SupplierPayment() { }

    public static SupplierPayment Create(string shopId, string supplierId, long amount, DateTime paidAtUtc,
        string paymentMethod, string? referenceNumber = null, string? notes = null)
    {
        if (string.IsNullOrWhiteSpace(shopId) || string.IsNullOrWhiteSpace(supplierId) ||
            string.IsNullOrWhiteSpace(paymentMethod) || amount <= 0)
            throw new DomainValidationException("Payment requires a supplier, amount, and method.");
        if (paymentMethod.Length > 50 || referenceNumber?.Length > 100 || notes?.Length > 500)
            throw new DomainValidationException("Supplier payment fields exceed their allowed lengths.");
        return new SupplierPayment
        {
            ShopId = shopId.Trim(), SupplierId = supplierId.Trim(), Amount = amount,
            PaidAtUtc = DateTimeService.NormalizeUtc(paidAtUtc),
            PaymentMethod = paymentMethod.Trim(),
            ReferenceNumber = string.IsNullOrWhiteSpace(referenceNumber) ? null : referenceNumber.Trim(),
            Notes = string.IsNullOrWhiteSpace(notes) ? null : notes.Trim()
        };
    }
}

public sealed class SupplierPaymentAllocation : BaseAuditableEntity, IShopEntity
{
    public string ShopId { get; private set; } = string.Empty;
    public string SupplierPaymentId { get; private set; } = string.Empty;
    public string SupplierPayableId { get; private set; } = string.Empty;
    public long Amount { get; private set; }
    public SupplierPayment Payment { get; set; } = null!;
    public SupplierPayable Payable { get; set; } = null!;

    internal SupplierPaymentAllocation() { }

    public static SupplierPaymentAllocation Create(string shopId, string paymentId, string payableId, long amount)
    {
        if (string.IsNullOrWhiteSpace(shopId) || string.IsNullOrWhiteSpace(paymentId) ||
            string.IsNullOrWhiteSpace(payableId) || amount <= 0)
            throw new DomainValidationException("Invalid supplier payment allocation.");
        return new SupplierPaymentAllocation
        {
            ShopId = shopId.Trim(), SupplierPaymentId = paymentId.Trim(),
            SupplierPayableId = payableId.Trim(), Amount = amount
        };
    }
}
