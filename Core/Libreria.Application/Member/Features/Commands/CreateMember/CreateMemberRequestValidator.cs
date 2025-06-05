using AutoMapper;
using FluentValidation;
using Libreria.Application.Member.Features.Commands._Share;
using Libreria.Domain.Interfaces;

namespace Libreria.Application.Member.Features.Commands.CreateMember;

public class CreateMemberRequestValidator : AbstractValidator<CreateMemberRequest>
{
    private readonly IMemberRepository _memberRepository;
    private readonly IMapper _mapper;
    public CreateMemberRequestValidator(IMapper mapper,IMemberRepository memberRepository)
    {
        _mapper = mapper;
        _memberRepository = memberRepository;
        
        Include(new BaseMemberRequestValidator());
        
        RuleFor(t=>t)
            .MustAsync(UniqueMember).WithMessage("Ya existe un miembro con esos datos");
            
    }

    private async Task<bool> UniqueMember(CreateMemberRequest request, CancellationToken token)
    {
        var member = _mapper.Map<Domain.Member>(request);
        return await _memberRepository.IsMemberUnique(member); 
    }
}