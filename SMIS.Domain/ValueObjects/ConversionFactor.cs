using SMIS.Domain.Exceptions;

namespace SMIS.Domain.ValueObjects;

public sealed class ConversionFactor
{
    public decimal Value { get; }

    private ConversionFactor(decimal value) => Value = value;

    public static ConversionFactor Create(decimal conversionFactor)
    {
        if (conversionFactor <= 0)
            throw new DomainValidationException("Conversion factor must be greater than zero");

        if (conversionFactor > 1000000)
            throw new DomainValidationException("Conversion factor cannot exceed 1,000,000");

        return new ConversionFactor(conversionFactor);
    }

    public static implicit operator decimal(ConversionFactor conversionFactor) => conversionFactor.Value;
    public override string ToString() => Value.ToString();
}