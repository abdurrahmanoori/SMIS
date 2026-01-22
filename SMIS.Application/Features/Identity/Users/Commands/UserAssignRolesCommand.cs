using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.Identity.IServices;

namespace SMIS.Application.Features.Identity.Users.Commands
{
    public record UserAssignRolesCommand(string UserId, IEnumerable<string> Roles) : IRequest<Result<Unit>>;

    public class UserAssignRolesCommandHandler : IRequestHandler<UserAssignRolesCommand, Result<Unit>>
    {
        private readonly IUserService _userService;
        public UserAssignRolesCommandHandler(IUserService userService)
        {
            _userService = userService;
        }
        public Task<Result<Unit>> Handle(UserAssignRolesCommand request, CancellationToken cancellationToken)
        {
            return _userService.AssignRolesAsync(request.UserId, request.Roles);
        }
    }
}
