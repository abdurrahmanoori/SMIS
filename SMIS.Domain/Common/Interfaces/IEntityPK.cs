using SMIS.Domain.Enums;

namespace SMIS.Domain.Common.Interfaces
{
    public interface IEntityPK
    {
        public string Id { get; set; }
        public int Version { get; set; } // increment on every change
        public EntityStateEnum EntityState { get; set; }
        public DateTimeOffset LastModifiedUtc { get;  set; }
    }
}
