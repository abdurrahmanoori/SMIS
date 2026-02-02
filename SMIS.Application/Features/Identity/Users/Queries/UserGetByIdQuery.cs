using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Users;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Features.Identity.Users.Queries
{
    public record UserGetByIdQuery(string UserId, bool includeShop = false) : IRequest<Result<UserDto>>;

    public class UserGetByIdQueryHandler : IRequestHandler<UserGetByIdQuery, Result<UserDto>>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;

        public UserGetByIdQueryHandler(UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<Result<UserDto>> Handle(UserGetByIdQuery request, CancellationToken cancellationToken)
        {
            var query = _userManager.Users.AsNoTracking();

            if (request.includeShop)
            {
                query = query.Include(u => u.Shop);
            }

            var user = await query.FirstOrDefaultAsync(u => u.Id == request.UserId, cancellationToken);
            if (user == null) return Result<UserDto>.NotFoundResult(request.UserId);

            var userDto = _mapper.Map<UserDto>(user);
            return Result<UserDto>.SuccessResult(userDto);
        }
    }
}
