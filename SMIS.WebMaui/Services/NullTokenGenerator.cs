using SMIS.Application.Identity.IServices;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.WebMaui.Services;

/// <summary>
/// No-op ITokenGenerator for Blazor Server.
/// LoginCommand is called for credential validation only.
/// The token string is unused — authentication is handled by the Identity cookie via SignInManager.
/// </summary>
public class NullTokenGenerator : ITokenGenerator
{
    public string Generate(ApplicationUser user, IList<string> roles) => string.Empty;
}
