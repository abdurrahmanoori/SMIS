class ApplicationTaskKeys {
  const ApplicationTaskKeys._();

  static const receiveStock = 'Inventory.ReceiveStock';
  static const processCustomerReturn = 'Inventory.ProcessCustomerReturn';
  static const processSupplierReturn = 'Inventory.ProcessSupplierReturn';
  static const markDamagedStock = 'Inventory.MarkDamagedStock';
  static const markExpiredStock = 'Inventory.MarkExpiredStock';
  static const adjustStock = 'Inventory.AdjustStock';
  static const transferStock = 'Inventory.TransferStock';
  static const startStockCount = 'Inventory.StartStockCount';
  static const completeStockCount = 'Inventory.CompleteStockCount';
  static const cancelStockCount = 'Inventory.CancelStockCount';
  static const reverseStockMovement = 'Inventory.ReverseStockMovement';
  static const receivePurchaseOrder = 'Purchasing.ReceivePurchaseOrder';
  static const processPurchaseOrderSupplierReturn =
      'Purchasing.ProcessSupplierReturn';
  static const cancelPurchaseOrder = 'Purchasing.CancelPurchaseOrder';
}
