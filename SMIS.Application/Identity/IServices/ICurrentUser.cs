
namespace SMIS.Application.Identity.IServices
{
    public interface ICurrentUser
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        string GetId();
        Guid GetGuid();
        string GetLangId( );
    }
}
