using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Identity.Models;

namespace SMIS.Application.Features.Identity.Users.Commands
{
    public record UserUpdateCommand(string UserId, UserUpdateDto Dto) : IRequest<Result<UserDto>>;

    public class UserUpdateCommandHandler : IRequestHandler<UserUpdateCommand, Result<UserDto>>
    {
        private readonly IUserService _userService;
        public UserUpdateCommandHandler(IUserService userService)
        {
            _userService = userService;
        }
        public Task<Result<UserDto>> Handle(UserUpdateCommand request, CancellationToken cancellationToken)
        {
            return _userService.UpdateUserAsync(request.UserId, request.Dto);
        }
    }
}
