using SMIS.Domain.Common.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SMIS.Domain.Common.BaseAbstract
{
    public abstract class BaseEntity : IEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }
        [Required]
        public string PublicId { get; set; } = Guid.NewGuid().ToString();
        public bool IsPublic { get ; set ; } = false;
    }
}
