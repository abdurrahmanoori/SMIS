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
    public record UserCreateCommand(UserCreateDto UserCreateDto) : IRequest<Result<UserDto>>;

    public class UserCreateCommandHandler : IRequestHandler<UserCreateCommand, Result<UserDto>>
    {
        private readonly ILanguageRepository _languageRepository;
        private readonly IShopRepository _shopRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRoleMetadataService _userRoleMetadataService;

        public UserCreateCommandHandler(
            ILanguageRepository languageRepository,
            IShopRepository shopRepository,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager,
            IUnitOfWork unitOfWork,
            IUserRoleMetadataService userRoleMetadataService
        )
        {
            _languageRepository = languageRepository;
            _shopRepository = shopRepository;
            _userManager = userManager;
            _roleManager = roleManager;
            _unitOfWork = unitOfWork;
            _userRoleMetadataService = userRoleMetadataService;
        }

        public async Task<Result<UserDto>> Handle(
            UserCreateCommand request,
            CancellationToken cancellationToken
        )
        {
            var language = await _languageRepository.GetByIdAsync(request.UserCreateDto.LanguageId);
            if (language is null || !language.IsActive)
            {
                return Result<UserDto>.BusinessRule(
                    "InvalidLanguage",
                    "The selected language does not exist or is inactive.");
            }

            var shop = await _shopRepository.GetByIdIncludingDeletedAsync(
                request.UserCreateDto.ShopId,
                cancellationToken);
            if (shop is null || shop.IsDeleted || !shop.IsActive)
            {
                return Result<UserDto>.BusinessRule(
                    "InvalidShop",
                    "The assigned shop does not exist or is inactive.");
            }

            var roles = Array.Empty<string>();
            if (request.UserCreateDto.Roles != null)
            {
                var requestedRoles = request.UserCreateDto.Roles
                    .Distinct(StringComparer.OrdinalIgnoreCase)
                    .ToArray();
                var canonicalRoles = requestedRoles
                    .Select(SD.GetCanonicalRole)
                    .ToArray();

                if (canonicalRoles.Any(role => role is null))
                {
                    return Result<UserDto>.BusinessRule(
                        "InvalidRole",
                        $"Roles must be one of: {string.Join(", ", SD.AllRoles)}.");
                }

                roles = canonicalRoles.Cast<string>().ToArray();
                foreach (var role in roles)
                {
                    if (!await _roleManager.RoleExistsAsync(role))
                        return Result<UserDto>.BusinessRule("InvalidRole", $"Role '{role}' is not configured.");
                }
            }

            var entity = request.UserCreateDto.ToEntity();
            entity.ShopName = shop.Name;

            await _unitOfWork.StartTransactionAsync(cancellationToken);
            try
            {
                var createResult = await _userManager.CreateAsync(entity, request.UserCreateDto.Password);
                if (!createResult.Succeeded)
                {
                    await _unitOfWork.RollbackTransactionAsync(cancellationToken);
                    return Result<UserDto>.Failure(createResult.Errors.Select(e => new Error
                    {
                        Code = e.Code,
                        Description = e.Description
                    }).ToList());
                }

                if (roles.Length > 0)
                {
                    var addToRoles = await _userManager.AddToRolesAsync(entity, roles);
                    if (!addToRoles.Succeeded)
                    {
                        await _unitOfWork.RollbackTransactionAsync(cancellationToken);
                        return Result<UserDto>.Failure(addToRoles.Errors.Select(e => new Error
                        {
                            Code = e.Code,
                            Description = e.Description
                        }).ToList());
                    }
                }

                await _userRoleMetadataService.SynchronizeAsync(
                    entity.Id,
                    entity.UserName ?? string.Empty,
                    cancellationToken);
                await _unitOfWork.CommitTransactionAsync(cancellationToken);

                var dto = entity.ToDto();
                dto.Roles = roles.ToList();
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