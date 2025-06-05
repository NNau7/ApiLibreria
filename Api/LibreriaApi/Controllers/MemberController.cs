using Libreria.Application.DTOs;
using Libreria.Application.Member.Features.Commands._Share;
using Libreria.Application.Member.Features.Commands.CreateMember;
using Libreria.Application.Member.Features.Commands.DeleteMember;
using Libreria.Application.Member.Features.Commands.UpdateMember;
using Libreria.Application.Member.Features.Queries.GetAllMembers;
using Libreria.Application.Member.Features.Queries.GetMemberDetails;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibreriaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MemberController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<MemberDto>>> GetAllMembers()
        {
            var result = await _mediator.Send(new GetAllMembersRequest());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MemberDetailsDto>> GetById(Guid id)
        {
            var result = await _mediator.Send(new GetMemberDetailsRequest(id));
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateMemberRequest member)
        {
            var response = await _mediator.Send(member);
            return CreatedAtAction(nameof(Post), new { id = response });
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(UpdateMemberRequest member)
        {
            await _mediator.Send(member);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var command = new DeleteMemberRequest(id);
            await _mediator.Send(command);
            return NoContent();
        }
        
    }
    
}
