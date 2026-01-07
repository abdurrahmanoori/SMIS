
namespace SMIS.Application.Identity.IServices
{
    public interface ICurrentUser
    {
        int GetId();
        Guid GetGuid();
        int GetLangId( );
    }
}
