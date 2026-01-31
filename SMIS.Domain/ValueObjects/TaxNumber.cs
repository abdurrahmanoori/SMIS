using SMIS.Domain.Exceptions;
using System.Text.RegularExpressions;

namespace SMIS.Domain.ValueObjects;

public sealed class TaxNumber
{
    private static readonly Regex TaxRegex = new(@"^[A-Z0-9\-]+$", RegexOptions.Compiled);

    public string Value { get; }

    private TaxNumber(string value) => Value = value;

    public static TaxNumber Create(string taxNumber)
    {
    //    if (string.IsNullOrWhiteSpace(taxNumber))
    //        throw new DomainValidationException("Tax number cannot be empty");

        var cleaned = taxNumber.Trim().ToUpperInvariant();

        if (cleaned.Length < 5 || cleaned.Length > 20)
            throw new DomainValidationException("Tax number must be between 5 and 20 characters");

        if (!TaxRegex.IsMatch(cleaned))
            throw new DomainValidationException("Tax number can only contain letters, numbers, and hyphens");

        return new TaxNumber(cleaned);
    }

    public static implicit operator string(TaxNumber taxNumber) => taxNumber.Value;
    public override string ToString() => Value;
}
