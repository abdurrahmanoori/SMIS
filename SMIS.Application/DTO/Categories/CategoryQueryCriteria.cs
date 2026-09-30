namespace SMIS.Application.DTO.Categories;

public sealed class CategoryQueryCriteria
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? Code { get; set; }
    public string? Description { get; set; }
    public bool? IsActive { get; set; }
    public string? ShopId { get; set; }
}