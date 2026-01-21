
using System.ComponentModel.DataAnnotations;

namespace SMIS.Domain.Common.Interfaces
{
    public interface IEntityPK
    {
        [Key]
        public string PublicId { get; set; } 
        public int Id { get; set; }
    }
}
