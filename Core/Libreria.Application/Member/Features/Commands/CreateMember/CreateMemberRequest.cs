using Libreria.Application.Member.Features.Commands._Share;
using MediatR;

namespace Libreria.Application.Member.Features.Commands.CreateMember;

public class CreateMemberRequest : BaseMemberRequest, IRequest<Guid>
{
}