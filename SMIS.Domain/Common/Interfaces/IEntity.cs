
namespace SMIS.Domain.Common.Interfaces;


public interface IEntity
{
    public Guid Id { get; set; }
    public string PublicId { get; set; }


    public bool IsPublic { get; set; }
    public string Name { get; set; }

}

