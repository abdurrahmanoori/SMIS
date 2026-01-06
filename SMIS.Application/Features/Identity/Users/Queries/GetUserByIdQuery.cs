using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Identity.Models;

namespace SMIS.Application.Features.Identity.Users.Queries
{
    public record GetUserByIdQuery(Guid UserId) : IRequest<Result<UserDto>>;

    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, Result<UserDto>>
    {
        private readonly IUserService _userService;
        public GetUserByIdQueryHandler(IUserService userService)
        {
            _userService = userService;
        }
        public Task<Result<UserDto>> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            return _userService.GetByIdAsync(request.UserId);
        }
    }
}
