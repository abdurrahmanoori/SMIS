using SMIS.UI.Models;

namespace SMIS.UI.Services.Base;

public abstract class BaseService
{
    protected static string GetErrorMessage(ApiResponse<object> response)
    {
        if (!string.IsNullOrEmpty(response.Message))
            return response.Message;

        if (response.Errors?.Any() == true)
            return string.Join(", ", response.Errors.Select(e => e.Description));

        return "An error occurred";
    }

    protected static string GetErrorMessage<T>(ApiResponse<T> response)
    {
        if (!string.IsNullOrEmpty(response.Message))
            return response.Message;

        if (response.Errors?.Any() == true)
            return string.Join(", ", response.Errors.Select(e => e.Description));

        return "An error occurred";
    }

    protected static bool IsDuplicateError<T>(ApiResponse<T> response)
    {
        return response.Errors?.Any(e => e.Code?.Contains("Duplicate", StringComparison.OrdinalIgnoreCase) == true) == true;
    }

    protected static bool IsNotFoundError<T>(ApiResponse<T> response)
    {
        return response.Errors?.Any(e => e.Code == "NotFound") == true;
    }
}
