using CA_InterfaceAdapters_Mappers.DTOs.Requests;
using FluentValidation;

namespace CA_FrameworkDrivers_API.Validator
{
    public class BeerValidator : AbstractValidator<BeerRequestDTO>
    {
        public BeerValidator()
        {
            RuleFor(dto => dto.Name).NotEmpty().WithMessage("The beer needs to have a name.");
            RuleFor(dto => dto.Style).NotEmpty().WithMessage("The beer needs to have a style.");
            RuleFor(dto => dto.Alcohol).GreaterThan(0).NotEmpty().WithMessage("The beer needs to have alcohol.");
        }
    }
}
