using Microsoft.EntityFrameworkCore;
namespace SMIS.Domain.Common.Interfaces
{
    public interface IEntityPK
    {
        public string Id { get; set; }
        public int Version { get; set; } // increment on every change
        public EntityState State { get; set; }
        public DateTimeOffset LastModifiedUtc { get;  set; }
    }
}
