using SMIS.Domain.Exceptions;
using System.Text.RegularExpressions;

namespace SMIS.Domain.ValueObjects;

public sealed class CategoryCode
{
    //private static readonly Regex CodeRegex = new(@"^[A-Z0-9_-]+$", RegexOptions.Compiled);

    public string Value { get; }

    private CategoryCode(string value) => Value = value;

    public static CategoryCode? Create(string? code)
    {
        if (code == null)
            return null;

        var cleaned = code.Trim().ToUpperInvariant();

        if (cleaned.Length > 50)
            throw new DomainValidationException("Category code cannot exceed 50 characters");

        //if (!CodeRegex.IsMatch(cleaned))
        //    throw new DomainValidationException("Category code can only contain letters, numbers, underscores, and hyphens");

        return new CategoryCode(cleaned);
    }

    public static implicit operator string?(CategoryCode? code) => code?.Value;
    public override string ToString( ) => Value;
}