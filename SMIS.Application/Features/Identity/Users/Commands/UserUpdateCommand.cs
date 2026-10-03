using MediatR;
using Microsoft.AspNetCore.Identity;
using SMIS.Application.Common.Contants;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Users;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Localization;
using SMIS.Application.Repositories.Shops;
using SMIS.Application.Identity.IServices;
using SMIS.Domain.Entities.Identity.Entity;
using SMIS.Application.Mappings;

namespace SMIS.Application.Features.Identity.Users.Commands
{
    public record UserUpdateCommand(string UserId, UserUpdateDto UserUpdateDto) : IRequest<Result<UserDto>>;

    public class UserUpdateCommandHandler : IRequestHandler<UserUpdateCommand, Result<UserDto>>
    {
        private readonly ILanguageRepository _languageRepository;
        private readonly IShopRepository _shopRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICurrentUser _currentUser;
        private readonly IUserRoleMetadataService _userRoleMetadataService;
        private readonly IUserAdministrationGuard _userAdministrationGuard;

        public UserUpdateCommandHandler(
            ILanguageRepository languageRepository,
            IShopRepository shopRepository,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager,
            IUnitOfWork unitOfWork,
            ICurrentUser currentUser,
            IUserRoleMetadataService userRoleMetadataService,
            IUserAdministrationGuard userAdministrationGuard
        )
        {
            _languageRepository = languageRepository;
            _shopRepository = shopRepository;
            _userManager = userManager;
            _roleManager = roleManager;
            _unitOfWork = unitOfWork;
            _currentUser = currentUser;
            _userRoleMetadataService = userRoleMetadataService;
            _userAdministrationGuard = userAdministrationGuard;
        }

