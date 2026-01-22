using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Identity.Models;
using System.Collections.Generic;

namespace SMIS.Application.Features.Identity.Users.Queries
{
    public record UserGetListQuery() : IRequest<Result<List<UserDto>>>;

    public class UserGetListQueryHandler : IRequestHandler<UserGetListQuery, Result<List<UserDto>>>
    {
        private readonly IUserService _userService;
        public UserGetListQueryHandler(IUserService userService)
        {
            _userService = userService;
        }
        public Task<Result<List<UserDto>>> Handle(UserGetListQuery request, CancellationToken cancellationToken)
        {
            return _userService.GetListAsync();
        }
    }
}
