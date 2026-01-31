using SMIS.Domain.Exceptions;

namespace SMIS.Domain.ValueObjects;

public sealed class Reference
{
    public string? Value { get; }

    private Reference(string? value) => Value = value;

    public static Reference Create(string? reference)
    {
        var cleaned = reference?.Trim();

        if (cleaned?.Length > 200)
            throw new DomainValidationException("Reference cannot exceed 200 characters");

        return new Reference(cleaned);
    }

    public static implicit operator string?(Reference reference) => reference?.Value;
    public override string? ToString() => Value;
}