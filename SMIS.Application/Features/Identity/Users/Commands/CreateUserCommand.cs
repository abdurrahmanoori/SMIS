using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Identity.Models;

namespace SMIS.Application.Features.Identity.Users.Commands
{
    public record CreateUserCommand(UserCreateDto Dto) : IRequest<Result<int>>;

    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Result<int>>
    {
        private readonly IUserService _userService;
        public CreateUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }
        public Task<Result<int>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            return _userService.CreateUserAsync(request.Dto);
        }
    }
}
