using MudBlazor.Services;
using SMIS.Application.Extensions;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMudServices();

// Required by ServerCurrentUser and Blazor Server circuit context
builder.Services.AddHttpContextAccessor();

// Identity — registers UserManager, RoleManager, and ASP.NET Identity
builder.Services.ConfigureIdentityServices<AppDbContext>(builder.Configuration);

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
