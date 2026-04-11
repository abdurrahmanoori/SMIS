using SMIS.Application.Extensions;
using SMIS.Application.Identity.IServices;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Extensions;
using SMIS.UI.Shared.Services.Interfaces;
using SMIS.WebMaui.Components;
using SMIS.WebMaui.Endpoints;
using SMIS.WebMaui.Services;
using Syncfusion.Blazor;
using Syncfusion.Licensing;

var builder = WebApplication.CreateBuilder(args);

// Load shared configuration first, then project-specific appsettings override it
// SetBasePath ensures files are resolved from the output directory where MSBuild copies linked files
builder.Configuration
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.shared.json", optional: false, reloadOnChange: true)
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
    .AddJsonFile("appsettings.secrets.json", optional: true, reloadOnChange: true);

// Syncfusion license key loaded from solution-level appsettings.secrets.json (git-ignored)
SyncfusionLicenseProvider.RegisterLicense(builder.Configuration["SyncfusionLicenseKey"]);

// Add Blazor Server with interactive server components
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddSyncfusionBlazor();

// Wire up Infrastructure (DbContext, repositories, interceptors, ICurrentUser) + Application (MediatR, validators, AutoMapper)
builder.Services.ConfigurePersistenceServices(builder.Configuration, builder.Environment);
builder.Services.ConfigureApplicationServices();

// Register ASP.NET Identity (UserManager, SignInManager) — no JWT bearer, Blazor Server uses cookie auth
builder.Services.AddIdentityServices<AppDbContext>();

builder.Services.AddHttpContextAccessor();

// Register web-specific implementations of shared service interfaces
// NullTokenGenerator satisfies ITokenGenerator for LoginCommand DI — token is unused here,
// Blazor Server auth is handled by the Identity cookie via SignInManager
builder.Services.AddScoped<ITokenGenerator, NullTokenGenerator>();
builder.Services.AddScoped<ISignInService, CookieSignInService>();
builder.Services.AddScoped<IUiAuthService, WebAuthService>();
builder.Services.AddScoped<ICategoryService, WebCategoryService>();
builder.Services.AddScoped<IShopService, WebShopService>();
builder.Services.AddScoped<ISyncFacade, WebSyncFacade>();
builder.Services.AddScoped<IProfileService, WebProfileService>();
builder.Services.AddSingleton<IThemeService, ThemeService>();
builder.Services.AddScoped<DevelopmentAutoLoginService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.UseAntiforgery();

app.MapStaticAssets();

// All auth endpoints (login page, login POST, logout) are in AuthEndpoints.
// They must be registered before MapRazorComponents to take priority over Blazor component routes.
AuthEndpoints.Map(app);

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddAdditionalAssemblies(typeof(SMIS.UI.Shared.Components.Pages.Home).Assembly);

app.Run();
