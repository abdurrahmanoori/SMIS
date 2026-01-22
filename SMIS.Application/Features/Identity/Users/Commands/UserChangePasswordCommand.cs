using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Identity.Models;

namespace SMIS.Application.Features.Identity.Users.Commands
{
    public record UserChangePasswordCommand(string UserId, ChangePasswordDto Dto) : IRequest<Result<Unit>>;

    public class UserChangePasswordCommandHandler : IRequestHandler<UserChangePasswordCommand, Result<Unit>>
    {
        private readonly IUserService _userService;
        public UserChangePasswordCommandHandler(IUserService userService)
        {
            _userService = userService;
        }
        public Task<Result<Unit>> Handle(UserChangePasswordCommand request, CancellationToken cancellationToken)
        {
            return _userService.ChangePasswordAsync(request.UserId, request.Dto);
        }
    }
}
