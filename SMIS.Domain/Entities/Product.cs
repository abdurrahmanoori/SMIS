using SMIS.Domain.Common.BaseAbstract;

namespace SMIS.Domain.Entities
{
    public class Product : BaseAuditableEntity
    {
        public string ShopId { get; set; } = string.Empty;
        // The ONE unit used to store inventory internally (Every product has ONE base unit:Milliliter,Piece,Gram)
        public string BaseUnitId { get; set; } = string.Empty;

        // Price for ONE base unit (not pack, not box)
        public int SalePricePerBaseUnit { get; set; }
        public string? Description { get; set; }
        // Can we sell this product or not?
        public bool IsActive { get; set; } = true;
        public string SKU { get; set; } = string.Empty; // Unique identifier
        public string? Barcode { get; set; }
        public string? ImageUrl { get; set; }
        public string? CategoryId { get; set; }


        // Navigation Properties
        public virtual Shop Shop { get; set; } = null!;
        public UnitOfMeasure UnitOfMeasure { get; set; } = null!;
        public virtual Category? Category { get; set; }
        //public virtual ICollection<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();
        //public virtual ICollection<StockMovement> StockMovements { get; set; } = new List<StockMovement>();
    }
}
