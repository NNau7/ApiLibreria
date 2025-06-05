using FluentValidation;
using Libreria.Application.Member.Features.Commands._Share;

namespace Libreria.Application.Member.Features.Commands.UpdateMember;

public class UpdateMemberRequestValidator : AbstractValidator<UpdateMemberRequest>
{
    public UpdateMemberRequestValidator()
    {
        RuleFor(t => t.Id)
            .GreaterThanOrEqualTo(Guid.Empty).WithMessage("El id debe ser mayor a 0");
        
        Include(new BaseMemberRequestValidator());
    }
}