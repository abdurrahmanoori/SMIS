
namespace SMIS.Application.Identity.IServices
{
    public interface ICurrentUser
    {
        string GetId();
        //Guid GetGuid();
        string GetLangId( );

        string GetShopId( );
    }
}
