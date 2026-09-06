namespace SMIS.Application.DTO.UnitOfMeasures
{
    public class UnitOfMeasureDto
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string? Symbol { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string ShopId { get; set; } = string.Empty;
        public DateTime? ClientCreatedDate { get; set; }
        public string? ClientCreatedBy { get; set; }
        public DateTime? ClientModifiedDate { get; set; }
        public string? ClientModifiedBy { get; set; }
        public DateTime ConflictModifiedUtc { get; set; }
        public DateTime LastModifiedUtc { get; set; }
        public bool IsDeleted { get; set; }
    }
}
