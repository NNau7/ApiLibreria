using FluentValidation;

namespace Libreria.Application.Member.Features.Commands._Share;

public class BaseMemberRequestValidator : AbstractValidator<BaseMemberRequest>
{
    public BaseMemberRequestValidator()
    {
        RuleFor(t => t.Name)
            .NotEmpty().WithMessage("{PropertyName} es requerido}")
            .NotNull()
            .MaximumLength(50).WithMessage("El nombre no debe ser mayor a 50 caracteres");
        RuleFor(t => t.LastName)
            .NotEmpty().WithMessage("{PropertyName} es requerido}")
            .NotNull()
            .MaximumLength(50).WithMessage("El apellido no debe ser mayor a 50 caracteres");
        RuleFor(t => t.Email)
            .NotEmpty().WithMessage("{PropertyName} es requerido}")
            .NotNull()
            .EmailAddress().WithMessage("Escribe correctamente el formato del email")
            .MaximumLength(50).WithMessage("El email no debe ser mayor a 50 caracteres");
        RuleFor(t => t.Phone)
            .NotEmpty().WithMessage("{PropertyName} es requerido}")
            .NotNull()
            .MaximumLength(12).WithMessage("El telefono no debe ser mayor a 12 caracteres");
        RuleFor(t => t.PostalCode)
            .NotEmpty().WithMessage("{PropertyName} es requerido}")
            .NotNull();

    }
}