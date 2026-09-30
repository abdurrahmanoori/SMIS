using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.Identity.IServices;

namespace SMIS.Application.Features.Identity.Users.Queries;

public record UserGetTaskPermissionsQuery : IRequest<Result<IReadOnlyList<string>>>;

public sealed class UserGetTaskPermissionsQueryHandler
    : IRequestHandler<UserGetTaskPermissionsQuery, Result<IReadOnlyList<string>>>
{
    private readonly ICurrentUser _currentUser;
    private readonly ITaskPermissionService _permissionService;

    public UserGetTaskPermissionsQueryHandler(
        ICurrentUser currentUser,
        ITaskPermissionService permissionService
    )
    {
        _currentUser = currentUser;
        _permissionService = permissionService;
    }

    public async Task<Result<IReadOnlyList<string>>> Handle(
        UserGetTaskPermissionsQuery request,
        CancellationToken cancellationToken
    )
    {
        var permissions = await _permissionService.GetEffectiveTaskPermissionsAsync(
            _currentUser.GetId(),
            cancellationToken);

        return Result<IReadOnlyList<string>>.Success(permissions);
    }
}
