using SMIS.Domain.Common.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SMIS.Domain.Common.BaseAbstract
{
    public abstract class BaseAuditableEntityWithoutName : IAuditableEntity
    {
        //[Key]
        //public int Id { get; set; }
        
        [Required]
        public string PublicId { get; set; } = Guid.NewGuid().ToString();
        
        public bool IsPublic { get; set; } = false;
        
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; } = DateTime.Now;
    }
}
