using SMIS.Domain.Common.BaseAbstract;

namespace SMIS.Domain.Entities
{
    public class AppLog : BaseEntity
    {
        public string Level { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string? Exception { get; set; }
        public string? Properties { get; set; }
        public string? UserId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}