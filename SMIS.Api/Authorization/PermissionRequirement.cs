using Microsoft.AspNetCore.Authorization;
using SMIS.Domain.Enums;

namespace SMIS.Api.Authorization;

public sealed record PermissionRequirement(
    string ComponentKey,
    PermissionAction Action
) : IAuthorizationRequirement;
