using SMIS.Domain.Common.BaseAbstract;

namespace SMIS.Domain.Entities;

public class StockConsumption : BaseAuditableEntityWithoutName
{
    public int StockBatchId { get; set; }
    public decimal Quantity { get; set; }
    public DateTime? ConsumedDate { get; set; }
    public string? ConsumedBy { get; set; } = null;
}
/*
 What it is

Explicit record of which batch was consumed during sales.
Very useful for FIFO / FEFO logic.

Sample Data
| Id | Batch  | Qty | Date       | By  |
| -- | ------ | --- | ---------- | --- |
| 1  | CC-001 | 20  | 2026-01-20 | POS |
| 2  | BS-101 | 10  | 2026-01-21 | POS |

 */