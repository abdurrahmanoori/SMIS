using Microsoft.AspNetCore.Authorization;

namespace SMIS.Api.Authorization;

public sealed record TaskPermissionRequirement(
    string TaskKey
) : IAuthorizationRequirement;
