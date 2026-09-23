using SMIS.Domain.Entities;

namespace SMIS.Application.Features.UnitOfMeasures.Commands;

/// <summary>
/// Business mutations shared by direct online commands and offline sync commands.
/// </summary>
internal static class UnitOfMeasureCommandRules
{
    public static UnitOfMeasure Create(
        string name,
        string? symbol,
        string? description
    ) =>
        UnitOfMeasure.Create(name, symbol, description);

    public static void Apply(
        UnitOfMeasure unit,
        string name,
        string? symbol,
        string? description
    )
    {
        unit.SetName(name);
        unit.SetSymbol(symbol);
        unit.SetDescription(description);
    }
}