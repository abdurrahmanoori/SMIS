namespace SMIS.UI.Models;

public class ApiResponse<T>
{
    public T? Response { get; set; }
    public bool Success { get; set; }
    public string? Message { get; set; }
    public List<ValidationError>? Errors { get; set; }
}

public class ValidationError
{
    public string? Code { get; set; }
    public string? Property { get; set; }
    public string? Description { get; set; }
}

public class LoginRequest
{
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}

public class LoginResponse
{
    public string Token { get; set; } = string.Empty;
    public string UserId { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public List<string> Roles { get; set; } = new();
}
