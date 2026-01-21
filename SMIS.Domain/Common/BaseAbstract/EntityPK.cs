using SMIS.Domain.Common.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SMIS.Domain.Common.BaseAbstract
{
    public class EntityPK : IEntityPK
    {
        [Key]
        public string PublicId { get; set; } = Guid.NewGuid().ToString();
        public int Id { get; set; }
    }
}
