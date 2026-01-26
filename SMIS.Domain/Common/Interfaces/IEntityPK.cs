using System.ComponentModel.DataAnnotations;

namespace SMIS.Domain.Common.Interfaces
{
    public interface IEntityPK
    {
        public string Id { get; set; }
    }
}
