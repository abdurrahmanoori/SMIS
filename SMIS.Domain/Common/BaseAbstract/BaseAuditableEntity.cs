using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Services;

namespace SMIS.Domain.Common.BaseAbstract
{
    /// <summary>
    /// Adds server-side audit ownership and timestamps to <see cref="BaseEntity"/>.
    /// These values are populated centrally by the audit interceptor rather than
    /// repeated in every command handler.
    /// </summary>
    public abstract class BaseAuditableEntity : BaseEntity, IAuditableEntity
    {
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}