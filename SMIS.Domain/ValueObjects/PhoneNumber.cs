using SMIS.Domain.Exceptions;
using System.Text.RegularExpressions;

namespace SMIS.Domain.ValueObjects
{
    public sealed class PhoneNumber
    {
        private static readonly Regex PhoneRegex = new(@"^\+?[\d\s\-()]+$", RegexOptions.Compiled);

        public string Value { get; }

        private PhoneNumber(string value) => Value = value;

        public static PhoneNumber Create(string phoneNumber)
        {
            //if (string.IsNullOrWhiteSpace(phoneNumber))
            //    throw new DomainValidationException("Phone number cannot be empty");

            var cleaned = phoneNumber.Trim();

            if (cleaned.Length < 8 || cleaned.Length > 20)
                throw new DomainValidationException("Phone number must be between 8 and 20 characters");

            if (!PhoneRegex.IsMatch(cleaned))
                throw new DomainValidationException("Invalid phone number format");

            return new PhoneNumber(cleaned);
        }

        public static implicit operator string(PhoneNumber phoneNumber) => phoneNumber.Value;
        public override string ToString() => Value;
    }
}
