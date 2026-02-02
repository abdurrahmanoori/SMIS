using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Users;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Features.Identity.Users.Queries
{
    public record UserGetListQuery(int PageNumber = 1, int PageSize = 25, bool includeShop = false) : IRequest<Result<PagedList<UserDto>>>;

    public class UserGetListQueryHandler : IRequestHandler<UserGetListQuery, Result<PagedList<UserDto>>>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;

        public UserGetListQueryHandler(UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<Result<PagedList<UserDto>>> Handle(UserGetListQuery request, CancellationToken cancellationToken)
        {
            var query = _userManager.Users.AsNoTracking();

            if (request.includeShop)
            {
                query = query.Include(u => u.Shop);
            }

            var totalCount = await query.CountAsync(cancellationToken);
            var users = await query
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync(cancellationToken);

            var userDtos = _mapper.Map<List<UserDto>>(users);
            
            var pagedList = new PagedList<UserDto>
            {
                PageNumber = request.PageNumber,
                PageSize = request.PageSize,
                TotalCount = totalCount,
                TotalPages = (int)Math.Ceiling((double)totalCount / request.PageSize),
                Items = userDtos
            };

            return Result<PagedList<UserDto>>.SuccessResult(pagedList);
        }
    }
}
