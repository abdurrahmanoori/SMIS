namespace SMIS.Application.DTO.Categories;

public class CategorySyncCreateDto : CategoryCreateDto
{
    public string Id { get; set; } = string.Empty;
    public DateTime ClientModifiedDate { get; set; }
}