using SMIS.Domain.Common.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SMIS.Domain.Common.BaseAbstract
{
    public class EntityPK : IEntityPK
    {
        [Key]
        public string PublicId { get; set; } = string.Empty;
    }
}
