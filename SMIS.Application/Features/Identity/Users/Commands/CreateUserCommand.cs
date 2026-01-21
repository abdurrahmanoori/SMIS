using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Identity.Models;

namespace SMIS.Application.Features.Identity.Users.Commands
{
    public record CreateUserCommand(UserCreateDto Dto) : IRequest<Result<string>>;

    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Result<string>>
    {
        private readonly IUserService _userService;
        public CreateUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }
        public async Task<Result<string>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            return await _userService.CreateUserAsync(request.Dto);
        }
    }
}
