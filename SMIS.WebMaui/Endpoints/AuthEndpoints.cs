using MediatR;
using Microsoft.AspNetCore.Identity;
using SMIS.Application.DTO.Auth;
using SMIS.Application.Features.Auth.Commands;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.WebMaui.Endpoints;

/// <summary>
/// Handles authentication endpoints (login, logout).
/// Extracted from Program.cs because cookie sign-in/sign-out must happen in a real
/// HTTP request/response cycle — Blazor Server's SignalR circuit cannot write cookies.
/// </summary>
public static class AuthEndpoints
{
    public static void Map(WebApplication app)
    {
        // Login page: plain HTML served outside the Blazor circuit.
        app.MapGet("/login", async (HttpContext ctx) =>
        {
            var html = await File.ReadAllTextAsync(
                Path.Combine(app.Environment.WebRootPath, "login.html"));
            return Results.Content(html, "text/html");
        });

        // Credentials arrive as a real HTTP POST so SignInManager can write the cookie.
        app.MapPost("/account/login", HandleLoginAsync).DisableAntiforgery();

        // Logout: clears the Identity cookie in a real HTTP request/response cycle.
        app.MapGet("/logout", async (SignInManager<ApplicationUser> signInManager) =>
        {
            await signInManager.SignOutAsync();
            return Results.Redirect("/login");
        });
    }

    private static async Task<IResult> HandleLoginAsync(
        HttpContext httpContext,
        IMediator mediator,
        SignInManager<ApplicationUser> signInManager,
        UserManager<ApplicationUser> userManager)
    {
        var form = httpContext.Request.Form;
        var email = form["email"].ToString();
        var password = form["password"].ToString();
        var returnUrl = form["returnUrl"].ToString();
        if (string.IsNullOrEmpty(returnUrl)) returnUrl = "/";

        var result = await mediator.Send(new LoginCommand(new LoginDto { Email = email, Password = password }));
        if (!result.Success || result.Response == null)
            return Results.Redirect("/login?error=1");

        var user = await userManager.FindByIdAsync(result.Response.UserId);
        await signInManager.SignInAsync(user!, isPersistent: true);
        return Results.Redirect(returnUrl);
    }
}
