using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.Identity.IServices;

namespace SMIS.Application.Features.Identity.Users.Commands
{
    public record AssignRolesCommand(Guid UserId, IEnumerable<string> Roles) : IRequest<Result<Unit>>;

    public class AssignRolesCommandHandler : IRequestHandler<AssignRolesCommand, Result<Unit>>
    {
        private readonly IUserService _userService;
        public AssignRolesCommandHandler(IUserService userService)
        {
            _userService = userService;
        }
        public Task<Result<Unit>> Handle(AssignRolesCommand request, CancellationToken cancellationToken)
        {
            return _userService.AssignRolesAsync(request.UserId, request.Roles);
        }
    }
}
