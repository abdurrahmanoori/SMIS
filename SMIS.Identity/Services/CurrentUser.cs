using Microsoft.AspNetCore.Http;
using SMIS.Application.Identity.IServices;
using System.Security.Claims;

namespace SMIS.Identity.Services;

public class CurrentUser : ICurrentUser
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CurrentUser(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public string GetId()
    {
        var user = _httpContextAccessor.HttpContext?.User;
        return user?.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
    }

    public string GetLangId()
    {
        return "1"; // Default language ID
    }

    public string GetShopId()
    {
        var user = _httpContextAccessor.HttpContext?.User;
        return user?.FindFirst("ShopId")?.Value ?? string.Empty;
    }
}
