using Microsoft.AspNetCore.Authorization;

namespace SMIS.Api.Authorization;

public sealed class HasTaskPermissionAttribute : AuthorizeAttribute
{
    public HasTaskPermissionAttribute(
        string taskKey
    )
    {
        Policy = PermissionPolicyProvider.BuildTaskPolicyName(taskKey);
    }
}
