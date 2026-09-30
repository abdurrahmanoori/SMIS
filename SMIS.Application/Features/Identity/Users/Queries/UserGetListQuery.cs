using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Users;
using SMIS.Application.Services;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Features.Identity.Users.Queries
{
    public record UserGetListQuery(int PageNumber = 1, int PageSize = 25, bool includeShop = false)
        : IRequest<Result<PagedList<UserDto>>>;

    public class UserGetListQueryHandler : IRequestHandler<UserGetListQuery, Result<PagedList<UserDto>>>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IApplicationDbContext _context;

        public UserGetListQueryHandler(
            UserManager<ApplicationUser> userManager,
            IMapper mapper,
            IApplicationDbContext context
        )
        {
            _userManager = userManager;
            _mapper = mapper;
            _context = context;
        }

        public async Task<Result<PagedList<UserDto>>> Handle(
            UserGetListQuery request,
            CancellationToken cancellationToken
        )
        {
            var query = _userManager.Users.AsNoTracking();

            if (request.includeShop)
            {
                query = query.Include(u => u.Shop);
            }

            var totalCount = await query.CountAsync(cancellationToken);
            var users = await query
                .OrderBy(user => user.UserName)
                .ThenBy(user => user.Id)
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync(cancellationToken);

            var userDtos = _mapper.Map<List<UserDto>>(users);

            var userIds = users.Select(user => user.Id).ToArray();
            var roleRows = await (
                    from userRole in _context.UserRoles.AsNoTracking()
                    join role in _context.Roles.AsNoTracking()
                        on userRole.RoleId equals role.Id
                    where userIds.Contains(userRole.UserId)
                    select new { userRole.UserId, RoleName = role.Name })
                .ToListAsync(cancellationToken);

            var roleLookup = roleRows
                .Where(row => !string.IsNullOrWhiteSpace(row.RoleName))
                .GroupBy(row => row.UserId)
                .ToDictionary(
                    group => group.Key,
                    group => group.Select(row => row.RoleName!)
                        .OrderBy(role => role, StringComparer.OrdinalIgnoreCase)
                        .ToList());

            foreach (var userDto in userDtos)
            {
                userDto.Roles = roleLookup.GetValueOrDefault(userDto.Id, []);
            }

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