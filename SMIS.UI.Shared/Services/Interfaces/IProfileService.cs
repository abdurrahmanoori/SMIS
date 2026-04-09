using SMIS.Application.Common.Response;

namespace SMIS.UI.Shared.Services.Interfaces;

/// <summary>
/// Abstraction for loading and updating the current user's profile.
/// Each host (Web/MAUI) provides its own implementation.
/// </summary>
public interface IProfileService
{
    Task<Result<ProfileDto>> GetCurrentUserAsync();
    Task<Result> ChangePasswordAsync(string currentPassword, string newPassword);
}

public class ProfileDto
{
    public string Id { get; set; } = string.Empty;
    public string? UserName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? ShopName { get; set; }
    public string LanguageId { get; set; } = "1";
    public bool EmailConfirmed { get; set; }
    public bool PhoneNumberConfirmed { get; set; }
    public List<string> Roles { get; set; } = new();
}
