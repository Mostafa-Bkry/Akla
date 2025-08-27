namespace Akla.UI.Services
{
    public interface IUIServices<T>
    {
        Task<T> GetByIdAsync(long id);
        Task<List<T>> GetAllAsync();

        Task AddAsync(T entity);
        Task<T> UpdateAsync(long id, T entity);
        Task<bool> DeleteAsync(long id);
    }
}
