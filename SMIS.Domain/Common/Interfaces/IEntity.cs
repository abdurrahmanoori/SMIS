
namespace SMIS.Domain.Common.Interfaces;


public interface IEntity
{
    public string Id { get; set; }
    public bool IsPublic { get; set; }
    public string Name { get; set; }
}

