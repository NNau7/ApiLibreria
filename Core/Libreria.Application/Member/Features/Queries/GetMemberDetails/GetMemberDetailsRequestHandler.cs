using AutoMapper;
using Libreria.Application.DTOs;
using Libreria.Domain.Interfaces;
using MediatR;

namespace Libreria.Application.Member.Features.Queries.GetMemberDetails;

public class GetMemberDetailsRequestHandler : IRequestHandler<GetMemberDetailsRequest, MemberDetailsDto>
{
    private readonly IMemberRepository _memberRepository;
    private readonly IMapper _mapper;

    public GetMemberDetailsRequestHandler(IMapper mapper, IMemberRepository memberRepository)
    {
        _mapper = mapper;
        _memberRepository = memberRepository;
    }
    
    public async Task<MemberDetailsDto> Handle(GetMemberDetailsRequest request, CancellationToken cancellationToken)
    {
        var memberDetails = await _memberRepository.GetByIdAsync(request.Id);
        var memberDetailsDto = _mapper.Map<MemberDetailsDto>(memberDetails);
        return memberDetailsDto;
    }
}