using AutoMapper;
using Libreria.Application.DTOs;
using Libreria.Domain.Interfaces;
using MediatR;

namespace Libreria.Application.Member.Features.Queries.GetAllMembers;

public class GetAllMembersRequestHandler : IRequestHandler<GetAllMembersRequest, List<MemberDto>>
{
    private readonly IMapper _mapper;
    private readonly IMemberRepository _memberRepository;
    
    public GetAllMembersRequestHandler(IMapper mapper, IMemberRepository memberRepository)
    {
        _mapper = mapper;
        _memberRepository = memberRepository;
        
    }

    public async Task<List<MemberDto>> Handle(GetAllMembersRequest request, CancellationToken cancellationToken)
    {
        var members = await _memberRepository.GetAllAsync();
        var result = _mapper.Map<List<MemberDto>>(members);
        return result;
    }
}