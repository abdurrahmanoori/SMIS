using SMIS.Domain.Exceptions;

namespace SMIS.Domain.ValueObjects;

public sealed class SKU
{
    public string? Value { get; }

    private SKU(string? value) => Value = value;

    public static SKU Create(string? sku)
    {
        //if (string.IsNullOrWhiteSpace(sku))
        //    throw new DomainValidationException("SKU cannot be empty");

        var cleaned = sku?.Trim().ToUpperInvariant();

        if (cleaned?.Length > 50)
            throw new DomainValidationException("SKU cannot exceed 50 characters");

        return new SKU(cleaned);
    }

    public static implicit operator string?(SKU sku) => sku?.Value;
    public override string? ToString() => Value;
}
