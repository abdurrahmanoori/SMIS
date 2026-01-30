
using SMIS.Domain.Enums;

namespace SMIS.Domain.Entities;

public class StockTransaction
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int StockBatchId { get; set; }
    public decimal Quantity { get; set; }
    public int UnitId { get; set; }
    public TransactionType Type { get; set; } = TransactionType.In; // In, Out, Adjustment
    public DateTime TransactionDate { get; set; }
    public string? Reference { get; set; } = null!;
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
