using Libreria.Application.Exceptions;
using Libreria.Domain.Interfaces;
using MediatR;

namespace Libreria.Application.Member.Features.Commands.DeleteMember;

public class DeleteMemberRequestHandler : IRequestHandler<DeleteMemberRequest, Unit>
{
    private IMemberRepository _memberRepository;
    
    public DeleteMemberRequestHandler(IMemberRepository memberRepository)
    {
        _memberRepository = memberRepository;
    }
    public async Task<Unit> Handle(DeleteMemberRequest request, CancellationToken cancellationToken)
    {
        var member = await _memberRepository.GetByIdAsync(request.Id);
        if (member == null)
        {
            throw new NotFoundException(nameof(member), request.Id.ToString());
        }
        await _memberRepository.DeleteAsync(member);
        return Unit.Value;
    }
    
}