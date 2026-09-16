using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Enums;
using SMIS.Domain.Exceptions;

namespace SMIS.Domain.Entities;

public sealed class PurchaseOrder : BaseAuditableEntity, IShopEntity
{
    public string ShopId { get; private set; } = string.Empty;
    public string SupplierId { get; private set; } = string.Empty;
    public string? ReferenceNumber { get; private set; }
    public DateTime OrderedAtUtc { get; private set; }
    public PurchaseOrderStatus Status { get; private set; } = PurchaseOrderStatus.Submitted;
    public string? Notes { get; private set; }

    public Shop Shop { get; set; } = null!;
    public Supplier Supplier { get; set; } = null!;
    public ICollection<PurchaseOrderLine> Lines { get; set; } = new List<PurchaseOrderLine>();

    internal PurchaseOrder()
    {
    }

    public static PurchaseOrder Create(
        string shopId,
        string supplierId,
        DateTime orderedAtUtc,
        string? referenceNumber = null,
        string? notes = null)
    {
        if (string.IsNullOrWhiteSpace(shopId))
            throw new DomainValidationException("Shop ID cannot be empty");
        if (string.IsNullOrWhiteSpace(supplierId))
            throw new DomainValidationException("Supplier ID cannot be empty");

        var utc = orderedAtUtc.Kind == DateTimeKind.Utc ? orderedAtUtc : orderedAtUtc.ToUniversalTime();
        if (utc > DateTime.UtcNow.AddMinutes(5))
            throw new DomainValidationException("Purchase order time cannot be in the future");

        return new PurchaseOrder
        {
            ShopId = shopId.Trim(),
            SupplierId = supplierId.Trim(),
            OrderedAtUtc = utc,
            ReferenceNumber = string.IsNullOrWhiteSpace(referenceNumber) ? null : referenceNumber.Trim(),
            Notes = string.IsNullOrWhiteSpace(notes) ? null : notes.Trim(),
            Status = PurchaseOrderStatus.Submitted
        };
    }

    public void RefreshReceiptStatus()
    {
        if (Status == PurchaseOrderStatus.Cancelled)
            return;

        if (Lines.Count > 0 && Lines.All(line => line.ReceivedQuantityEntered >= line.OrderedQuantityEntered))
        {
            Status = PurchaseOrderStatus.Received;
            return;
        }

        Status = Lines.Any(line => line.ReceivedQuantityEntered > 0)
            ? PurchaseOrderStatus.PartiallyReceived
            : PurchaseOrderStatus.Submitted;
    }

    public void Cancel()
    {
        if (Lines.Any(line => line.ReceivedQuantityEntered > 0))
            throw new DomainValidationException("A purchase order with received stock cannot be cancelled");

        Status = PurchaseOrderStatus.Cancelled;
    }
}

public sealed class PurchaseOrderLine : BaseAuditableEntity
{
    public string PurchaseOrderId { get; private set; } = string.Empty;
    public string ProductId { get; private set; } = string.Empty;
    public string ProductUnitId { get; private set; } = string.Empty;
    public decimal OrderedQuantityEntered { get; private set; }
    public decimal ReceivedQuantityEntered { get; private set; }
    public decimal ReturnedQuantityEntered { get; private set; }
    public long UnitCostBase { get; private set; }

    public PurchaseOrder PurchaseOrder { get; set; } = null!;
    public Product Product { get; set; } = null!;
    public ProductUnit ProductUnit { get; set; } = null!;

    internal PurchaseOrderLine()
    {
    }

    public static PurchaseOrderLine Create(
        string purchaseOrderId,
        string productId,
        string productUnitId,
        decimal orderedQuantityEntered,
        long unitCostBase)
    {
        if (string.IsNullOrWhiteSpace(purchaseOrderId))
            throw new DomainValidationException("Purchase order ID cannot be empty");
        if (string.IsNullOrWhiteSpace(productId))
            throw new DomainValidationException("Product ID cannot be empty");
        if (string.IsNullOrWhiteSpace(productUnitId))
            throw new DomainValidationException("Product unit ID cannot be empty");
        if (orderedQuantityEntered <= 0)
            throw new DomainValidationException("Ordered quantity must be greater than zero");
        if (unitCostBase < 0)
            throw new DomainValidationException("Purchase unit cost cannot be negative");

        return new PurchaseOrderLine
        {
            PurchaseOrderId = purchaseOrderId.Trim(),
            ProductId = productId.Trim(),
            ProductUnitId = productUnitId.Trim(),
            OrderedQuantityEntered = orderedQuantityEntered,
            UnitCostBase = unitCostBase
        };
    }

    public decimal RemainingToReceiveQuantityEntered => OrderedQuantityEntered - ReceivedQuantityEntered;
    public decimal NetReceivedQuantityEntered => ReceivedQuantityEntered - ReturnedQuantityEntered;

    public void RegisterReceipt(decimal quantityEntered)
    {
        if (quantityEntered <= 0)
            throw new DomainValidationException("Received quantity must be greater than zero");
        if (quantityEntered > RemainingToReceiveQuantityEntered)
            throw new DomainValidationException("Received quantity cannot exceed the remaining purchase-order quantity");

        ReceivedQuantityEntered += quantityEntered;
    }

    public void RegisterSupplierReturn(decimal quantityEntered)
    {
        if (quantityEntered <= 0)
            throw new DomainValidationException("Supplier-return quantity must be greater than zero");
        if (quantityEntered > NetReceivedQuantityEntered)
            throw new DomainValidationException("Supplier-return quantity cannot exceed net received quantity");

        ReturnedQuantityEntered += quantityEntered;
    }
}
