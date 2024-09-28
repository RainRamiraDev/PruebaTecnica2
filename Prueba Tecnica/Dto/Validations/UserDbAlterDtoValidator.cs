using FluentValidation;

namespace PruebaTecnica.Dto.Validations
{
    public class UserDbAlterDtoValidator : AbstractValidator<UserDbAlterDto>
    {

        public UserDbAlterDtoValidator() {

            RuleFor(x => x.Nombre)
           .NotEmpty().WithMessage("El nombre es obligatorio.")
           .Length(1, 15).WithMessage("El nombre debe tener al menos 1 caracter")
           .Matches(@"^(?!string$).*$").WithMessage("El nombre no puede ser el texto 'string'.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("El email es obligatorio.")
                .EmailAddress().WithMessage("El formato del email no es válido, debe contener un @");

            RuleFor(x => x.Contraseña)
                .NotEmpty().WithMessage("La contraseña es obligatoria.")
                .MinimumLength(4).WithMessage("La contraseña debe tener al menos 4 caracteres.")
                .Matches(@"^(?!string$).*$").WithMessage("La contraseña no puede ser el texto 'string'.");
        }
    }
}
