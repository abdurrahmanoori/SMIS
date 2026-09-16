namespace SMIS.Domain.Enums;

/// <summary>
/// Explains why inventory changed. Keeping reason separate from direction allows,
/// for example, customer returns (IN) and supplier returns (OUT) to remain explicit.
/// </summary>
public enum StockMovementReason
{
    PurchaseReceipt,
    Sale,
    CustomerReturn,
    SupplierReturn,
    Damage,
    Expiration,
    Adjustment,
    Transfer
}