namespace SMIS.Application.Identity.IServices
{
    public interface ICurrentUser
    {
        string GetId();
        string GetLangId();
        string GetShopId();
        bool IsShopAdmin();
        bool IsSuperAdmin();
        public List<string> Roles();
    }
}