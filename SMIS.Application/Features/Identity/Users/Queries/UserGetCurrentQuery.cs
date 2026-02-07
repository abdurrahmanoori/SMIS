using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Users;
using SMIS.Application.Identity.IServices;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Features.Identity.Users.Queries;

public record UserGetCurrentQuery(bool IncludeShop = false) : IRequest<Result<UserDto>>;

public class UserGetCurrentQueryHandler : IRequestHandler<UserGetCurrentQuery, Result<UserDto>>
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ICurrentUser _currentUser;
    private readonly IMapper _mapper;

    public UserGetCurrentQueryHandler(UserManager<ApplicationUser> userManager, ICurrentUser currentUser, IMapper mapper)
    {
        _userManager = userManager;
        _currentUser = currentUser;
        _mapper = mapper;
    }

    public async Task<Result<UserDto>> Handle(UserGetCurrentQuery request, CancellationToken cancellationToken)
    {
        var userId = _currentUser.GetId();
        var query = _userManager.Users.AsNoTracking();

        if (request.IncludeShop)
        {
            query = query.Include(u => u.Shop);
        }

        var user = await query.FirstOrDefaultAsync(u => u.Id == userId, cancellationToken);
        if (user == null) return Result<UserDto>.NotFoundResult(userId);

        var userDto = _mapper.Map<UserDto>(user);
        userDto.Roles = (await _userManager.GetRolesAsync(user)).ToList();
        
        return Result<UserDto>.SuccessResult(userDto);
    }
}
