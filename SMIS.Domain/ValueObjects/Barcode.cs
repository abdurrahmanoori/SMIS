using SMIS.Domain.Exceptions;
using System.Text.RegularExpressions;

namespace SMIS.Domain.ValueObjects
{
    public sealed class Barcode
    {
        private static readonly Regex BarcodeRegex = new(@"^[\d\-]+$", RegexOptions.Compiled);

        public string Value { get; }

        private Barcode(string value) => Value = value;

        public static Barcode Create(string barcode)
        {
            var cleaned = barcode.Trim();

            if (cleaned.Length < 8 || cleaned.Length > 50)
                throw new DomainValidationException("Barcode must be between 8 and 50 characters");

            if (!BarcodeRegex.IsMatch(cleaned))
                throw new DomainValidationException("Barcode can only contain digits and hyphens");

            return new Barcode(cleaned);
        }

        public static implicit operator string(Barcode barcode) => barcode.Value;
        public override string ToString() => Value;
    }
}
