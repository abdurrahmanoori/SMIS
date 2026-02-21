using SMIS.Application.Identity.IServices;
using SMIS.Infrastructure.Mobile.Services.Identity;

namespace SMIS.UI.Services;

public class MauiCurrentUserAdapter : ICurrentUser
{
    private readonly ILocalCurrentUser _localCurrentUser;

    public MauiCurrentUserAdapter(ILocalCurrentUser localCurrentUser)
    {
        _localCurrentUser = localCurrentUser;
    }

    public string GetId() => _localCurrentUser.GetId();
    public string GetLangId() => "en";
    public string GetShopId() => _localCurrentUser.GetShopId();
    public bool IsSuperAdmin() => false;
    public bool IsWholesaleAdmin() => false;
    public bool IsRetailAdmin() => false;
    public List<string> Roles() => new();
}
