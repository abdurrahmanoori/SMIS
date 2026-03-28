namespace SMIS.UI.Shared.Services.Interfaces;

/// <summary>
/// Abstraction for establishing and clearing a host-specific authenticated session.
/// Each UI host provides its own implementation (cookie, in-memory, etc.).
/// </summary>
public interface ISignInService
{
    /// <summary>Signs in the user by their ID, establishing the host-specific session.</summary>
    Task SignInAsync(string userId);

    /// <summary>Clears the current authenticated session.</summary>
    Task SignOutAsync();

    /// <summary>Returns whether the current user has an active authenticated session.</summary>
    Task<bool> IsAuthenticatedAsync();
}
