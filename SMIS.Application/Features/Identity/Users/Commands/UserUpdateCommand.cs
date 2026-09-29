using AutoMapper;
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
        private readonly IMapper _mapper;
        private readonly ICurrentUser _currentUser;
        private readonly IUserRoleMetadataService _userRoleMetadataService;
        private readonly IUserAdministrationGuard _userAdministrationGuard;

        public UserUpdateCommandHandler(
            ILanguageRepository languageRepository,
            IShopRepository shopRepository,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager,
            IUnitOfWork unitOfWork,
            IMapper mapper,
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
            _mapper = mapper;
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
                return Result<UserDto>.FailureResult(
                    "CurrentUserNotFound",
                    "The signed-in user no longer exists.");
            }

            var isSuperAdmin = await _userManager.IsInRoleAsync(signedInUser, SD.Role_Super_Admin);
            if (!isSuperAdmin &&
                !string.Equals(request.UserId, currentUserId, StringComparison.Ordinal))
            {
                return Result<UserDto>.FailureResult(
                    "Forbidden",
                    "You can only update your own profile.");
            }

            if (!isSuperAdmin && request.UserUpdateDto.Roles is not null)
            {
                return Result<UserDto>.FailureResult(
                    "Forbidden",
                    "Only a SuperAdmin can change user roles.");
            }

            if (!isSuperAdmin && !string.IsNullOrWhiteSpace(request.UserUpdateDto.ShopId))
            {
                return Result<UserDto>.FailureResult(
                    "Forbidden",
                    "Only a SuperAdmin can change a user's assigned shop.");
            }

            var user = string.Equals(request.UserId, currentUserId, StringComparison.Ordinal)
                ? signedInUser
                : await _userManager.FindByIdAsync(request.UserId);
            if (user == null) return Result<UserDto>.NotFoundResult(request.UserId);

            string[]? requestedRoles = null;
            if (isSuperAdmin && request.UserUpdateDto.Roles is not null)
            {
                var roleInputs = request.UserUpdateDto.Roles
                    .Distinct(StringComparer.OrdinalIgnoreCase)
                    .ToArray();
                var canonicalRoles = roleInputs
                    .Select(SD.GetCanonicalRole)
                    .ToArray();

                if (canonicalRoles.Any(role => role is null))
                {
                    return Result<UserDto>.FailureResult(
                        "InvalidRole",
                        $"Roles must be one of: {string.Join(", ", SD.AllRoles)}.");
                }

                requestedRoles = canonicalRoles.Cast<string>().ToArray();
                foreach (var role in requestedRoles)
                {
                    if (!await _roleManager.RoleExistsAsync(role))
                        return Result<UserDto>.FailureResult("InvalidRole", $"Role '{role}' is not configured.");
                }

                if (!requestedRoles.Contains(SD.Role_Super_Admin, StringComparer.OrdinalIgnoreCase) &&
                    await _userAdministrationGuard.WouldRemoveLastSuperAdminAsync(
                        user.Id,
                        cancellationToken))
                {
                    return Result<UserDto>.FailureResult(
                        "LastSuperAdmin",
                        "The SuperAdmin role cannot be removed from the last SuperAdmin account.");
                }
            }

            SMIS.Domain.Entities.Shop? assignedShop = null;
            if (isSuperAdmin && !string.IsNullOrWhiteSpace(request.UserUpdateDto.ShopId))
            {
                assignedShop = await _shopRepository.GetByIdIncludingDeletedAsync(
                    request.UserUpdateDto.ShopId,
                    cancellationToken);
                if (assignedShop is null || assignedShop.IsDeleted || !assignedShop.IsActive)
                {
                    return Result<UserDto>.FailureResult(
                        "InvalidShop",
                        "The assigned shop does not exist or is inactive.");
                }
            }

            SMIS.Domain.Entities.Localization.Language? language = null;
            if (!string.IsNullOrWhiteSpace(request.UserUpdateDto.LanguageId))
            {
                language = await _languageRepository.GetByIdAsync(request.UserUpdateDto.LanguageId);
                if (language is null || !language.IsActive)
                {
                    return Result<UserDto>.FailureResult(
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

            // Update shop name
            var shop = await _shopRepository.GetByIdAsync(user.ShopId);
            user.ShopName = shop?.Name;

            await _unitOfWork.StartTransactionAsync(cancellationToken);
            try
            {
                var updateResult = await _userManager.UpdateAsync(user);
                if (!updateResult.Succeeded)
                {
                    await _unitOfWork.RollbackTransactionAsync(cancellationToken);
                    return Result<UserDto>.WithErrors(updateResult.Errors.Select(e => new ValidationError
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

                    if (toRemove.Length > 0)
                    {
                        var removeResult = await _userManager.RemoveFromRolesAsync(user, toRemove);
                        if (!removeResult.Succeeded)
                        {
                            await _unitOfWork.RollbackTransactionAsync(cancellationToken);
                            return Result<UserDto>.WithErrors(removeResult.Errors.Select(e => new ValidationError
                                { Code = e.Code, Description = e.Description }).ToList());
                        }
                    }

                    if (toAdd.Length > 0)
                    {
                        var addResult = await _userManager.AddToRolesAsync(user, toAdd);
                        if (!addResult.Succeeded)
                        {
                            await _unitOfWork.RollbackTransactionAsync(cancellationToken);
                            return Result<UserDto>.WithErrors(addResult.Errors.Select(e => new ValidationError
                                { Code = e.Code, Description = e.Description }).ToList());
                        }
                    }
                }

                await _userRoleMetadataService.SynchronizeAsync(
                    user.Id,
                    user.UserName ?? string.Empty,
                    cancellationToken);
                await _unitOfWork.CommitTransactionAsync(cancellationToken);

                var dto = _mapper.Map<UserDto>(user);
                dto.Roles = (await _userManager.GetRolesAsync(user)).ToList();
                return Result<UserDto>.SuccessResult(dto);
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