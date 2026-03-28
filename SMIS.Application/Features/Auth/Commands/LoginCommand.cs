using MediatR;
using Microsoft.AspNetCore.Identity;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Auth;
using SMIS.Application.Identity.IServices;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Features.Auth.Commands
{
    public record LoginCommand(LoginDto LoginDto) : IRequest<Result<LoginResponseDto>>;

    public class LoginCommandHandler : IRequestHandler<LoginCommand, Result<LoginResponseDto>>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ITokenGenerator _tokenGenerator;

        public LoginCommandHandler(UserManager<ApplicationUser> userManager, ITokenGenerator tokenGenerator)
        {
            _userManager = userManager;
            _tokenGenerator = tokenGenerator;
        }

        public async Task<Result<LoginResponseDto>> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByEmailAsync(request.LoginDto.Email);
            if (user == null || !await _userManager.CheckPasswordAsync(user, request.LoginDto.Password))
                return Result<LoginResponseDto>.FailureResult("Invalid email or password");

            var roles = await _userManager.GetRolesAsync(user);

            // Token generation is delegated to the infrastructure layer.
            // Each host provides its own ITokenGenerator implementation.
            var token = _tokenGenerator.Generate(user, roles);

            return Result<LoginResponseDto>.SuccessResult(new LoginResponseDto
            {
                Token = token,
                UserId = user.Id,
                Email = user.Email!,
                Roles = roles
            }, "Login successful");
        }
    }
}
