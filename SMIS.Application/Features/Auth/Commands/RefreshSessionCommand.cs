using MediatR;
using Microsoft.AspNetCore.Identity;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Auth;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Localization;
using SMIS.Application.Repositories.Shops;
using SMIS.Domain.Entities.Identity.Entity;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Application.Features.Auth.Commands;

public record RefreshSessionCommand : IRequest<Result<LoginResponseDto>>;

internal sealed class RefreshSessionCommandHandler
    : IRequestHandler<RefreshSessionCommand, Result<LoginResponseDto>>
{
    private readonly ICurrentUser _currentUser;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ITokenGenerator _tokenGenerator;
    private readonly ILanguageRepository _languageRepository;
    private readonly IShopRepository _shopRepository;

    public RefreshSessionCommandHandler(
        ICurrentUser currentUser,
        UserManager<ApplicationUser> userManager,
        ITokenGenerator tokenGenerator,
        ILanguageRepository languageRepository,
        IShopRepository shopRepository
    )
    {
        _currentUser = currentUser;
        _userManager = userManager;
        _tokenGenerator = tokenGenerator;
        _languageRepository = languageRepository;
        _shopRepository = shopRepository;
    }

    public async Task<Result<LoginResponseDto>> Handle(
        RefreshSessionCommand request,
        CancellationToken cancellationToken
    )
    {
        var user = await _userManager.FindByIdAsync(_currentUser.GetId());
        if (user is null)
            return Result<LoginResponseDto>.NotFound(_currentUser.GetId());

        if (!user.IsActive)
            return Result<LoginResponseDto>.Unauthorized(
                "auth.account_inactive",
                "The account is inactive. Contact an administrator if access should be restored.");

        var roles = await _userManager.GetRolesAsync(user);
        var isSuperAdmin = roles.Any(role => string.Equals(
            role,
            SMIS.Application.Common.Contants.SD.Role_Super_Admin,
            StringComparison.OrdinalIgnoreCase));

        // Only SuperAdmin may preserve a switched shop context from the JWT.
        // Regular users must always refresh into their current database-assigned shop.
        var activeShopId = isSuperAdmin ? _currentUser.GetShopId() : user.ShopId;
        if (string.IsNullOrWhiteSpace(activeShopId)) activeShopId = user.ShopId;
        if (string.IsNullOrWhiteSpace(activeShopId))
            return Result<LoginResponseDto>.Forbidden(
                "auth.shop_context_required",
                "No active shop is available for this account.");

        var activeShop = await _shopRepository.GetByIdIncludingDeletedAsync(
            activeShopId,
            cancellationToken);
        if (activeShop is null || activeShop.IsDeleted || !activeShop.IsActive)
        {
            return Result<LoginResponseDto>.NotFound(activeShopId);
        }

        var language = await _languageRepository.GetByIdAsync(user.LanguageId);
        if (language is null || !language.IsActive)
            return Result<LoginResponseDto>.BusinessRule(
                "auth.invalid_language",
                "The user's selected language does not exist or is inactive.");

        var token = _tokenGenerator.Generate(user, roles, activeShopId);

        return Result<LoginResponseDto>.Success(new LoginResponseDto
        {
            Token = token,
            UserId = user.Id,
            UserName = user.UserName ?? string.Empty,
            Email = user.Email ?? string.Empty,
            ShopId = activeShopId,
            LanguageId = user.LanguageId,
            LanguageCode = string.IsNullOrWhiteSpace(language.Code)
                ? LanguageDefaults.EnglishCode
                : language.Code,
            Roles = roles
        });
    }
}