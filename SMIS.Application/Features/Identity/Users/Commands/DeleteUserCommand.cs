using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.Identity.IServices;

namespace SMIS.Application.Features.Identity.Users.Commands
{
    public record DeleteUserCommand(string UserId) : IRequest<Result<Unit>>;

    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, Result<Unit>>
    {
        private readonly IUserService _userService;
        public DeleteUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }
        public Task<Result<Unit>> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            return _userService.DeleteUserAsync(request.UserId);
        }
    }
}
