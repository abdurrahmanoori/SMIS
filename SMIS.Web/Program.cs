using MudBlazor.Services;
using SMIS.Application.Extensions;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Load shared configuration first, then project-specific appsettings override it
// SetBasePath ensures files are resolved from the output directory where MSBuild copies linked files
builder.Configuration
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.shared.json", optional: false, reloadOnChange: true)
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMudServices();

// Required by ServerCurrentUser and Blazor Server circuit context
builder.Services.AddHttpContextAccessor();

// Identity — registers UserManager, RoleManager, and ASP.NET Identity
builder.Services.AddIdentityServices<AppDbContext>();

// Application layer — MediatR, validators, pipeline behaviors
builder.Services.ConfigureApplicationServices();

// Infrastructure layer — DbContext, repositories, AutoMapper, ICurrentUser
builder.Services.ConfigurePersistenceServices(builder.Configuration, builder.Environment);

// Web-specific services
builder.Services.AddScoped<SMIS.Web.Services.CategoryService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