        public async Task<Result<UserDto>> Handle(
            UserUpdateCommand request,
            CancellationToken cancellationToken
        )
        {
            var currentUserId = _currentUser.GetId();
            var signedInUser = await _userManager.FindByIdAsync(currentUserId);
            if (signedInUser is null)
            {
                return Result<UserDto>.NotFound(
                    "CurrentUserNotFound",
                    "The signed-in user no longer exists.");
            }

            var user = string.Equals(request.UserId, currentUserId, StringComparison.Ordinal)
                ? signedInUser
                : await _userManager.FindByIdAsync(request.UserId);
            if (user is null) return Result<UserDto>.NotFound(request.UserId);

            var isSelf = string.Equals(user.Id, currentUserId, StringComparison.Ordinal);
            var isSuperAdmin = await _userManager.IsInRoleAsync(signedInUser, SD.Role_Super_Admin);

            if (!isSuperAdmin && !isSelf &&
                !await _userAdministrationGuard.CanManageUserAsync(user, cancellationToken))
            {
                return Result<UserDto>.Forbidden(
                    "user.administration_forbidden",
                    "You are not allowed to update this user.");
            }

            string[]? requestedRoles = null;
            if (request.UserUpdateDto.Roles is not null)
            {
                var roleInputs = request.UserUpdateDto.Roles
                    .Distinct(StringComparer.OrdinalIgnoreCase)
                    .ToArray();
                var canonicalRoles = roleInputs
                    .Select(SD.GetCanonicalRole)
                    .ToArray();

                if (canonicalRoles.Any(role => role is null))
                {
                    return Result<UserDto>.BusinessRule(
                        "InvalidRole",
                        $"Roles must be one of: {string.Join(", ", SD.AllRoles)}.");
                }

                requestedRoles = canonicalRoles.Cast<string>().ToArray();
                foreach (var role in requestedRoles)
                {
                    if (!await _roleManager.RoleExistsAsync(role))
                        return Result<UserDto>.BusinessRule("InvalidRole", $"Role '{role}' is not configured.");
                }

                if (!await _userAdministrationGuard.CanAssignRolesAsync(
                        user,
                        requestedRoles,
                        cancellationToken))
                {
                    return Result<UserDto>.Forbidden(
                        "user.role_assignment_forbidden",
                        "You are not allowed to assign the requested roles to this user.");
                }

                if (!requestedRoles.Contains(SD.Role_Super_Admin, StringComparer.OrdinalIgnoreCase) &&
                    await _userAdministrationGuard.WouldRemoveLastSuperAdminAsync(
                        user.Id,
                        cancellationToken))
                {
                    return Result<UserDto>.BusinessRule(
                        "LastSuperAdmin",
                        "The SuperAdmin role cannot be removed from the last SuperAdmin account.");
                }
            }

            SMIS.Domain.Entities.Shop? assignedShop = null;
            if (!string.IsNullOrWhiteSpace(request.UserUpdateDto.ShopId))
            {
                if (!isSuperAdmin)
                {
                    if (!string.Equals(request.UserUpdateDto.ShopId, user.ShopId, StringComparison.Ordinal))
                    {
                        return Result<UserDto>.Forbidden(
                            "user.shop_assignment_forbidden",
                            "Only a SuperAdmin can move a user to another shop.");
                    }
                }
                else
                {
                    assignedShop = await _shopRepository.GetByIdIncludingDeletedAsync(
                        request.UserUpdateDto.ShopId,
                        cancellationToken);
                    if (assignedShop is null || assignedShop.IsDeleted || !assignedShop.IsActive)
                    {
                        return Result<UserDto>.BusinessRule(
                            "InvalidShop",
                            "The assigned shop does not exist or is inactive.");
                    }
                }
            }

            var shopChanged = assignedShop is not null &&
                              !string.Equals(
                                  user.ShopId,
                                  assignedShop.Id,
                                  StringComparison.Ordinal);

            SMIS.Domain.Entities.Localization.Language? language = null;
            if (!string.IsNullOrWhiteSpace(request.UserUpdateDto.LanguageId))
            {
                language = await _languageRepository.GetByIdAsync(request.UserUpdateDto.LanguageId);
                if (language is null || !language.IsActive)
                {
                    return Result<UserDto>.BusinessRule(
                        "InvalidLanguage",
                        "The selected language does not exist or is inactive.");
                }
            }

            if (!string.IsNullOrWhiteSpace(request.UserUpdateDto.UserName))
                user.SetUserName(request.UserUpdateDto.UserName);
            if (!string.IsNullOrWhiteSpace(request.UserUpdateDto.Email)) user.SetEmail(request.UserUpdateDto.Email);
            if (!string.IsNullOrWhiteSpace(request.UserUpdateDto.PhoneNumber))
                user.SetPhoneNumber(request.UserUpdateDto.PhoneNumber);
            if (!string.IsNullOrWhiteSpace(request.UserUpdateDto.FirstName))
                user.SetFirstName(request.UserUpdateDto.FirstName);
            if (!string.IsNullOrWhiteSpace(request.UserUpdateDto.LastName))
                user.SetLastName(request.UserUpdateDto.LastName);
            if (assignedShop is not null)
                user.SetShopId(assignedShop.Id);

            if (language is not null)
                user.SetLanguageId(language.Id);

            var shop = await _shopRepository.GetByIdAsync(user.ShopId);
            user.ShopName = shop?.Name;

            await _unitOfWork.StartTransactionAsync(cancellationToken);
            try
            {
                if (shopChanged)
                    user.InvalidateSessions();

                var updateResult = await _userManager.UpdateAsync(user);
                if (!updateResult.Succeeded)
                {
                    await _unitOfWork.RollbackTransactionAsync(cancellationToken);
                    return Result<UserDto>.Failure(updateResult.Errors.Select(e => new Error
                    {
                        Code = e.Code,
                        Description = e.Description
                    }).ToList());
                }

                if (requestedRoles is not null)
                {
                    var currentRoles = await _userManager.GetRolesAsync(user);
                    var toRemove = currentRoles.Except(requestedRoles, StringComparer.OrdinalIgnoreCase).ToArray();
                    var toAdd = requestedRoles.Except(currentRoles, StringComparer.OrdinalIgnoreCase).ToArray();

                    if (!shopChanged && (toRemove.Length > 0 || toAdd.Length > 0))
                        user.InvalidateSessions();

                    if (toRemove.Length > 0)
                    {
                        var removeResult = await _userManager.RemoveFromRolesAsync(user, toRemove);
                        if (!removeResult.Succeeded)
                        {
                            await _unitOfWork.RollbackTransactionAsync(cancellationToken);
                            return Result<UserDto>.Failure(removeResult.Errors.Select(e => new Error
                                { Code = e.Code, Description = e.Description }).ToList());
                        }
                    }

                    if (toAdd.Length > 0)
                    {
                        var addResult = await _userManager.AddToRolesAsync(user, toAdd);
                        if (!addResult.Succeeded)
                        {
                            await _unitOfWork.RollbackTransactionAsync(cancellationToken);
                            return Result<UserDto>.Failure(addResult.Errors.Select(e => new Error
                                { Code = e.Code, Description = e.Description }).ToList());
                        }
                    }
                }

                await _userRoleMetadataService.SynchronizeAsync(
                    user.Id,
                    user.UserName ?? string.Empty,
                    cancellationToken);
                await _unitOfWork.CommitTransactionAsync(cancellationToken);

                var dto = user.ToDto();
                dto.Roles = (await _userManager.GetRolesAsync(user)).ToList();
                return Result<UserDto>.Success(dto);
            }
            catch
            {
                if (_unitOfWork.HasActiveTransaction)
                    await _unitOfWork.RollbackTransactionAsync(cancellationToken);
                throw;
            }
        }
    }
}
