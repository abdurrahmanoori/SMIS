using SMIS.Application.DTO.StockBatches;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.StockBatches;

internal static class StockBatchMapping
{
    public static StockBatchDto ToDto(StockBatch batch) => new()
    {
        Id = batch.Id,
        ShopId = batch.ShopId,
        ProductId = batch.ProductId,
        ReceivedProductUnitId = batch.ReceivedProductUnitId,
        ReceivedQuantity = batch.ReceivedQuantity,
        ReceivedQuantityBase = batch.ReceivedQuantityBase,
        RemainingQuantityBase = batch.RemainingQuantityBase,
        UnitCostBase = batch.UnitCostBase,
        BatchNumber = batch.BatchNumber,
        ReceivedAtUtc = batch.ReceivedAtUtc,
        ExpirationDate = batch.ExpirationDate,
        Status = batch.Status
    };
}
