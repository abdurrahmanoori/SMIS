
using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Enums;
using SMIS.Domain.Exceptions;

namespace SMIS.Domain.Entities;

public class StockTransaction : BaseAuditableEntityWithoutName
{
    public string ShopId { get; private set; } = string.Empty;
    public string? ShopName { get; set; }
    public string ProductId { get; private set; } = string.Empty;
    public string? ProductName { get; set; }
    public string StockBatchId { get; private set; } = string.Empty;
    public decimal Quantity { get; private set; }
    public string UnitId { get; private set; } = string.Empty;
    public string? UnitName { get; set; }
    public string Type { get; private set; } = "In";
    public DateTime TransactionDate { get; private set; }
    public string? Reference { get; private set; }

    // Navigation Properties
    public virtual Shop Shop { get; set; } = null!;
    public virtual Product Product { get; set; } = null!;
    public virtual StockBatch StockBatch { get; set; } = null!;
    public virtual UnitOfMeasure UnitOfMeasure { get; set; } = null!;

    internal StockTransaction() { } // EF Core & Seeding

    public static StockTransaction Create(string shopId, string productId, string stockBatchId, decimal quantity, string unitId, TransactionType type, DateTime transactionDate, string? reference = null)
    {
        var transaction = new StockTransaction();
        transaction.SetShopId(shopId);
        transaction.SetProductId(productId);
        transaction.SetStockBatchId(stockBatchId);
        transaction.SetQuantity(quantity);
        transaction.SetUnitId(unitId);
        transaction.SetType(type);
        transaction.SetTransactionDate(transactionDate);
        transaction.SetReference(reference);
        return transaction;
    }

    public void SetShopId(string shopId)
    {
        if (string.IsNullOrWhiteSpace(shopId))
            throw new DomainValidationException("Shop ID cannot be empty");

        ShopId = shopId;
    }

    public void SetProductId(string productId)
    {
        if (string.IsNullOrWhiteSpace(productId))
            throw new DomainValidationException("Product ID cannot be empty");

        ProductId = productId;
    }

    public void SetStockBatchId(string stockBatchId)
    {
        if (string.IsNullOrWhiteSpace(stockBatchId))
            throw new DomainValidationException("Stock batch ID cannot be empty");

        StockBatchId = stockBatchId;
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

        UnitId = unitId;
    }

    public void SetType(TransactionType type)
    {
        Type = type.ToString();
    }

    public void SetTransactionDate(DateTime transactionDate)
    {
        if (transactionDate == default)
            throw new DomainValidationException("Transaction date cannot be empty");

        TransactionDate = transactionDate;
    }

    public void SetReference(string? reference)
    {
        var referenceVO = ValueObjects.Reference.Create(reference);
        Reference = referenceVO;
    }

    public TransactionType GetTransactionType()
    {
        return Enum.Parse<TransactionType>(Type);
    }
}


/*
StockTransaction (Inventory History / Ledger)
What it is

Every movement of stock must be recorded:
Purchase (IN)
Sale (OUT)
Adjustment (damage, loss)
👉 Stock is calculated from transactions, not stored as a single number.

Sample Data
| Id | Product   | Batch  | Qty | Type | Reference  |
| -- | --------- | ------ | --- | ---- | ---------- |
| 1  | Coca Cola | CC-001 | 100 | In   | Purchase   |
| 2  | Coca Cola | CC-001 | 20  | Out  | Sale #1001 |
| 3  | Coca Cola | CC-002 | 80  | In   | Purchase   |
| 4  | Biscuit   | BS-101 | 10  | Out  | Sale #1002 |

📌 You can always audit stock because nothing is deleted.
*/
