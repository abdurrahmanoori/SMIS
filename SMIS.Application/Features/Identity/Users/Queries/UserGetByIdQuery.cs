using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Identity.Models;

namespace SMIS.Application.Features.Identity.Users.Queries
{
    public record UserGetByIdQuery(string UserId) : IRequest<Result<UserDto>>;

    public class UserGetByIdQueryHandler : IRequestHandler<UserGetByIdQuery, Result<UserDto>>
    {
        private readonly IUserService _userService;
        public UserGetByIdQueryHandler(IUserService userService)
        {
            _userService = userService;
        }
        public Task<Result<UserDto>> Handle(UserGetByIdQuery request, CancellationToken cancellationToken)
        {
            return _userService.GetByIdAsync(request.UserId);
        }
    }
}
