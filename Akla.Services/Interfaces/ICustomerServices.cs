using System.Linq.Expressions;

namespace Akla.Services.Interfaces
{
    public interface ICustomerServices
    {
        Task<Customer> GetCustomerByIdAsync(long id);
        Task<List<Customer>> GetAllCustomersAsync(bool isAsNoTracking);
        Task<List<Customer>> GetAllCustomersAsync(Expression<Func<Customer, bool>> predicate, bool isAsNoTracking);

        Task AddCustomerAsync(Customer entity);
        Task AddRangeAsync(IEnumerable<Customer> entities);
        Task UpdateAsync(Customer entity);
        Task DeleteAsync(long id);
        Task DeleteAsync(Customer entity);
    }
}
