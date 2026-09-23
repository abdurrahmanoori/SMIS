using SMIS.Domain.Exceptions;

namespace SMIS.Domain.ValueObjects;

public sealed class BaseUnitQuantity
{
    public decimal Value { get; }

    private BaseUnitQuantity(
        decimal value
    ) => Value = value;

    public static BaseUnitQuantity Create(
        decimal baseUnitQuantity
    )
    {
        if (baseUnitQuantity <= 0)
            throw new DomainValidationException("Base unit quantity must be greater than zero");

        if (baseUnitQuantity > 1000000)
            throw new DomainValidationException("Base unit quantity cannot exceed 1,000,000");

        return new BaseUnitQuantity(baseUnitQuantity);
    }

    public static implicit operator decimal(
        BaseUnitQuantity baseUnitQuantity
    ) => baseUnitQuantity.Value;

    public override string ToString() => Value.ToString();
}