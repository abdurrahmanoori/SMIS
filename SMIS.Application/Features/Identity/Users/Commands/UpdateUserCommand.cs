using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Identity.Models;

namespace SMIS.Application.Features.Identity.Users.Commands
{
    public record UpdateUserCommand(Guid UserId, UserUpdateDto Dto) : IRequest<Result<UserDto>>;

    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, Result<UserDto>>
    {
        private readonly IUserService _userService;
        public UpdateUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }
        public Task<Result<UserDto>> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            return _userService.UpdateUserAsync(request.UserId, request.Dto);
        }
    }
}
