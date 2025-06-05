using AutoMapper;
using Libreria.Application.DTOs;
using Libreria.Application.Member.Features.Commands.CreateMember;
using Libreria.Application.Member.Features.Commands.UpdateMember;

namespace Libreria.Application.Mapping.MapperProfile;

public class MemberProfile : Profile
{
    public MemberProfile()
    {
        CreateMap<UpdateMemberRequest, Domain.Member>();
        CreateMap<CreateMemberRequest, Domain.Member>();
        CreateMap<MemberDto, Domain.Member>().ReverseMap();
        CreateMap<MemberDetailsDto,Domain.Member>().ReverseMap();
    }
}