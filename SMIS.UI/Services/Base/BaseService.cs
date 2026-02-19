using SMIS.UI.Models;
using SMIS.UI.Services.Http;

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

    protected static async Task<ApiResponse<List<TDto>>> GetPagedListAsync<TDto>(
        IApiClient apiClient, 
        string endpoint)
    {
        var result = await apiClient.GetAsync<PagedList<TDto>>(endpoint);
        
        if (result.Success && result.Response != null)
        {
            return new ApiResponse<List<TDto>>
            {
                Success = true,
                Response = result.Response.Items,
                Message = result.Message
            };
        }
        
        return new ApiResponse<List<TDto>>
        {
            Success = result.Success,
            Message = result.Message,
            Errors = result.Errors
        };
    }

    protected static ApiResponse<T> CreateError<T>(string code, string description)
    {
        return new ApiResponse<T>
        {
            Success = false,
            Errors = new List<ValidationError> { new() { Code = code, Description = description } }
        };
    }
}
