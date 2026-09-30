using SMIS.Application.DTO.UnitOfMeasures;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.UnitOfMeasures;

internal static class UnitOfMeasureMapping
{
    public static UnitOfMeasureDto ToDto(UnitOfMeasure unit) => new()
    {
        Id = unit.Id,
        Name = unit.Name,
        Symbol = unit.Symbol,
        Description = unit.Description,
        ClientModifiedDate = AsUtc(unit.ClientModifiedDate),
        LastModifiedUtc = AsUtc(unit.LastModifiedUtc),
        IsDeleted = unit.IsDeleted
    };

    private static DateTime AsUtc(DateTime value) => value.Kind switch
    {
        DateTimeKind.Utc => value,
        DateTimeKind.Local => value.ToUniversalTime(),
        _ => DateTime.SpecifyKind(value, DateTimeKind.Utc)
    };

    private static DateTime? AsUtc(DateTime? value) =>
        value.HasValue ? AsUtc(value.Value) : null;
}
