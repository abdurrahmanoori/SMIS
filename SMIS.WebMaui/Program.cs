using Microsoft.AspNetCore.Identity;
using SMIS.Application.Extensions;
using SMIS.Domain.Entities.Identity.Entity;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Extensions;
using SMIS.UI.Shared.Services.Interfaces;
using SMIS.WebMaui.Components;
using SMIS.WebMaui.Services;
using Syncfusion.Blazor;
using Syncfusion.Licensing;

// Register Syncfusion license key
SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NDaF5cWWtCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdlWXxfcHRVRWBZWER2X0dWYU4=");

var builder = WebApplication.CreateBuilder(args);

// Add Blazor Server with interactive server components
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddSyncfusionBlazor();

// Wire up Infrastructure (DbContext, repositories, interceptors, ICurrentUser) + Application (MediatR, validators, AutoMapper)
builder.Services.ConfigurePersistenceServices(builder.Configuration, builder.Environment);
builder.Services.ConfigureApplicationServices();

// Register ASP.NET Identity (UserManager, SignInManager) without JWT bearer middleware
// JWT is only needed in SMIS.Api — this app talks directly to the database
builder.Services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 6;
})
.AddEntityFrameworkStores<AppDbContext>()
.AddDefaultTokenProviders();

builder.Services.AddHttpContextAccessor();

// Register web-specific implementations of shared service interfaces
builder.Services.AddScoped<IUiAuthService, WebAuthService>();
builder.Services.AddScoped<ICategoryService, WebCategoryService>();
builder.Services.AddScoped<ISyncFacade, WebSyncFacade>();
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
app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddAdditionalAssemblies(typeof(SMIS.UI.Shared.Components.Pages.Home).Assembly);

app.Run();
