using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Enums;
using SMIS.Domain.Services;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class StockTransactionSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StockTransaction>().HasData(
            // Product CocaCola transactions - Batch1 & Batch2 - Unit: Bottle
            CreateStockTransaction(SeedIds.STrans1,  SeedIds.Shop1, SeedIds.ProdCocaCola, SeedIds.Batch1, 100m, SeedIds.UnitBottle, TransactionType.In,         new DateTime(2024, 1, 1),  "Purchase Order #001"),
            CreateStockTransaction(SeedIds.STrans2,  SeedIds.Shop1, SeedIds.ProdCocaCola, SeedIds.Batch1, 20m,  SeedIds.UnitBottle, TransactionType.Out,        new DateTime(2024, 1, 2),  "Sale #001"),
            CreateStockTransaction(SeedIds.STrans3,  SeedIds.Shop1, SeedIds.ProdCocaCola, SeedIds.Batch2, 80m,  SeedIds.UnitBottle, TransactionType.In,         new DateTime(2024, 1, 3),  "Purchase Order #002"),
            CreateStockTransaction(SeedIds.STrans4,  SeedIds.Shop1, SeedIds.ProdCocaCola, SeedIds.Batch2, 15m,  SeedIds.UnitBottle, TransactionType.Out,        new DateTime(2024, 1, 4),  "Sale #002"),

            // Product Oreo transactions - Batch3 - Unit: Pack
            CreateStockTransaction(SeedIds.STrans5,  SeedIds.Shop1, SeedIds.ProdOreo,     SeedIds.Batch3, 50m,  SeedIds.UnitPack,   TransactionType.In,         new DateTime(2024, 1, 5),  "Purchase Order #003"),
            CreateStockTransaction(SeedIds.STrans6,  SeedIds.Shop1, SeedIds.ProdOreo,     SeedIds.Batch3, 10m,  SeedIds.UnitPack,   TransactionType.Out,        new DateTime(2024, 1, 6),  "Sale #003"),
            CreateStockTransaction(SeedIds.STrans7,  SeedIds.Shop1, SeedIds.ProdOreo,     SeedIds.Batch3, 2m,   SeedIds.UnitPack,   TransactionType.Adujstment, new DateTime(2024, 1, 7),  "Damage - Expired"),

            // Product Notebook transactions - Batch4 - Unit: Piece
            CreateStockTransaction(SeedIds.STrans8,  SeedIds.Shop1, SeedIds.ProdNotebook, SeedIds.Batch4, 200m, SeedIds.UnitPiece,  TransactionType.In,         new DateTime(2024, 1, 8),  "Purchase Order #004"),
            CreateStockTransaction(SeedIds.STrans9,  SeedIds.Shop1, SeedIds.ProdNotebook, SeedIds.Batch4, 25m,  SeedIds.UnitPiece,  TransactionType.Out,        new DateTime(2024, 1, 9),  "Sale #004"),
            CreateStockTransaction(SeedIds.STrans10, SeedIds.Shop1, SeedIds.ProdNotebook, SeedIds.Batch4, 5m,   SeedIds.UnitPiece,  TransactionType.Out,        new DateTime(2024, 1, 10), "Sale #005")
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
        typeof(StockTransaction).GetProperty(nameof(StockTransaction.CreatedDate))!.SetValue(transaction, DateTimeService.NowUtc);
        typeof(StockTransaction).GetProperty(nameof(StockTransaction.UpdatedDate))!.SetValue(transaction, DateTimeService.NowUtc);
        typeof(StockTransaction).GetProperty(nameof(StockTransaction.LastModifiedUtc))!.SetValue(transaction, DateTimeService.NowUtc);

        return transaction;
    }

    private static string? GetShopName(string shopId) => shopId switch
    {
        SeedIds.Shop1 => "Main Store",
        SeedIds.Shop2 => "Branch Store",
        SeedIds.Shop3 => "Warehouse",
        _ => null
    };

    private static string? GetProductName(string productId) => productId switch
    {
        SeedIds.ProdCocaCola => "Coca Cola 500ml",
        SeedIds.ProdOreo     => "Oreo Biscuits",
        SeedIds.ProdNotebook => "A4 Notebook",
        _ => null
    };

    private static string? GetUnitName(string unitId) => unitId switch
    {
        SeedIds.UnitPiece    => "Piece",
        SeedIds.UnitBottle   => "Bottle",
        SeedIds.UnitPack     => "Pack",
        SeedIds.UnitBox      => "Box",
        SeedIds.UnitKilogram => "Kilogram",
        _ => null
    };
}
