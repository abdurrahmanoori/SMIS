using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.Identity.IServices;

namespace SMIS.Application.Features.Identity.Users.Commands
{
    public record UserDeleteCommand(string UserId) : IRequest<Result<Unit>>;

    public class UserDeleteCommandHandler : IRequestHandler<UserDeleteCommand, Result<Unit>>
    {
        private readonly IUserService _userService;
        public UserDeleteCommandHandler(IUserService userService)
        {
            _userService = userService;
        }
        public Task<Result<Unit>> Handle(UserDeleteCommand request, CancellationToken cancellationToken)
        {
            return _userService.DeleteUserAsync(request.UserId);
        }
    }
}
