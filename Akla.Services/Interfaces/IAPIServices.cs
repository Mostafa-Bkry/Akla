using System.Linq.Expressions;

namespace Akla.Services.Interfaces
{
    public interface IAPIServices<T>
    {
        Task<T> GetByIdAsync(long id);
        Task<List<T>> GetAllAsync(bool isAsNoTracking);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate, bool isAsNoTracking);

        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        Task UpdateAsync(T entity);
        Task DeleteAsync(long id);
        Task DeleteAsync(T entity);
    }
}
