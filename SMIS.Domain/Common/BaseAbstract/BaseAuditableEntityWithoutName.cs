using SMIS.Domain.Common.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SMIS.Domain.Common.BaseAbstract
{
    public abstract class BaseAuditableEntityWithoutName : IAuditableEntity
    {
        //[Key]
        //public int Id { get; set; }

        [Required]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public bool IsPublic { get; set; } = false;

        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; } = DateTime.Now;
    }
}
