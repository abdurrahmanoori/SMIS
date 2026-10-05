using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Contants;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Auth;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Localization;
using SMIS.Application.Repositories.Shops;
using SMIS.Application.Services;
using SMIS.Domain.Entities.Identity.Entity;
using SMIS.Domain.Entities.Localization;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.Auth.Commands;

public sealed record RefreshAccessTokenCommand(
    string RefreshToken,
    string? ShopId
) : IRequest<Result<LoginResponseDto>>;

internal sealed class RefreshAccessTokenCommandHandler
    : IRequestHandler<RefreshAccessTokenCommand, Result<LoginResponseDto>>
{
    private readonly IApplicationDbContext _dbContext;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ITokenGenerator _tokenGenerator;
    private readonly IRefreshTokenService _refreshTokenService;
    private readonly IShopRepository _shopRepository;
    private readonly ILanguageRepository _languageRepository;

    public RefreshAccessTokenCommandHandler(
        IApplicationDbContext dbContext,
        UserManager<ApplicationUser> userManager,
        ITokenGenerator tokenGenerator,
        IRefreshTokenService refreshTokenService,
        IShopRepository shopRepository,
        ILanguageRepository languageRepository
    )
    {
        _dbContext = dbContext;
        _userManager = userManager;
        _tokenGenerator = tokenGenerator;
        _refreshTokenService = refreshTokenService;
        _shopRepository = shopRepository;
        _languageRepository = languageRepository;
    }

    public async Task<Result<LoginResponseDto>> Handle(
        RefreshAccessTokenCommand request,
        CancellationToken cancellationToken
    )
    {
        if (string.IsNullOrWhiteSpace(request.RefreshToken))
            return InvalidRefreshToken();

        var now = DateTimeService.NowUtc;
        var refreshTokenHash = _refreshTokenService.Hash(request.RefreshToken);
        var storedToken = await _dbContext.RefreshTokens
            .SingleOrDefaultAsync(
                token => token.TokenHash == refreshTokenHash,
                cancellationToken);

        if (storedToken is null ||
            storedToken.RevokedAtUtc.HasValue ||
            storedToken.ExpiresAtUtc <= now)
        {
            return InvalidRefreshToken();
        }

        var user = await _userManager.FindByIdAsync(storedToken.UserId);
        if (user is null || !user.IsActive)
        {
            storedToken.Revoke(now);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return InvalidRefreshToken();
        }

        if (user.LockoutEnabled &&
            user.LockoutEnd.HasValue &&
            user.LockoutEnd.Value > DateTimeOffset.UtcNow)
        {
            return Result<LoginResponseDto>.Unauthorized(
                "auth.account_locked",
                "The account is locked. Contact an administrator if access should be restored.");
        }

        if (storedToken.SecurityVersion != user.SecurityVersion)
        {
            storedToken.Revoke(now);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return InvalidRefreshToken();
        }

        var roles = await _userManager.GetRolesAsync(user);
        var isSuperAdmin = roles.Any(role => string.Equals(
            role,
            SD.Role_Super_Admin,
            StringComparison.OrdinalIgnoreCase));

        var activeShopId = isSuperAdmin && !string.IsNullOrWhiteSpace(request.ShopId)
            ? request.ShopId
            : user.ShopId;

        if (string.IsNullOrWhiteSpace(activeShopId))
            return Result<LoginResponseDto>.Forbidden(
                "auth.shop_context_required",
                "No active shop is available for this account.");

        var activeShop = await _shopRepository.GetByIdIncludingDeletedAsync(
            activeShopId,
            cancellationToken);
        if (activeShop is null || activeShop.IsDeleted || !activeShop.IsActive)
            return Result<LoginResponseDto>.Forbidden(
                "auth.invalid_shop_context",
                "The selected shop is not available.");

        var language = await _languageRepository.GetByIdAsync(user.LanguageId);
        if (language is null || !language.IsActive)
            return Result<LoginResponseDto>.BusinessRule(
                "auth.invalid_language",
                "The user's selected language does not exist or is inactive.");

        var replacement = _refreshTokenService.Issue();
        storedToken.Revoke(now, replacement.TokenHash);
        _dbContext.RefreshTokens.Add(ApplicationRefreshToken.Create(
            user.Id,
            replacement.TokenHash,
            user.SecurityVersion,
            now,
            replacement.ExpiresAtUtc));

        await _dbContext.SaveChangesAsync(cancellationToken);

        return Result<LoginResponseDto>.Success(new LoginResponseDto
        {
            Token = _tokenGenerator.Generate(user, roles, activeShopId),
            RefreshToken = replacement.Token,
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

    private static Result<LoginResponseDto> InvalidRefreshToken() =>
        Result<LoginResponseDto>.Unauthorized(
            "auth.invalid_refresh_token",
            "The refresh token is invalid or has expired.");
}