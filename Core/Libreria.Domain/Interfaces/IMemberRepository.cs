namespace Libreria.Domain.Interfaces;

public interface IMemberRepository : IGenericRepository<Member>
{
    Task<bool> IsMemberUnique(Member member);
}