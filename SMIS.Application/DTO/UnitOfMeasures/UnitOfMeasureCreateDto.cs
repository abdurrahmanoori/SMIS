namespace SMIS.Application.DTO.UnitOfMeasures
{
    public class UnitOfMeasureCreateDto
    {
        public string Name { get; set; } = string.Empty;
        public string Symbol { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string ShopId { get; set; } = string.Empty;
    }
}
