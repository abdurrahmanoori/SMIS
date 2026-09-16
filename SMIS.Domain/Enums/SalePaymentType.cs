namespace SMIS.Domain.Enums;

/// <summary>
/// Describes whether a completed sale creates customer debt. This classification never
/// changes inventory behavior: cash and credit sales both issue stock immediately.
/// </summary>
public enum SalePaymentType
{
    Cash = 1,
    Credit = 2
}