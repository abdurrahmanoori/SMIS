using FluentValidation;

namespace SMIS.Application.Validators;

public static class AfghanistanPhoneNumberValidator
{
    public static IRuleBuilderOptions<T, string?> AfghanistanPhoneNumber<T>(this IRuleBuilder<T, string?> ruleBuilder)
    {
        return ruleBuilder
            .Must(phone => string.IsNullOrWhiteSpace(phone) || IsValidAfghanistanPhone(phone))
            .WithMessage("Phone number must be a valid Afghanistan number (e.g., +93701234567 or 0701234567)");
    }

    private static bool IsValidAfghanistanPhone(string phone)
    {
        var cleaned = phone.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "");
        
        // +93 followed by 9 digits (70-79 for mobile)
        if (cleaned.StartsWith("+93") && cleaned.Length == 12)
            return cleaned[3] == '7' && cleaned.Substring(3).All(char.IsDigit);
        
        // 0 followed by 9 digits (070-079 for mobile)
        if (cleaned.StartsWith("0") && cleaned.Length == 10)
            return cleaned[1] == '7' && cleaned.Substring(1).All(char.IsDigit);
        
        return false;
    }
}
