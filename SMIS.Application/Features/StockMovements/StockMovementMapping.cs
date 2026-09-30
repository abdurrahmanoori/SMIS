using SMIS.Application.DTO.StockMovements;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.StockMovements;

internal static class StockMovementMapping
{
    public static StockMovementDto ToDto(StockMovement movement) => new()
    {
        Id = movement.Id,
        ShopId = movement.ShopId,
        OperationId = movement.OperationId,
        StockBatchId = movement.StockBatchId,
        ProductUnitId = movement.ProductUnitId,
        QuantityEntered = movement.QuantityEntered,
        QuantityBase = movement.QuantityBase,
        Direction = movement.Direction,
        Reason = movement.Reason,
        OccurredAtUtc = movement.OccurredAtUtc,
        ReferenceType = movement.ReferenceType,
        ReferenceId = movement.ReferenceId
    };

    public static List<StockMovementDto> ToDtos(IEnumerable<StockMovement> movements) =>
        movements.Select(ToDto).ToList();
}
