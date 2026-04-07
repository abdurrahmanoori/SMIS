using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Auth;
using SMIS.Application.Features.Auth.Commands;
using SMIS.UI.Shared.Services.Interfaces;

namespace SMIS.WebMaui.Services;

/// <summary>
/// Blazor Server auth service.
/// Depends only on Application layer abstractions — no infrastructure types.
/// </summary>
public class WebAuthService : IUiAuthService
{
    private readonly IMediator _mediator;
    private readonly ISignInService _signInService;

    public WebAuthService(IMediator mediator, ISignInService signInService)
    {
        _mediator = mediator;
        _signInService = signInService;
    }

    public async Task<Result<LoginResponse>> LoginAsync(string userName, string password)
    {
        // All credential validation is handled by LoginCommand — single place, no duplication
        var result = await _mediator.Send(new LoginCommand(new LoginDto
        {
            Email = userName,
            Password = password
        }));

        if (!result.Success || result.Response == null)
            return Result<LoginResponse>.FailureResult(result.Message ?? "Login failed.");

        // Establish the host session (cookie) via the abstraction
        await _signInService.SignInAsync(result.Response.UserId);

        return Result<LoginResponse>.SuccessResult(new LoginResponse
        {
            // Token is empty — Blazor Server relies on the Identity cookie, not a JWT
            Token = string.Empty,
            UserId = result.Response.UserId,
            UserName = result.Response.Email
        });
    }

    public async Task LogoutAsync()
    {
        await _signInService.SignOutAsync();
    }

    public Task<bool> IsAuthenticatedAsync()
    {
        // Session state is owned by ISignInService implementation
        return _signInService.IsAuthenticatedAsync();
    }
}
