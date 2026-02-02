using FluentValidation;
using SMIS.Application.Features.Categories.Commands;

namespace SMIS.Application.Features.Categories.Validators
{
    public class CategoryCreateCommandValidator : AbstractValidator<CategoryCreateCommand>
    {
        public CategoryCreateCommandValidator()
        {
            RuleFor(x => x.CategoryCreateDto.Name)
                .NotEmpty().WithMessage("Name is required")
                .MaximumLength(200).WithMessage("Name must not exceed 200 characters");

            RuleFor(x => x.CategoryCreateDto.Code)
                .MaximumLength(50).WithMessage("Code must not exceed 50 characters")
                .When(x => !string.IsNullOrEmpty(x.CategoryCreateDto.Code));

            RuleFor(x => x.CategoryCreateDto.Description)
                .MaximumLength(500).WithMessage("Description must not exceed 500 characters")
                .When(x => !string.IsNullOrEmpty(x.CategoryCreateDto.Description));

            RuleFor(x => x.CategoryCreateDto.ShopId)
                .NotEmpty().WithMessage("ShopId is required");
        }
    }
}