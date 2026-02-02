using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Enums;
using SMIS.Domain.Exceptions;

namespace SMIS.Domain.Entities;

public class StockBatch : BaseAuditableEntityWithoutName
{
    public string ProductId { get; private set; } = string.Empty;
    public string? ProductName { get; set; }
    public string? BatchNumber { get; private set; }
    public decimal Quantity { get; private set; }
    public string UnitId { get; private set; } = string.Empty;
    public string? UnitName { get; set; }
    public DateTime ReceivedDate { get; private set; }
    public DateTime? ExpirationDate { get; private set; }
    public long PurchasePrice { get; private set; }
    public StatusEnum Status { get; private set; } = StatusEnum.Active;

    internal StockBatch() { } // EF Core & Seeding

    public static StockBatch Create(string productId, string unitId, decimal quantity, long purchasePrice, DateTime? receivedDate = null, string? batchNumber = null, DateTime? expirationDate = null)
    {
        var batch = new StockBatch();
        batch.SetProductId(productId);
        batch.SetUnitId(unitId);
        batch.SetQuantity(quantity);
        batch.SetPurchasePrice(purchasePrice);
        batch.SetReceivedDate(receivedDate ?? DateTime.UtcNow);
        batch.SetBatchNumber(batchNumber);
        batch.SetExpirationDate(expirationDate);
        return batch;
    }

    public void SetProductId(string productId)
    {
        if (string.IsNullOrWhiteSpace(productId))
            throw new DomainValidationException("Product ID cannot be empty");
        ProductId = productId.Trim();
    }

    public void SetUnitId(string unitId)
    {
        if (string.IsNullOrWhiteSpace(unitId))
            throw new DomainValidationException("Unit ID cannot be empty");
        UnitId = unitId.Trim();
    }

    public void SetQuantity(decimal quantity)
    {
        if (quantity < 0)
            throw new DomainValidationException("Quantity cannot be negative");
        Quantity = quantity;
    }

    public void SetPurchasePrice(long purchasePrice)
    {
        if (purchasePrice < 0)
            throw new DomainValidationException("Purchase price cannot be negative");
        PurchasePrice = purchasePrice;
    }

    public void SetReceivedDate(DateTime receivedDate)
    {
        if (receivedDate > DateTime.UtcNow.AddDays(1))
            throw new DomainValidationException("Received date cannot be in the future");
        ReceivedDate = receivedDate;
    }

    public void SetBatchNumber(string? batchNumber)
    {
        if (!string.IsNullOrWhiteSpace(batchNumber) && batchNumber.Length > 50)
            throw new DomainValidationException("Batch number cannot exceed 50 characters");
        BatchNumber = string.IsNullOrWhiteSpace(batchNumber) ? null : batchNumber.Trim();
    }

    public void SetExpirationDate(DateTime? expirationDate)
    {
        if (expirationDate.HasValue && expirationDate.Value <= ReceivedDate)
            throw new DomainValidationException("Expiration date must be after received date");
        ExpirationDate = expirationDate;
    }

    public void Activate() => Status = StatusEnum.Active;
    public void Deactivate() => Status = StatusEnum.Inactive;
    public void MarkAsCompleted() => Status = StatusEnum.Completed;
    public void MarkAsCancelled() => Status = StatusEnum.Cancelled;

    public void ConsumeQuantity(decimal consumedQuantity)
    {
        if (consumedQuantity <= 0)
            throw new DomainValidationException("Consumed quantity must be positive");
        if (consumedQuantity > Quantity)
            throw new DomainValidationException("Cannot consume more than available quantity");
        Quantity -= consumedQuantity;
    }

    public void AddQuantity(decimal addedQuantity)
    {
        if (addedQuantity <= 0)
            throw new DomainValidationException("Added quantity must be positive");
        Quantity += addedQuantity;
    }
}

/*
* What it is
A StockBatch represents one physical receipt of a product.
Same product → many batches → different expiration dates.

👉 This is how you solve the “same product, different expiry” problem.
I received THIS amount of a product on THIS date, and it expires on THAT date.
Sample Data
| Id | Product   | BatchNo | Qty | Unit   | Expiry     | Price |
| -- | --------- | ------- | --- | ------ | ---------- | ----- |
| 1  | Coca Cola | CC-001  | 100 | Bottle | 2026-06-01 | 0.40  |
| 2  | Coca Cola | CC-002  | 80  | Bottle | 2026-07-15 | 0.42  |
| 3  | Biscuit   | BS-101  | 50  | Pack   | 2025-09-01 | 0.25  |
| 4  | Notebook  | NB-009  | 200 | Piece  | NULL       | 1.20  |
📌 Notebook has no expiration → NULL expiry is allowed.



Sample data (real life)
Energy Drink (base unit = ml)
| BatchNumber | QuantityInBaseUnit | ExpiryDate | ReceivedAt |
| ----------- | ------------------ | ---------- | ---------- |
| ED-001      | 12,500 ml          | 2026-03-01 | 2026-01-10 |
| ED-002      | 12,500 ml          | 2026-04-01 | 2026-01-20 |

This means:
Same product
Two different expiry dates
Inventory is split, not mixed


Biscuit (base unit = piece)
| BatchNumber | QuantityInBaseUnit | ExpiryDate |
| ----------- | ------------------ | ---------- |
| BIS-11      | 120                | 2026-02-15 |
| BIS-12      | 120                | 2026-03-10 |

Pen (non-food)
| BatchNumber | QuantityInBaseUnit | ExpiryDate |
| ----------- | ------------------ | ---------- |
| PEN-01      | 120                | null       |
Pens don’t expire. No drama.

*/
