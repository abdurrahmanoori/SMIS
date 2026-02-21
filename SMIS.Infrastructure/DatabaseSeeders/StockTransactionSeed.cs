using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Enums;
using SMIS.Domain.Services;

namespace SMIS.Infrastructure.DatabaseSeeders;

public static class StockTransactionSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StockTransaction>().HasData(
            // Product 1 (Coca Cola) transactions - StockBatch 1 & 2 - Unit: Bottle (2)
            CreateStockTransaction("1", "1", "1", "1", 100m, "2", TransactionType.In, new DateTime(2024, 1, 1), "Purchase Order #001"),
            CreateStockTransaction("2", "1", "1", "1", 20m, "2", TransactionType.Out, new DateTime(2024, 1, 2), "Sale #001"),
            CreateStockTransaction("3", "1", "1", "2", 80m, "2", TransactionType.In, new DateTime(2024, 1, 3), "Purchase Order #002"),
            CreateStockTransaction("4", "1", "1", "2", 15m, "2", TransactionType.Out, new DateTime(2024, 1, 4), "Sale #002"),
            
            // Product 4 (Oreo Biscuits) transactions - StockBatch 3 - Unit: Pack (3)
            CreateStockTransaction("5", "1", "4", "3", 50m, "3", TransactionType.In, new DateTime(2024, 1, 5), "Purchase Order #003"),
            CreateStockTransaction("6", "1", "4", "3", 10m, "3", TransactionType.Out, new DateTime(2024, 1, 6), "Sale #003"),
            CreateStockTransaction("7", "1", "4", "3", 2m, "3", TransactionType.Adujstment, new DateTime(2024, 1, 7), "Damage - Expired"),
            
            // Product 7 (A4 Notebook) transactions - StockBatch 4 - Unit: Piece (1)
            CreateStockTransaction("8", "1", "7", "4", 200m, "1", TransactionType.In, new DateTime(2024, 1, 8), "Purchase Order #004"),
            CreateStockTransaction("9", "1", "7", "4", 25m, "1", TransactionType.Out, new DateTime(2024, 1, 9), "Sale #004"),
            CreateStockTransaction("10", "1", "7", "4", 5m, "1", TransactionType.Out, new DateTime(2024, 1, 10), "Sale #005")
        );
    }

    private static StockTransaction CreateStockTransaction(string id, string shopId, string productId, string stockBatchId, decimal quantity, string unitId, TransactionType type, DateTime transactionDate, string? reference)
    {
        var transaction = StockTransaction.Create(shopId, productId, stockBatchId, quantity, unitId, type, transactionDate, reference);

        // Set ID and Name fields for seeding
        typeof(StockTransaction).GetProperty(nameof(StockTransaction.Id))!.SetValue(transaction, id);
        typeof(StockTransaction).GetProperty(nameof(StockTransaction.ShopName))!.SetValue(transaction, GetShopName(shopId));
        typeof(StockTransaction).GetProperty(nameof(StockTransaction.ProductName))!.SetValue(transaction, GetProductName(productId));
        typeof(StockTransaction).GetProperty(nameof(StockTransaction.UnitName))!.SetValue(transaction, GetUnitName(unitId));
        typeof(StockTransaction).GetProperty(nameof(StockTransaction.CreatedDate))!.SetValue(transaction, DateTimeService.Now);
        typeof(StockTransaction).GetProperty(nameof(StockTransaction.UpdatedDate))!.SetValue(transaction, DateTimeService.Now);
        typeof(StockTransaction).GetProperty(nameof(StockTransaction.LastModifiedUtc))!.SetValue(transaction, DateTimeService.NowOffSet);

        return transaction;
    }

    private static string? GetShopName(string shopId) => shopId switch
    {
        "1" => "Main Store",
        "2" => "Branch Store",
        "3" => "Warehouse",
        _ => null
    };

    private static string? GetProductName(string productId) => productId switch
    {
        "1" => "Coca Cola 500ml",
        "4" => "Oreo Biscuits", 
        "7" => "A4 Notebook",
        _ => null
    };

    private static string? GetUnitName(string unitId) => unitId switch
    {
        "1" => "Piece",
        "2" => "Bottle",
        "3" => "Pack",
        "4" => "Box",
        "7" => "Kilogram",
        _ => null
    };
}