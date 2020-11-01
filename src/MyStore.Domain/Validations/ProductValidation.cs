using FluentValidation;
using MyStore.Domain.Models;

namespace MyStore.Domain.Validations
{
    public class ProductValidation : AbstractValidator<Product>
    {
        public ProductValidation()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("The {PropertyName} field is required")
                .Length(2, 200).WithMessage("The {PropertyName} field must have beetwen {MinLength} and {MaxLength} characters");

            RuleFor(c => c.Description)
                .NotEmpty().WithMessage("The {PropertyName} field is required")
                .Length(2, 1000).WithMessage("The {PropertyName} field must have beetwen {MinLength} and {MaxLength} characters");

            RuleFor(c => c.Price)
                .GreaterThan(0).WithMessage("The {PropertyName} field must be greater than {ComparisonValue}");
        }
    }
}
