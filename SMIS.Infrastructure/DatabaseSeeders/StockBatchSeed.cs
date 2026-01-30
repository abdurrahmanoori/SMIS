using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Enums;
using System.Reflection;

namespace SMIS.Infrastructure.DatabaseSeeders;

public static class StockBatchSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        var stockBatches = new[]
        {
            CreateStockBatch("1", "1", "1", 100m, 40000, DateTime.UtcNow.AddDays(-10), "CC-001", DateTime.UtcNow.AddMonths(6)),
            CreateStockBatch("2", "1", "1", 80m, 42000, DateTime.UtcNow.AddDays(-5), "CC-002", DateTime.UtcNow.AddMonths(7)),
            CreateStockBatch("3", "2", "2", 50m, 25000, DateTime.UtcNow.AddDays(-15), "BS-101", DateTime.UtcNow.AddMonths(3)),
            CreateStockBatch("4", "3", "3", 200m, 120000, DateTime.UtcNow.AddDays(-20), "NB-009", null)
        };

        modelBuilder.Entity<StockBatch>().HasData(stockBatches);
    }

    private static StockBatch CreateStockBatch(string id, string productId, string unitId, decimal quantity, long purchasePrice, DateTime receivedDate, string? batchNumber, DateTime? expirationDate)
    {
        var batch = StockBatch.Create(productId, unitId, quantity, purchasePrice, receivedDate, batchNumber, expirationDate);
        
        // Set ID for seeding (bypass domain validation for infrastructure concerns)
        typeof(StockBatch).GetProperty(nameof(StockBatch.Id))!.SetValue(batch, id);
        
        return batch;
    }
}