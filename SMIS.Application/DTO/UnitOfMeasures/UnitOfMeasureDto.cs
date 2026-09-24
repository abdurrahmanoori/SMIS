namespace SMIS.Application.DTO.UnitOfMeasures
{
    public class UnitOfMeasureDto
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string? Symbol { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime? ClientModifiedDate { get; set; }
        public DateTime LastModifiedUtc { get; set; }
        public bool IsDeleted { get; set; }
    }
}