using System.ComponentModel.DataAnnotations;

namespace SMIS.Domain.Common.Interfaces
{
    public interface IEntityPK
    {
        [Key]
        public string Id { get; set; }
    }
}
