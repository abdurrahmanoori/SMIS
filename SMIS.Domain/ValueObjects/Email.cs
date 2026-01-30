using SMIS.Domain.Exceptions;
using System.Text.RegularExpressions;

namespace SMIS.Domain.ValueObjects;

public sealed class Email
{
    private static readonly Regex EmailRegex = new(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);

    public string Value { get; }

    private Email(string value) => Value = value;

    public static Email Create(string email)
    {
        //if (string.IsNullOrWhiteSpace(email))
        //    throw new DomainValidationException("Email cannot be empty");

        if (email.Length > 100)
            throw new DomainValidationException("Email cannot exceed 100 characters");

        if (!EmailRegex.IsMatch(email))
            throw new DomainValidationException("Invalid email format");

        return new Email(email.Trim().ToLowerInvariant());
    }

    public static implicit operator string(Email email) => email.Value;
    public override string ToString() => Value;
}
