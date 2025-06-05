using Libreria.Domain.Common;

namespace Libreria.Domain.Interfaces;

public interface IGenericRepository<T>where T : BaseEntity 
{
    Task<T> GetByIdAsync(Guid id);
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<T> CreateAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<bool> DeleteAsync(T entity);
}