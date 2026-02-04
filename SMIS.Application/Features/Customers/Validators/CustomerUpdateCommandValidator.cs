using FluentValidation;
using SMIS.Application.Features.Customers.Commands;

namespace SMIS.Application.Features.Customers.Validators
{
    public class CustomerUpdateCommandValidator : AbstractValidator<CustomerUpdateCommand>
    {
        public CustomerUpdateCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Id is required");

            RuleFor(x => x.CustomerCreateDto.FirstName)
                .NotEmpty().WithMessage("First name is required")
                .MaximumLength(100).WithMessage("First name must not exceed 100 characters");

            RuleFor(x => x.CustomerCreateDto.ShopId)
                .NotEmpty().WithMessage("ShopId is required");

            RuleFor(x => x.CustomerCreateDto.LastName)
                .MaximumLength(100).WithMessage("Last name must not exceed 100 characters")
                .When(x => !string.IsNullOrEmpty(x.CustomerCreateDto.LastName));

            RuleFor(x => x.CustomerCreateDto.FatherName)
                .MaximumLength(100).WithMessage("Father name must not exceed 100 characters")
                .When(x => !string.IsNullOrEmpty(x.CustomerCreateDto.FatherName));

            RuleFor(x => x.CustomerCreateDto.Email)
                .EmailAddress().WithMessage("Invalid email format")
                .MaximumLength(100).WithMessage("Email must not exceed 100 characters")
                .When(x => !string.IsNullOrEmpty(x.CustomerCreateDto.Email));

            //RuleFor(x => x.CustomerCreateDto.PhoneNumber)
            //    .MinimumLength(8).WithMessage("Phone number must be at least 8 characters")
            //    .MaximumLength(20).WithMessage("Phone number must not exceed 20 characters")
            //    .Matches(@"^\\+?[\\d\\s\\-()]+$").WithMessage("Invalid phone number format")
            //    .When(x => !string.IsNullOrEmpty(x.CustomerCreateDto.PhoneNumber));

            RuleFor(x => x.CustomerCreateDto.Address)
                .MaximumLength(500).WithMessage("Address must not exceed 500 characters")
                .When(x => !string.IsNullOrEmpty(x.CustomerCreateDto.Address));

            RuleFor(x => x.CustomerCreateDto.TaxNumber)
                .MinimumLength(5).WithMessage("Tax number must be at least 5 characters")
                .MaximumLength(20).WithMessage("Tax number must not exceed 20 characters")
                .Matches(@"^[A-Z0-9\\-]+$").WithMessage("Tax number can only contain letters, numbers, and hyphens")
                .When(x => !string.IsNullOrEmpty(x.CustomerCreateDto.TaxNumber));


        }
    }
}