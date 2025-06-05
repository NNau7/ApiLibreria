using Libreria.Application.DTOs;
using MediatR;

namespace Libreria.Application.Member.Features.Queries.GetAllMembers;

public record GetAllMembersRequest() : IRequest<List<MemberDto>>
{
    
}