using AutoMapper;
using Libreria.Application.Exceptions;
using Libreria.Domain.Interfaces;
using MediatR;

namespace Libreria.Application.Member.Features.Commands.UpdateMember;

public class UpdateMemberRequestHandler : IRequestHandler<UpdateMemberRequest, Unit>
{
    private readonly IMemberRepository _memberRepository;
    private readonly IMapper _mapper;

    public UpdateMemberRequestHandler(IMapper mapper,IMemberRepository memberRepository)
    {
        _mapper = mapper;
        _memberRepository = memberRepository;
    }

    public async Task<Unit> Handle(UpdateMemberRequest request, CancellationToken cancellationToken)
    {
        var validator = new UpdateMemberRequestValidator();
        var validatorResult = await validator.ValidateAsync(request);
        if (validatorResult.Errors.Any())
        {
            throw new BadRequestException("Error al validar datos", validatorResult.ToDictionary());
        }
        
        var member = await _memberRepository.GetByIdAsync(request.Id);
        if (member == null)
        {
            throw new NotFoundException(nameof(member), request.Id.ToString());
        }
        _mapper.Map(request, member);
        await _memberRepository.UpdateAsync(member);
        return Unit.Value;
    }
}