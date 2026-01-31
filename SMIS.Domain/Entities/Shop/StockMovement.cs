//using SMIS.Domain.Common.BaseAbstract;
//using SMIS.Domain.Enums;

//namespace SMIS.Domain.Entities.Shopp
//{
//    public class StockMovement : BaseAuditableEntityWithoutName
//    {
//        public int ProductId { get; set; }
//        public int ShopId { get; set; }
//        public DateTime MovementDate { get; set; }
//        public MovementType MovementType { get; set; }
//        public decimal Quantity { get; set; }
//        public decimal QuantityBefore { get; set; }
//        public decimal QuantityAfter { get; set; }
//        public ReferenceType ReferenceType { get; set; }
//        public int? ReferenceId { get; set; }
//        public string Notes { get; set; }

//        // Navigation Properties
//        public virtual Product Product { get; set; }
//        public virtual Shop Shop { get; set; }
//    }
//}
