using MediatR;
using Microsoft.AspNetCore.Identity;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Auth;
using SMIS.Application.Identity.IServices;
using SMIS.Domain.Entities.Identity.Entity;
using SMIS.Application.Common.Contants;
using SMIS.Application.Repositories.Shops;

namespace SMIS.Application.Features.Auth.Commands
{
    public record LoginCommand(LoginDto LoginDto) : IRequest<Result<LoginResponseDto>>;

    public class LoginCommandHandler : IRequestHandler<LoginCommand, Result<LoginResponseDto>>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ITokenGenerator _tokenGenerator;
        private readonly IShopRepository _shopRepository;

        public LoginCommandHandler(
            UserManager<ApplicationUser> userManager,
            ITokenGenerator tokenGenerator,
            IShopRepository shopRepository
        )
        {
            _userManager = userManager;
            _tokenGenerator = tokenGenerator;
            _shopRepository = shopRepository;
        }

        public async Task<Result<LoginResponseDto>> Handle(
            LoginCommand request,
            CancellationToken cancellationToken
        )
        {
            var user = await _userManager.FindByEmailAsync(request.LoginDto.Email);
            if (user == null || !await _userManager.CheckPasswordAsync(user, request.LoginDto.Password))
                return Result<LoginResponseDto>.FailureResult("Invalid email or password");

            var roles = await _userManager.GetRolesAsync(user);

            var activeShopId = user.ShopId;
            if (string.IsNullOrWhiteSpace(activeShopId) &&
                roles.Any(role => string.Equals(
                    role,
                    SD.Role_Super_Admin,
                    StringComparison.OrdinalIgnoreCase)))
            {
                var defaultShop = await _shopRepository.GetFirstOrDefaultAsync(shop => shop.IsActive);
                activeShopId = defaultShop?.Id;
            }

            if (string.IsNullOrWhiteSpace(activeShopId))
                return Result<LoginResponseDto>.FailureResult(
                    "ShopContextRequired",
                    "No active shop is available for this account.");

            // Token generation is delegated to the infrastructure layer.
            // Each host provides its own ITokenGenerator implementation.
            var token = _tokenGenerator.Generate(user, roles, activeShopId);

            return Result<LoginResponseDto>.SuccessResult(new LoginResponseDto
            {
                Token = token,
                UserId = user.Id,
                UserName = user.UserName!,
                Email = user.Email!,
                ShopId = activeShopId,
                Roles = roles
            }, "Login successful");
        }
    }
}