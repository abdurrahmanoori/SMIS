using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Enums;
using SMIS.Domain.Services;
using System.Reflection;

namespace SMIS.Infrastructure.DatabaseSeeders;

public static class StockBatchSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        var now = DateTimeService.Now;
        var stockBatches = new[]
        {
            CreateStockBatch("1", "1", "2", 100m, 40000, now.AddDays(-10), "CC-001", now.AddMonths(6)),
            CreateStockBatch("2", "1", "2", 80m, 42000, now.AddDays(-5), "CC-002", now.AddMonths(7)),
            CreateStockBatch("3", "4", "3", 50m, 25000, now.AddDays(-15), "OREO-101", now.AddMonths(3)),
            CreateStockBatch("4", "7", "1", 200m, 120000, now.AddDays(-20), "NB-009", null)
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
        typeof(StockBatch).GetProperty(nameof(StockBatch.CreatedDate))!.SetValue(batch, DateTimeService.Now);
        typeof(StockBatch).GetProperty(nameof(StockBatch.UpdatedDate))!.SetValue(batch, DateTimeService.Now);
        typeof(StockBatch).GetProperty(nameof(StockBatch.LastModifiedUtc))!.SetValue(batch, DateTimeService.NowOffSet);
        
        return batch;
    }

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
        _ => null
    };
}