using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities.Identity;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class ApplicationTaskSeeder
{
    public static void DataSeed(
        ModelBuilder modelBuilder
    )
    {
        modelBuilder.Entity<ApplicationTask>().HasData(
            Task(AuthorizationSeedIds.TaskReceiveStock, ApplicationTaskKeys.ReceiveStock, "Receive stock"),
            Task(AuthorizationSeedIds.TaskProcessCustomerReturn, ApplicationTaskKeys.ProcessCustomerReturn, "Process customer return"),
            Task(AuthorizationSeedIds.TaskProcessSupplierReturn, ApplicationTaskKeys.ProcessSupplierReturn, "Process supplier return"),
            Task(AuthorizationSeedIds.TaskMarkDamagedStock, ApplicationTaskKeys.MarkDamagedStock, "Mark damaged stock"),
            Task(AuthorizationSeedIds.TaskMarkExpiredStock, ApplicationTaskKeys.MarkExpiredStock, "Mark expired stock"),
            Task(AuthorizationSeedIds.TaskAdjustStock, ApplicationTaskKeys.AdjustStock, "Adjust stock"),
            Task(AuthorizationSeedIds.TaskTransferStock, ApplicationTaskKeys.TransferStock, "Transfer stock"),
            Task(AuthorizationSeedIds.TaskStartStockCount, ApplicationTaskKeys.StartStockCount, "Start stock count"),
            Task(AuthorizationSeedIds.TaskCompleteStockCount, ApplicationTaskKeys.CompleteStockCount, "Complete stock count"),
            Task(AuthorizationSeedIds.TaskCancelStockCount, ApplicationTaskKeys.CancelStockCount, "Cancel stock count"),
            Task(AuthorizationSeedIds.TaskReverseStockMovement, ApplicationTaskKeys.ReverseStockMovement, "Reverse stock movement"),
            Task(AuthorizationSeedIds.TaskReceivePurchaseOrder, ApplicationTaskKeys.ReceivePurchaseOrder, "Receive purchase order", AuthorizationSeedIds.ComponentPurchasing),
            Task(AuthorizationSeedIds.TaskProcessPurchaseOrderSupplierReturn, ApplicationTaskKeys.ProcessPurchaseOrderSupplierReturn, "Process purchase-order supplier return", AuthorizationSeedIds.ComponentPurchasing),
            Task(AuthorizationSeedIds.TaskCancelPurchaseOrder, ApplicationTaskKeys.CancelPurchaseOrder, "Cancel purchase order", AuthorizationSeedIds.ComponentPurchasing),
            Task(AuthorizationSeedIds.TaskProcessSaleReturn, ApplicationTaskKeys.ProcessSaleReturn, "Process sale return", AuthorizationSeedIds.ComponentSales),
            Task(AuthorizationSeedIds.TaskVoidSale, ApplicationTaskKeys.VoidSale, "Void sale", AuthorizationSeedIds.ComponentSales),
            Task(AuthorizationSeedIds.TaskProcessCustomerPayment, ApplicationTaskKeys.ProcessCustomerPayment, "Process customer payment", AuthorizationSeedIds.ComponentReceivables));
    }

    private static ApplicationTask Task(
        string id,
        string key,
        string name
    ) => Task(id, key, name, AuthorizationSeedIds.ComponentInventory);

    private static ApplicationTask Task(
        string id,
        string key,
        string name,
        string componentId
    ) =>
        new()
        {
            Id = id,
            Key = key,
            Name = name,
            ComponentId = componentId,
            IsActive = true
        };
}
