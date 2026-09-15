using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class StockBatchSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        var now = DateTimeService.NowUtc;
        modelBuilder.Entity<StockBatch>().HasData(
            CreateStockBatch(SeedIds.Batch1, SeedIds.Shop1, SeedIds.ProdCocaCola, SeedIds.PU1, 100m, 40000, now.AddDays(-10), "CC-001", now.AddMonths(6)),
            CreateStockBatch(SeedIds.Batch2, SeedIds.Shop1, SeedIds.ProdCocaCola, SeedIds.PU1, 80m, 42000, now.AddDays(-5), "CC-002", now.AddMonths(7)),
            CreateStockBatch(SeedIds.Batch3, SeedIds.Shop1, SeedIds.ProdOreo, SeedIds.PU10, 50m, 25000, now.AddDays(-15), "OREO-101", now.AddMonths(3)),
            CreateStockBatch(SeedIds.Batch4, SeedIds.Shop1, SeedIds.ProdNotebook, SeedIds.PU19, 200m, 120000, now.AddDays(-20), "NB-009", null)
        );
    }

    private static StockBatch CreateStockBatch(
        string id,
        string shopId,
        string productId,
        string productUnitId,
        decimal quantity,
        long unitCostBase,
        DateTime receivedAtUtc,
        string? batchNumber,
        DateTime? expirationDate)
    {
        var batch = StockBatch.Create(
            shopId,
            productId,
            productUnitId,
            quantity,
            1m,
            unitCostBase,
            receivedAtUtc,
            batchNumber,
            expirationDate);

        typeof(StockBatch).GetProperty(nameof(StockBatch.Id))!.SetValue(batch, id);
        typeof(StockBatch).GetProperty(nameof(StockBatch.CreatedDate))!.SetValue(batch, DateTimeService.NowUtc);
        typeof(StockBatch).GetProperty(nameof(StockBatch.UpdatedDate))!.SetValue(batch, DateTimeService.NowUtc);
        typeof(StockBatch).GetProperty(nameof(StockBatch.LastModifiedUtc))!.SetValue(batch, DateTimeService.NowUtc);
        return batch;
    }
}
