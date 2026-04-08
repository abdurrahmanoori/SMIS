using FluentValidation;
using SMIS.Application.Features.Categories.Commands;

namespace SMIS.Application.Features.Categories.Validators
{
    public class CategoryUpdateCommandValidator : AbstractValidator<CategoryUpdateCommand>
    {
        public CategoryUpdateCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Category ID is required");

            RuleFor(x => x.CategoryUpdateDto.Name)
                .NotEmpty().WithMessage("Category Name is required")
                .MaximumLength(200).WithMessage("Name must not exceed 200 characters");

            RuleFor(x => x.CategoryUpdateDto.Code)
                .MaximumLength(50).WithMessage("Code must not exceed 50 characters")
                .When(x => !string.IsNullOrEmpty(x.CategoryUpdateDto.Code));

            RuleFor(x => x.CategoryUpdateDto.Description)
                .MaximumLength(500).WithMessage("Description must not exceed 500 characters")
                .When(x => !string.IsNullOrEmpty(x.CategoryUpdateDto.Description));
        }
    }
}