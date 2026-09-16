namespace SMIS.Domain.Enums;

/// <summary>
/// Describes whether a movement increases or decreases physical stock.
/// The business reason is modeled separately by <see cref="StockMovementReason"/>.
/// </summary>
public enum StockMovementDirection
{
    In,
    Out
}