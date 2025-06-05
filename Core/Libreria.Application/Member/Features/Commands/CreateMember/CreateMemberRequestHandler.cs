using AutoMapper;
using Libreria.Application.Exceptions;
using MediatR;
using Libreria.Domain.Interfaces;

namespace Libreria.Application.Member.Features.Commands.CreateMember;

public class CreateMemberRequestHandler : IRequestHandler<CreateMemberRequest, Guid>
{
    private readonly IMapper _mapper;
    private readonly IMemberRepository _memberRepository;
    
    public CreateMemberRequestHandler(IMemberRepository memberRepository, IMapper mapper)
    {
        _mapper = mapper;
        _memberRepository = memberRepository;
    }
    public async Task<Guid> Handle(CreateMemberRequest request, CancellationToken cancellationToken)
    {
        var validator = new CreateMemberRequestValidator(_mapper,_memberRepository);
        var validatorResult = await validator.ValidateAsync(request);
        
        if (validatorResult.IsValid == false)
        {
            throw new BadRequestException("Error en la validacion de los datos",validatorResult.ToDictionary());
        }
        var member = _mapper.Map<Domain.Member>(request);
        await _memberRepository.CreateAsync(member);
        
        return member.Id;
    }
    
}

