using Microsoft.AspNetCore.Authorization;
using SMIS.Domain.Enums;

namespace SMIS.Api.Authorization;

public sealed class HasPermissionAttribute : AuthorizeAttribute
{
    public HasPermissionAttribute(
        string componentKey,
        PermissionAction action
    )
    {
        Policy = PermissionPolicyProvider.BuildPolicyName(componentKey, action);
    }
}
