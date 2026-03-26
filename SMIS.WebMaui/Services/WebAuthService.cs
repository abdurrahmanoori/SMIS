using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Auth;
using SMIS.Application.Features.Auth.Commands;
using SMIS.UI.Shared.Services.Interfaces;

namespace SMIS.WebMaui.Services;

public class WebAuthService : IUiAuthService
{
    private readonly IMediator _mediator;

    // Tracks authentication state within the Blazor Server circuit lifetime
    private bool _isAuthenticated = false;

    public WebAuthService(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<Result<LoginResponse>> LoginAsync(string userName, string password)
    {
        var result = await _mediator.Send(new LoginCommand(new LoginDto
        {
            Email = userName,
            Password = password
        }));

        if (result.Success && result.Response != null)
        {
            _isAuthenticated = true;

            // Map LoginResponseDto -> LoginResponse (shared contract)
            return Result<LoginResponse>.SuccessResult(new LoginResponse
            {
                Token = result.Response.Token,
                UserId = result.Response.UserId,
                UserName = result.Response.Email
            });
        }

        return Result<LoginResponse>.FailureResult(result.Message ?? "Login failed.");
    }

    public Task LogoutAsync()
    {
        _isAuthenticated = false;
        return Task.CompletedTask;
    }

    public Task<bool> IsAuthenticatedAsync()
        => Task.FromResult(_isAuthenticated);
}
