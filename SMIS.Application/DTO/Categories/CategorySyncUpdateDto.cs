namespace SMIS.Application.DTO.Categories;

public class CategorySyncUpdateDto : CategoryUpdateDto
{
    public DateTime ClientModifiedDate { get; set; }
    public string? ClientModifiedBy { get; set; }
}
