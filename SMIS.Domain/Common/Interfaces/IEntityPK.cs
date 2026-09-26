namespace SMIS.Domain.Common.Interfaces
{
    public interface IEntityPK
    {
        public string Id { get; set; }
        public int Version { get; set; } // increment on every change
        public DateTime LastModifiedUtc { get; set; }
    }
}