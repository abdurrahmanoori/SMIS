using System.ComponentModel.DataAnnotations;

namespace SMIS.Domain.Common
{
    public abstract class BaseEntity 
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }
        [Required]
        public string PublicId { get; set; } = System.Guid.NewGuid().ToString();

    }
}
