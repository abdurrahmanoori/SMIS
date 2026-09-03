using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class StockBatchSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        var now = DateTimeService.NowUtc;
        var stockBatches = new[]
        {
            CreateStockBatch(SeedIds.Batch1, SeedIds.ProdCocaCola, SeedIds.UnitBottle, 100m, 40000, now.AddDays(-10), "CC-001",   now.AddMonths(6)),
            CreateStockBatch(SeedIds.Batch2, SeedIds.ProdCocaCola, SeedIds.UnitBottle, 80m,  42000, now.AddDays(-5),  "CC-002",   now.AddMonths(7)),
            CreateStockBatch(SeedIds.Batch3, SeedIds.ProdOreo,     SeedIds.UnitPack,   50m,  25000, now.AddDays(-15), "OREO-101", now.AddMonths(3)),
            CreateStockBatch(SeedIds.Batch4, SeedIds.ProdNotebook, SeedIds.UnitPiece,  200m, 120000,now.AddDays(-20), "NB-009",   null)
        };

        modelBuilder.Entity<StockBatch>().HasData(stockBatches);
    }

    private static StockBatch CreateStockBatch(string id, string productId, string unitId, decimal quantity, long purchasePrice, DateTime receivedDate, string? batchNumber, DateTime? expirationDate)
    {
        var batch = StockBatch.Create(productId, unitId, quantity, purchasePrice, receivedDate, batchNumber, expirationDate);

        // Set ID and Name fields for seeding
        typeof(StockBatch).GetProperty(nameof(StockBatch.Id))!.SetValue(batch, id);
        typeof(StockBatch).GetProperty(nameof(StockBatch.ProductName))!.SetValue(batch, GetProductName(productId));
        typeof(StockBatch).GetProperty(nameof(StockBatch.UnitName))!.SetValue(batch, GetUnitName(unitId));
        typeof(StockBatch).GetProperty(nameof(StockBatch.CreatedDate))!.SetValue(batch, DateTimeService.NowUtc);
        typeof(StockBatch).GetProperty(nameof(StockBatch.UpdatedDate))!.SetValue(batch, DateTimeService.NowUtc);
        typeof(StockBatch).GetProperty(nameof(StockBatch.LastModifiedUtc))!.SetValue(batch, DateTimeService.NowUtc);

        return batch;
    }

    private static string? GetProductName(string productId) => productId switch
    {
        SeedIds.ProdCocaCola => "Coca Cola 500ml",
        SeedIds.ProdOreo     => "Oreo Biscuits",
        SeedIds.ProdNotebook => "A4 Notebook",
        _ => null
    };

    private static string? GetUnitName(string unitId) => unitId switch
    {
        SeedIds.UnitPiece  => "Piece",
        SeedIds.UnitBottle => "Bottle",
        SeedIds.UnitPack   => "Pack",
        _ => null
    };
}
