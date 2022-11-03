using FluentValidation;

namespace MP.ApiDotNet6.Application.Dtos.Validations {
    public class ProductDTOValidator : AbstractValidator<ProductDTO> {

        public ProductDTOValidator() {

            RuleFor(p => p.CodErp)
                .NotEmpty()
                .NotNull()
                .WithMessage("CodErp deve ser informado");

            RuleFor(p => p.Name)
                .NotNull()
                .NotEmpty()
                .WithMessage("Name deve ser informado");

            RuleFor(p => p.Price)
                .GreaterThan(0)
                .WithMessage("Price deve ser informado");

        }

    }
}
