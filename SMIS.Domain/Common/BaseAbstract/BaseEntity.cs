using SMIS.Domain.Common.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SMIS.Domain.Common.BaseAbstract
{
    public abstract class BaseEntity : IEntity
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = string.Empty;
        [Required]
        public bool IsPublic { get; set; } = false;
    }
}
