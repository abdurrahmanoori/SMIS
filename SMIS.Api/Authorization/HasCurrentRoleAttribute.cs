using Microsoft.AspNetCore.Authorization;

namespace SMIS.Api.Authorization;

public sealed class HasCurrentRoleAttribute : AuthorizeAttribute
{
    public HasCurrentRoleAttribute(
        string roleName
    )
    {
        Policy = PermissionPolicyProvider.BuildCurrentRolePolicyName(roleName);
    }
}
