using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Shops;
using SMIS.Application.DTO.Users;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Common.Contants;
using SMIS.Application.Services;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Features.Identity.Users.Queries;

public sealed record UserQuery(
    EntityDropdown<UserQueryCriteria> Query,
    bool IncludeShop = false
)
    : IRequest<Result<PagedListNew<UserDto>>>;

internal sealed class UserQueryHandler
    : IRequestHandler<UserQuery, Result<PagedListNew<UserDto>>>
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IApplicationDbContext _context;
    private readonly ICurrentUser _currentUser;

    public UserQueryHandler(
        UserManager<ApplicationUser> userManager,
        IApplicationDbContext context,
        ICurrentUser currentUser
    )
    {
        _userManager = userManager;
        _context = context;
        _currentUser = currentUser;
    }

    public async Task<Result<PagedListNew<UserDto>>> Handle(
        UserQuery request,
        CancellationToken cancellationToken
    )
    {
        var now = DateTimeOffset.UtcNow;
        var signedInUser = await _userManager.FindByIdAsync(_currentUser.GetId());
        if (signedInUser is null)
            return Result<PagedListNew<UserDto>>.Forbidden(
                "user.administration_forbidden",
                "You are not allowed to manage users.");

        var isSuperAdmin = await _userManager.IsInRoleAsync(signedInUser, SD.Role_Super_Admin);
        var isShopAdmin = await _userManager.IsInRoleAsync(signedInUser, SD.Role_Shop_Admin);
        if (!isSuperAdmin && !isShopAdmin)
            return Result<PagedListNew<UserDto>>.Forbidden(
                "user.administration_forbidden",
                "You are not allowed to manage users.");

        IQueryable<ApplicationUser> users = _userManager.Users.AsNoTracking();
        if (!isSuperAdmin)
        {
            users = users.Where(user =>
                user.ShopId == signedInUser.ShopId && user.Id != signedInUser.Id);

            var superAdminRoleId = await _context.Roles
                .AsNoTracking()
                .Where(role => role.Name == SD.Role_Super_Admin)
                .Select(role => role.Id)
                .FirstOrDefaultAsync(cancellationToken);

            if (!string.IsNullOrWhiteSpace(superAdminRoleId))
            {
                users = users.Where(user => !_context.UserRoles
                    .AsNoTracking()
                    .Any(userRole =>
                        userRole.UserId == user.Id && userRole.RoleId == superAdminRoleId));
            }
        }

        var query = users
            .OrderBy(user => user.UserName)
            .ThenBy(user => user.Id)
            .Select(user => new UserDto
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                FirstName = user.FirstName,
                LastName = user.LastName,
                ShopId = user.ShopId,
                LanguageId = user.LanguageId,
                EmailConfirmed = user.EmailConfirmed,
                PhoneNumberConfirmed = user.PhoneNumberConfirmed,
                IsActive = user.IsActive,
                IsLocked = user.LockoutEnabled && user.LockoutEnd.HasValue && user.LockoutEnd > now,
                LockoutEnd = user.LockoutEnd,
                Shop = request.IncludeShop
                    ? _context.Shops
                        .Where(shop => shop.Id == user.ShopId)
                        .Select(shop => new ShopDto
                        {
                            Id = shop.Id,
                            Name = shop.Name,
                            ShopType = shop.ShopType,
                            Address = shop.Address,
                            PhoneNumber = shop.PhoneNumber,
                            Email = shop.Email,
                            TaxNumber = shop.TaxNumber,
                            IsActive = shop.IsActive,
                            LastModifiedUtc = shop.LastModifiedUtc,
                            IsDeleted = shop.IsDeleted,
                            ClientModifiedDate = shop.ClientModifiedDate
                        })
                        .FirstOrDefault()
                    : null,
                Roles = (
                        from userRole in _context.UserRoles.AsNoTracking()
                        join role in _context.Roles.AsNoTracking()
                            on userRole.RoleId equals role.Id
                        where userRole.UserId == user.Id && role.Name != null
                        orderby role.Name
                        select role.Name!)
                    .ToList()
            });

        var page = await query
            .Filter(request.Query.Criteria)
            .Select(request.Query.Columns)
            .ToPagedList(
                request.Query.GetPageNumber(),
                request.Query.GetPageSize(),
                cancellationToken);

        return Result<PagedListNew<UserDto>>.Success(page);
    }
}