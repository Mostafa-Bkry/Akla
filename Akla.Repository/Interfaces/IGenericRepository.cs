namespace Akla.Repository.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T?> GetByIdAsync(long id);
        Task<IEnumerable<T>> GetAllAsync(bool isAsNoTracking = false);

        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate, bool isAsNoTracking = false);

        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        Task UpdateAsync(T entity);
        Task DeleteAsync(long id);
        Task DeleteAsync(T entity);
    }
}
