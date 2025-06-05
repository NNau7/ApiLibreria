using MediatR;

namespace Libreria.Application.Member.Features.Commands.DeleteMember;

public record DeleteMemberRequest(Guid Id) : IRequest<Unit>;