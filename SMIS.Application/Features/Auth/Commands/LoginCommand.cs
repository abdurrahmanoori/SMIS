using MediatR;
using Microsoft.AspNetCore.Identity;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Auth;
using SMIS.Application.Identity.IServices;
using SMIS.Domain.Entities.Identity.Entity;
using SMIS.Application.Common.Contants;
using SMIS.Application.Repositories.Localization;
using SMIS.Application.Repositories.Shops;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Application.Features.Auth.Commands
{
    public record LoginCommand(LoginDto LoginDto) : IRequest<Result<LoginResponseDto>>;

    public class LoginCommandHandler : IRequestHandler<LoginCommand, Result<LoginResponseDto>>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ITokenGenerator _tokenGenerator;
        private readonly IShopRepository _shopRepository;
        private readonly ILanguageRepository _languageRepository;

        public LoginCommandHandler(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ITokenGenerator tokenGenerator,
            IShopRepository shopRepository,
            ILanguageRepository languageRepository
        )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenGenerator = tokenGenerator;
            _shopRepository = shopRepository;
            _languageRepository = languageRepository;
        }

        public async Task<Result<LoginResponseDto>> Handle(
            LoginCommand request,
            CancellationToken cancellationToken
        )
        {
            var user = await _userManager.FindByEmailAsync(request.LoginDto.Email);
            if (user == null)
                return Result<LoginResponseDto>.Unauthorized(
                    "auth.invalid_credentials",
                    "Invalid email or password.");

            var signInResult = await _signInManager.CheckPasswordSignInAsync(
                user,
                request.LoginDto.Password,
                lockoutOnFailure: true);
            if (signInResult.IsLockedOut)
                return Result<LoginResponseDto>.Unauthorized(
                    "auth.account_locked",
                    "The account is temporarily locked after repeated failed sign-in attempts.");
            if (!signInResult.Succeeded)
                return Result<LoginResponseDto>.Unauthorized(
                    "auth.invalid_credentials",
                    "Invalid email or password.");

            var roles = await _userManager.GetRolesAsync(user);
            var isSuperAdmin = roles.Any(role => string.Equals(
                role,
                SD.Role_Super_Admin,
                StringComparison.OrdinalIgnoreCase));

            string? activeShopId = null;
            if (!string.IsNullOrWhiteSpace(user.ShopId))
            {
                var assignedShop = await _shopRepository.GetByIdIncludingDeletedAsync(
                    user.ShopId,
                    cancellationToken);
                if (assignedShop is not null && !assignedShop.IsDeleted && assignedShop.IsActive)
                    activeShopId = assignedShop.Id;
            }

            if (string.IsNullOrWhiteSpace(activeShopId) && isSuperAdmin)
            {
                var defaultShop = await _shopRepository.GetFirstOrDefaultAsync(shop => shop.IsActive);
                activeShopId = defaultShop?.Id;
            }

            if (string.IsNullOrWhiteSpace(activeShopId))
                return Result<LoginResponseDto>.Forbidden(
                    "auth.no_active_shop",
                    "The account is not assigned to an active shop.");

            // Token generation is delegated to the infrastructure layer.
            // Each host provides its own ITokenGenerator implementation.
            var token = _tokenGenerator.Generate(user, roles, activeShopId);
            var language = await _languageRepository.GetByIdAsync(user.LanguageId);
            var languageCode = string.IsNullOrWhiteSpace(language?.Code)
                ? LanguageDefaults.EnglishCode
                : language.Code!;

            return Result<LoginResponseDto>.Success(new LoginResponseDto
            {
                Token = token,
                UserId = user.Id,
                UserName = user.UserName!,
                Email = user.Email!,
                ShopId = activeShopId,
                LanguageId = user.LanguageId,
                LanguageCode = languageCode,
                Roles = roles
            });
        }
    }
}