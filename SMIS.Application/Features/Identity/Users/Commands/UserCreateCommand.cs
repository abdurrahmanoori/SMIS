using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using SMIS.Application.Common.Contants;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Users;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Localization;
using SMIS.Application.Repositories.Shops;
using SMIS.Domain.Entities.Identity.Entity;

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
        private readonly IMapper _mapper;

        public UserCreateCommandHandler(
            ILanguageRepository languageRepository,
            IShopRepository shopRepository,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager,
            IUnitOfWork unitOfWork,
            IMapper mapper
        )
        {
            _languageRepository = languageRepository;
            _shopRepository = shopRepository;
            _userManager = userManager;
            _roleManager = roleManager;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<UserDto>> Handle(
            UserCreateCommand request,
            CancellationToken cancellationToken
        )
        {
            var language = await _languageRepository.GetByIdAsync(request.UserCreateDto.LanguageId);
            if (language is null || !language.IsActive)
            {
                return Result<UserDto>.FailureResult(
                    "InvalidLanguage",
                    "The selected language does not exist or is inactive.");
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
                    return Result<UserDto>.FailureResult(
                        "InvalidRole",
                        $"Roles must be one of: {string.Join(", ", SD.AllRoles)}.");
                }

                roles = canonicalRoles.Cast<string>().ToArray();
                foreach (var role in roles)
                {
                    if (!await _roleManager.RoleExistsAsync(role))
                        return Result<UserDto>.FailureResult("InvalidRole", $"Role '{role}' is not configured.");
                }
            }

            var entity = _mapper.Map<ApplicationUser>(request.UserCreateDto);

            // Populate shop name
            var shop = await _shopRepository.GetByIdAsync(request.UserCreateDto.ShopId);
            entity.ShopName = shop?.Name;

            var createResult = await _userManager.CreateAsync(entity, request.UserCreateDto.Password);
            if (!createResult.Succeeded)
            {
                return Result<UserDto>.WithErrors(createResult.Errors.Select(e => new ValidationError
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
                    return Result<UserDto>.WithErrors(addToRoles.Errors.Select(e => new ValidationError
                    {
                        Code = e.Code,
                        Description = e.Description
                    }).ToList());
                }
            }

            return Result<UserDto>.SuccessResult(_mapper.Map<UserDto>(entity));
        }
    }
}