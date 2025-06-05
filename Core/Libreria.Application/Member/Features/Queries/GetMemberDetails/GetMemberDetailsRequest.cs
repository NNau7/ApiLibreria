using Libreria.Application.DTOs;
using MediatR;

namespace Libreria.Application.Member.Features.Queries.GetMemberDetails;

public record GetMemberDetailsRequest(Guid Id) : IRequest<MemberDetailsDto>
{
    
}