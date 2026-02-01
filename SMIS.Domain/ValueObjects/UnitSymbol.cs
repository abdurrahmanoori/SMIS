using SMIS.Domain.Exceptions;

namespace SMIS.Domain.ValueObjects;

public sealed class UnitSymbol
{
    public string? Value { get; }

    private UnitSymbol(string? value) => Value = value;

    public static UnitSymbol Create(string? symbol)
    {
        var cleaned = symbol?.Trim();

        if (cleaned?.Length > 10)
            throw new DomainValidationException("Unit symbol cannot exceed 10 characters");

        return new UnitSymbol(cleaned);
    }

    public static implicit operator string?(UnitSymbol unitSymbol) => unitSymbol?.Value;
    public override string? ToString() => Value;
}