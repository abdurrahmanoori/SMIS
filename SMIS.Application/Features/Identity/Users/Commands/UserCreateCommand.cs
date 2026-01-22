using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Identity.Models;

namespace SMIS.Application.Features.Identity.Users.Commands
{
    public record UserCreateCommand(UserCreateDto Dto) : IRequest<Result<string>>;

    public class UserCreateCommandHandler : IRequestHandler<UserCreateCommand, Result<string>>
    {
        private readonly IUserService _userService;
        public UserCreateCommandHandler(IUserService userService)
        {
            _userService = userService;
        }
        public async Task<Result<string>> Handle(UserCreateCommand request, CancellationToken cancellationToken)
        {
            return await _userService.CreateUserAsync(request.Dto);
        }
    }
}
