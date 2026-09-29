using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using SMIS.Domain.Enums;

namespace SMIS.Api.Authorization;

public sealed class PermissionPolicyProvider : IAuthorizationPolicyProvider
{
    private const string Prefix = "Permission:";
    private readonly DefaultAuthorizationPolicyProvider _fallbackPolicyProvider;

    public PermissionPolicyProvider(
        IOptions<AuthorizationOptions> options
    )
    {
        _fallbackPolicyProvider = new DefaultAuthorizationPolicyProvider(options);
    }

    public Task<AuthorizationPolicy> GetDefaultPolicyAsync() =>
        _fallbackPolicyProvider.GetDefaultPolicyAsync();

    public Task<AuthorizationPolicy?> GetFallbackPolicyAsync() =>
        _fallbackPolicyProvider.GetFallbackPolicyAsync();

    public Task<AuthorizationPolicy?> GetPolicyAsync(
        string policyName
    )
    {
        if (!TryParse(policyName, out var componentKey, out var action))
            return _fallbackPolicyProvider.GetPolicyAsync(policyName);

        var policy = new AuthorizationPolicyBuilder()
            .RequireAuthenticatedUser()
            .AddRequirements(new PermissionRequirement(componentKey, action))
            .Build();

        return Task.FromResult<AuthorizationPolicy?>(policy);
    }

    public static string BuildPolicyName(
        string componentKey,
        PermissionAction action
    ) => $"{Prefix}{componentKey}:{action}";

    private static bool TryParse(
        string policyName,
        out string componentKey,
        out PermissionAction action
    )
    {
        componentKey = string.Empty;
        action = default;

        if (!policyName.StartsWith(Prefix, StringComparison.Ordinal)) return false;

        var parts = policyName[Prefix.Length..].Split(':', 2, StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length != 2 || !Enum.TryParse(parts[1], true, out action)) return false;

        componentKey = parts[0];
        return !string.IsNullOrWhiteSpace(componentKey);
    }
}
