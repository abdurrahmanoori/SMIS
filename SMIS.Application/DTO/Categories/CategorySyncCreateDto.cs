namespace SMIS.Application.DTO.Categories;

public class CategorySyncCreateDto : CategoryCreateDto
{
    public DateTime ClientCreatedDate { get; set; }
    public DateTime ClientModifiedDate { get; set; }
    public string? ClientCreatedBy { get; set; }
    public string? ClientModifiedBy { get; set; }
}
