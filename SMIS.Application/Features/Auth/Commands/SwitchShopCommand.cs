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

public record SwitchShopCommand(string ShopId) : IRequest<Result<LoginResponseDto>>;

internal sealed class SwitchShopCommandHandler
    : IRequestHandler<SwitchShopCommand, Result<LoginResponseDto>>
{
    private readonly ICurrentUser _currentUser;
    private readonly IShopRepository _shopRepository;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ITokenGenerator _tokenGenerator;
    private readonly ILanguageRepository _languageRepository;

    public SwitchShopCommandHandler(
        ICurrentUser currentUser,
        IShopRepository shopRepository,
        UserManager<ApplicationUser> userManager,
        ITokenGenerator tokenGenerator,
        ILanguageRepository languageRepository
    )
    {
        _currentUser = currentUser;
        _shopRepository = shopRepository;
        _userManager = userManager;
        _tokenGenerator = tokenGenerator;
        _languageRepository = languageRepository;
    }

    public async Task<Result<LoginResponseDto>> Handle(
        SwitchShopCommand request,
        CancellationToken cancellationToken
    )
    {
        if (string.IsNullOrWhiteSpace(request.ShopId))
        {
            return Result<LoginResponseDto>.Validation(
                "auth.shop_required",
                "A shop must be selected.",
                nameof(request.ShopId));
        }

        var user = await _userManager.FindByIdAsync(_currentUser.GetId());
        if (user is null)
            return Result<LoginResponseDto>.NotFound(_currentUser.GetId());

        if (!await _userManager.IsInRoleAsync(user, SMIS.Application.Common.Contants.SD.Role_Super_Admin))
        {
            return Result<LoginResponseDto>.Forbidden(
                "auth.shop_switch_forbidden",
                "Only a SuperAdmin can switch the active shop.");
        }

        var shop = await _shopRepository.GetByIdIncludingDeletedAsync(
            request.ShopId,
            cancellationToken);

        if (shop is null || shop.IsDeleted || !shop.IsActive)
        {
            return Result<LoginResponseDto>.NotFound(
                request.ShopId);
        }

        var roles = await _userManager.GetRolesAsync(user);
        var token = _tokenGenerator.Generate(user, roles, shop.Id);
        var language = await _languageRepository.GetByIdAsync(user.LanguageId);
        var languageCode = string.IsNullOrWhiteSpace(language?.Code)
            ? LanguageDefaults.EnglishCode
            : language.Code!;

        return Result<LoginResponseDto>.Success(
            new LoginResponseDto
            {
                Token = token,
                UserId = user.Id,
                UserName = user.UserName ?? string.Empty,
                Email = user.Email ?? string.Empty,
                ShopId = shop.Id,
                LanguageId = user.LanguageId,
                LanguageCode = languageCode,
                Roles = roles
            });
    }
}