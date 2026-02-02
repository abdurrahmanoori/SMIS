using SMIS.Domain.Exceptions;

namespace SMIS.Domain.ValueObjects;

public sealed class UnitName
{
    public string Value { get; }

    private UnitName(string value) => Value = value;

    public static UnitName Create(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new DomainValidationException("Unit name cannot be empty");

        if (name.Length > 100)
            throw new DomainValidationException("Unit name cannot exceed 100 characters");

        return new UnitName(name.Trim());
    }

    public static implicit operator string(UnitName unitName) => unitName.Value;
    public override string ToString() => Value;
}