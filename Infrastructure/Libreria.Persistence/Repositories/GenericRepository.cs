using Libreria.Domain.Common;
using Libreria.Domain.Interfaces;
using Libreria.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Libreria.Persistence.Repositories;

public class GenericRepository<T> : IGenericRepository<T>where T : BaseEntity
{
    protected readonly LibreriaDbContext _context;
    protected readonly DbSet<T> _dbSet;
    public GenericRepository(LibreriaDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }
    public async Task<T> GetByIdAsync(Guid id)
    {
        return await _dbSet
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<IReadOnlyList<T>> GetAllAsync()
    {
        return await _dbSet
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<T> CreateAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<T> UpdateAsync(T entity)
    {
        _dbSet.Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> DeleteAsync(T entity)
    {
        _dbSet.Remove(entity);
        await _context.SaveChangesAsync();
        return true;
    }
}