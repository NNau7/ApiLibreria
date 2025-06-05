using Libreria.Domain;
using Libreria.Domain.Interfaces;
using Libreria.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Libreria.Persistence.Repositories;

public class MemberRepository : GenericRepository<Member>, IMemberRepository
{
    public MemberRepository(LibreriaDbContext context) : base(context)
    {
        
    }

    public async Task<bool> IsMemberUnique(Member member)
    {
        return await _dbSet.AnyAsync(t =>
            t.Name == member.Name &&
            t.LastName == member.LastName &&
            t.PostalCode == member.PostalCode &&
            t.Email == member.Email &&
            t.Phone == member.Phone &&
            t.BirthDate == member.BirthDate) == false;
    }
}