using SMIS.Domain.Common.BaseAbstract;

namespace SMIS.Domain.Entities.Shopp
{
    public class Product : BaseAuditableEntity
    {
        public int ShopId { get; set; }
        public string SKU { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal StockQuantity { get; set; }
        public decimal ReorderLevel { get; set; }
        public string Unit { get; set; } // e.g., piece, kg, liter
        public bool IsActive { get; set; } = true;

        // Navigation Properties
        public virtual Shop Shop { get; set; }
        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();
        public virtual ICollection<StockMovement> StockMovements { get; set; } = new List<StockMovement>();
    }
}
