using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Identity.Models;
using System.Collections.Generic;

namespace SMIS.Application.Features.Identity.Users.Queries
{
    public record GetUserListQuery() : IRequest<Result<List<UserDto>>>;

    public class GetUserListQueryHandler : IRequestHandler<GetUserListQuery, Result<List<UserDto>>>
    {
        private readonly IUserService _userService;
        public GetUserListQueryHandler(IUserService userService)
        {
            _userService = userService;
        }
        public Task<Result<List<UserDto>>> Handle(GetUserListQuery request, CancellationToken cancellationToken)
        {
            return _userService.GetListAsync();
        }
    }
}
