
namespace SMIS.Application.Identity.IServices
{
    public interface ICurrentUser
    {
        string GetId();
        string GetLangId();
        string GetShopId();
        bool IsSuperAdmin();
    }
}
