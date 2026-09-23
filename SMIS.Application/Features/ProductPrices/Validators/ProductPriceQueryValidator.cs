using FluentValidation;
using SMIS.Application.Common.Queries;
using SMIS.Application.Features.ProductPrices.Queries;

namespace SMIS.Application.Features.ProductPrices.Validators;

public sealed class ProductPriceQueryValidator : AbstractValidator<ProductPriceQuery>
{
    public ProductPriceQueryValidator()
    {
        RuleFor(request => request.Query.PageNumber)
            .GreaterThanOrEqualTo(1);

        RuleFor(request => request.Query.PageSize)
            .InclusiveBetween(1, PagedQuery.MaxPageSize);
    }
}