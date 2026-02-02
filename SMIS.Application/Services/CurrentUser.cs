using Microsoft.AspNetCore.Http;
using SMIS.Application.Identity.IServices;
using System.Security.Claims;

namespace SMIS.Application.Services;

public class CurrentUser : ICurrentUser
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CurrentUser(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 25;

    public Guid GetGuid()
    {
        return Guid.Empty;
    }

    public string GetId()
    {
        var user = _httpContextAccessor.HttpContext?.User;
        if (user?.Identity?.IsAuthenticated ?? false)
        {
            var userId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            return userId ?? "1";
        }
        return "1"; // Default user ID for development
    }

    public string GetLangId()
    {
        return "1"; // Default language ID
    }
}