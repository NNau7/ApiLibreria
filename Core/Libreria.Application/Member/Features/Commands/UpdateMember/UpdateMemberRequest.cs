using Libreria.Application.Member.Features.Commands._Share;
using MediatR;

namespace Libreria.Application.Member.Features.Commands.UpdateMember;

public class UpdateMemberRequest : BaseMemberRequest,IRequest<Unit>
{
    public Guid Id { get; set; }
}