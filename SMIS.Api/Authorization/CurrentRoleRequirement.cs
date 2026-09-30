using Microsoft.AspNetCore.Authorization;

namespace SMIS.Api.Authorization;

public sealed record CurrentRoleRequirement(
    string RoleName
) : IAuthorizationRequirement;
