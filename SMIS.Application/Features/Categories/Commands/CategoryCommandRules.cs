using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.Categories.Commands;

/// <summary>
/// Business mutation rules shared by normal online commands and offline sync commands.
/// Sync-only concerns such as conflict timestamps and client identity validation stay
/// in the sync command path.
/// </summary>
internal static class CategoryCommandRules
{
    public static Category Create(
        CategoryCreateDto dto,
        string shopId
    ) =>
        Category.Create(
            dto.Name,
            shopId,
            dto.Code,
            dto.Description,
            dto.IsActive);

    public static void Apply(
        Category category,
        CategoryCreateDto dto
    ) =>
        Apply(category, dto.Name, dto.Code, dto.Description, dto.IsActive);

    public static void Apply(
        Category category,
        CategoryUpdateDto dto
    ) =>
        Apply(category, dto.Name, dto.Code, dto.Description, dto.IsActive);

    public static Result<CategoryDto> DuplicateName() =>
        Result<CategoryDto>.FailureResult(
            "CategoryNameAlreadyExists",
            "A category with this name already exists in this shop.");

    private static void Apply(
        Category category,
        string name,
        string? code,
        string? description,
        bool isActive
    )
    {
        category.SetName(name);
        category.SetCode(code);
        category.SetDescription(description);

        if (isActive)
            category.Activate();
        else
            category.Deactivate();
    }
}