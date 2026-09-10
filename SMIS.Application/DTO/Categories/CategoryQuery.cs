using SMIS.Application.Common.Queries;

namespace SMIS.Application.DTO.Categories;

public sealed class CategoryQueryDto : PagedQuery
{
    public string? Id { get; set; }

    [ContainsFilter]
    public string? Name { get; set; }

    public bool? IsActive { get; set; }
}
