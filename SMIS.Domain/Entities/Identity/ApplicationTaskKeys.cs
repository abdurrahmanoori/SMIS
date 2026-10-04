namespace SMIS.Domain.Entities.Identity;

public static class ApplicationTaskKeys
{
    public const string ReceiveStock = "Inventory.ReceiveStock";
    public const string ProcessCustomerReturn = "Inventory.ProcessCustomerReturn";
    public const string ProcessSupplierReturn = "Inventory.ProcessSupplierReturn";
    public const string MarkDamagedStock = "Inventory.MarkDamagedStock";
    public const string MarkExpiredStock = "Inventory.MarkExpiredStock";
    public const string AdjustStock = "Inventory.AdjustStock";
    public const string TransferStock = "Inventory.TransferStock";
    public const string StartStockCount = "Inventory.StartStockCount";
    public const string CompleteStockCount = "Inventory.CompleteStockCount";
    public const string CancelStockCount = "Inventory.CancelStockCount";
    public const string ReverseStockMovement = "Inventory.ReverseStockMovement";

    public const string ReceivePurchaseOrder = "Purchasing.ReceivePurchaseOrder";
    public const string ProcessPurchaseOrderSupplierReturn = "Purchasing.ProcessSupplierReturn";
    public const string CancelPurchaseOrder = "Purchasing.CancelPurchaseOrder";

    public const string ProcessSaleReturn = "Sales.ProcessReturn";
    public const string VoidSale = "Sales.VoidSale";

    public const string ProcessCustomerPayment = "Receivables.ProcessCustomerPayment";
}