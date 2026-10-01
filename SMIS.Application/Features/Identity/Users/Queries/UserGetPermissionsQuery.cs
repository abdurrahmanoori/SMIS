using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Auth;
using SMIS.Application.Identity.IServices;

namespace SMIS.Application.Features.Identity.Users.Queries;

public record UserGetPermissionsQuery : IRequest<Result<IReadOnlyList<ComponentPermissionDto>>>;

public sealed class UserGetPermissionsQueryHandler
    : IRequestHandler<UserGetPermissionsQuery, Result<IReadOnlyList<ComponentPermissionDto>>>
{
    private readonly ICurrentUser _currentUser;
    private readonly IComponentPermissionService _permissionService;

    public UserGetPermissionsQueryHandler(
        ICurrentUser currentUser,
        IComponentPermissionService permissionService
    )
    {
        _currentUser = currentUser;
        _permissionService = permissionService;
    }

    public async Task<Result<IReadOnlyList<ComponentPermissionDto>>> Handle(
        UserGetPermissionsQuery request,
        CancellationToken cancellationToken
    )
    {
        var permissions = await _permissionService.GetEffectivePermissionsAsync(
            _currentUser.GetId(),
            cancellationToken);

        return Result<IReadOnlyList<ComponentPermissionDto>>.Success(permissions);
    }
}
