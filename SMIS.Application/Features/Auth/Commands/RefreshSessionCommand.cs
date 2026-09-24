using MediatR;
using Microsoft.AspNetCore.Identity;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Auth;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Localization;
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

    public RefreshSessionCommandHandler(
        ICurrentUser currentUser,
        UserManager<ApplicationUser> userManager,
        ITokenGenerator tokenGenerator,
        ILanguageRepository languageRepository
    )
    {
        _currentUser = currentUser;
        _userManager = userManager;
        _tokenGenerator = tokenGenerator;
        _languageRepository = languageRepository;
    }

    public async Task<Result<LoginResponseDto>> Handle(
        RefreshSessionCommand request,
        CancellationToken cancellationToken
    )
    {
        var user = await _userManager.FindByIdAsync(_currentUser.GetId());
        if (user is null)
            return Result<LoginResponseDto>.FailureResult(
                "UserNotFound",
                "The current user no longer exists.");

        var activeShopId = _currentUser.GetShopId();
        if (string.IsNullOrWhiteSpace(activeShopId)) activeShopId = user.ShopId;
        if (string.IsNullOrWhiteSpace(activeShopId))
            return Result<LoginResponseDto>.FailureResult(
                "ShopContextRequired",
                "No active shop is available for this account.");

        var language = await _languageRepository.GetByIdAsync(user.LanguageId);
        if (language is null || !language.IsActive)
            return Result<LoginResponseDto>.FailureResult(
                "InvalidLanguage",
                "The user's selected language does not exist or is inactive.");

        var roles = await _userManager.GetRolesAsync(user);
        var token = _tokenGenerator.Generate(user, roles, activeShopId);

        return Result<LoginResponseDto>.SuccessResult(new LoginResponseDto
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