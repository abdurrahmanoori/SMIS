using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using SMIS.Domain.Enums;

namespace SMIS.Api.Authorization;

public sealed class PermissionPolicyProvider : IAuthorizationPolicyProvider
{
    private const string Prefix = "Permission:";
    private const string TaskPrefix = "Task:";
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
        if (TryParse(policyName, out var componentKey, out var action))
        {
            var permissionPolicy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .AddRequirements(new PermissionRequirement(componentKey, action))
                .Build();

            return Task.FromResult<AuthorizationPolicy?>(permissionPolicy);
        }

        if (TryParseTask(policyName, out var taskKey))
        {
            var taskPolicy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .AddRequirements(new TaskPermissionRequirement(taskKey))
                .Build();

            return Task.FromResult<AuthorizationPolicy?>(taskPolicy);
        }

        return _fallbackPolicyProvider.GetPolicyAsync(policyName);
    }

    public static string BuildPolicyName(
        string componentKey,
        PermissionAction action
    ) => $"{Prefix}{componentKey}:{action}";

    public static string BuildTaskPolicyName(
        string taskKey
    ) => $"{TaskPrefix}{taskKey}";

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

    private static bool TryParseTask(
        string policyName,
        out string taskKey
    )
    {
        taskKey = string.Empty;
        if (!policyName.StartsWith(TaskPrefix, StringComparison.Ordinal)) return false;

        taskKey = policyName[TaskPrefix.Length..];
        return !string.IsNullOrWhiteSpace(taskKey);
    }
}
