using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Identity.IServices;

/// <summary>
/// Abstraction for generating an authentication token after a successful login.
/// Each host (API, Blazor Server, MAUI) provides its own implementation.
/// </summary>
public interface ITokenGenerator
{
    /// <summary>
    /// Generates a token (JWT, cookie ticket, etc.) for the authenticated user.
    /// Returns an empty string when the host does not use token-based auth.
    /// </summary>
    string Generate(ApplicationUser user, IList<string> roles);
}
