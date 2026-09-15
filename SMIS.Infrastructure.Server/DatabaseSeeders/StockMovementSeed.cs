using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Enums;
using SMIS.Domain.Services;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class StockMovementSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        var now = DateTimeService.NowUtc;
        modelBuilder.Entity<StockMovement>().HasData(
            CreateReceipt(SeedIds.STrans1, SeedIds.Shop1, SeedIds.Batch1, SeedIds.PU1, 100m, now.AddDays(-10)),
            CreateReceipt(SeedIds.STrans2, SeedIds.Shop1, SeedIds.Batch2, SeedIds.PU1, 80m, now.AddDays(-5)),
            CreateReceipt(SeedIds.STrans3, SeedIds.Shop1, SeedIds.Batch3, SeedIds.PU10, 50m, now.AddDays(-15)),
            CreateReceipt(SeedIds.STrans4, SeedIds.Shop1, SeedIds.Batch4, SeedIds.PU19, 200m, now.AddDays(-20))
        );
    }

    private static StockMovement CreateReceipt(
        string id,
        string shopId,
        string batchId,
        string productUnitId,
        decimal quantity,
        DateTime occurredAtUtc)
    {
        var movement = StockMovement.Create(
            shopId,
            batchId,
            productUnitId,
            quantity,
            quantity,
            StockMovementDirection.In,
            StockMovementReason.PurchaseReceipt,
            occurredAtUtc,
            "Seed",
            batchId);

        typeof(StockMovement).GetProperty(nameof(StockMovement.Id))!.SetValue(movement, id);
        typeof(StockMovement).GetProperty(nameof(StockMovement.CreatedDate))!.SetValue(movement, DateTimeService.NowUtc);
        typeof(StockMovement).GetProperty(nameof(StockMovement.UpdatedDate))!.SetValue(movement, DateTimeService.NowUtc);
        typeof(StockMovement).GetProperty(nameof(StockMovement.LastModifiedUtc))!.SetValue(movement, DateTimeService.NowUtc);
        return movement;
    }
}
