using SMIS.Application.Common.Response;

namespace SMIS.UI.Shared.Helpers;

public static class ValidationHelper
{
    public static Dictionary<string, string> ExtractValidationErrors<T>(Result<T> result)
    {
        var errors = new Dictionary<string, string>();

        if (result.Errors != null && result.Errors.Any())
        {
            foreach (var error in result.Errors)
            {
                if (!string.IsNullOrEmpty(error.Property))
                {
                    var propertyName = CapitalizeFirstLetter(error.Property);
                    errors[propertyName] = error.Description ?? "Invalid value";
                }
            }
        }

        return errors;
    }

    public static string GetValidationMessage(Dictionary<string, string> validationErrors, string propertyName)
        => validationErrors.TryGetValue(propertyName, out var message) ? message : string.Empty;

    public static bool HasValidationError(Dictionary<string, string> validationErrors, string propertyName)
        => validationErrors.ContainsKey(propertyName);

    private static string CapitalizeFirstLetter(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        return char.ToUpper(input[0]) + input.Substring(1);
    }
}
