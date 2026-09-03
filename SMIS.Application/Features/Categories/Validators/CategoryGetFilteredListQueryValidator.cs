using FluentValidation;
using SMIS.Application.Common.Queries;
using SMIS.Application.Features.Categories.Queries;

namespace SMIS.Application.Features.Categories.Validators;

public sealed class CategoryGetFilteredListQueryValidator
    : AbstractValidator<CategoryGetFilteredListQuery>
{
    public CategoryGetFilteredListQueryValidator()
    {
        RuleFor(request => request.Query.PageNumber)
            .GreaterThanOrEqualTo(1);

        RuleFor(request => request.Query.PageSize)
            .InclusiveBetween(1, PagedQuery.MaxPageSize);
    }
}
