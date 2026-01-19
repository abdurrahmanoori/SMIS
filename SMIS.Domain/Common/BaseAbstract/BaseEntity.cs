using SMIS.Domain.Common.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMIS.Domain.Common.BaseAbstract
{
    public abstract class BaseEntity : IEntity
    {
        [Key]
        public string PublicId { get; set; } = Guid.NewGuid().ToString();
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        [Required]
        public bool IsPublic { get; set; } = false;
    }
}
