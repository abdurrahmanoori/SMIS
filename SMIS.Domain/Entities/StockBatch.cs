using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Enums;

namespace SMIS.Domain.Entities
{
    public class StockBatch : BaseAuditableEntityWithoutName
    {
        public int ProductId { get; set; }
        public string? BatchNumber { get; set; } = null;
        // How much stock is left in THIS batch (base unit only)
        public decimal Quantity { get; set; }
        public int UnitId { get; set; }
        public DateTime ReceivedDate { get; set; }
        // When this batch expires (null for non-food items)
        public DateTime ExpirationDate { get; set; }
        public long PurchasePrice { get; set; }
        public StatusEnum Status { get; set; } = StatusEnum.Active;
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
