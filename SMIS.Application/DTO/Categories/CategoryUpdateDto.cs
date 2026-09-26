namespace SMIS.Application.DTO.Categories
{
    public class CategoryUpdateDto
    {
        public string Name { get; set; } = string.Empty;

        public string? Code { get; set; }

        public string? Description { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
