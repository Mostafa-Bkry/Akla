using System.Linq.Expressions;

namespace Akla.Services.Services
{
    public class CustomerServices : ICustomerServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<Customer> _customerRepo;

        public CustomerServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _customerRepo = _unitOfWork.Repository<Customer>();
        }

        public async Task<Customer> GetCustomerByIdAsync(long id)
        {
            try
            {
                var result = await _customerRepo.GetByIdAsync(id);
                if (result is not null)
                    return result;

                throw new KeyNotFoundException($"Customer with id {id} not found.");
            }
            catch (Exception ex)
            {
                throw new CustomException(ex.Message, ex);
            }
        }

        public async Task<List<Customer>> GetAllCustomersAsync(bool isAsNoTracking)
        {
            try
            {
                var result = await _customerRepo.GetAllAsync(isAsNoTracking);
                return result.ToList() ?? new List<Customer>();
            }
            catch (Exception ex)
            {
                throw new CustomException(ex.Message, ex);
            }
        }

        public async Task<List<Customer>>GetAllCustomersAsync(Expression<Func<Customer, bool>> predicate, bool isAsNoTracking)
        {
            try
            {
                var result = await _customerRepo.GetAllAsync(predicate, isAsNoTracking);
                return result.ToList() ?? new List<Customer>();
            }
            catch (Exception ex)
            {
                throw new CustomException(ex.Message, ex);
            }
        }

        public async Task<List<Customer>> GetFilteredCustomersAsync(Expression<Func<Customer>> predicate, bool isAsNoTracking)
        {
            try
            {
                var result = await _customerRepo.GetAllAsync(isAsNoTracking);
                return result.ToList() ?? new List<Customer>();
            }
            catch (Exception ex)
            {
                throw new CustomException(ex.Message, ex);
            }
        }

        public async Task AddCustomerAsync(Customer entity)
        {
            try
            {
                await _customerRepo.AddAsync(entity);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new CustomException(ex.Message, ex);
            }
        }

        public async Task AddRangeAsync(IEnumerable<Customer> entities)
        {
            try
            {
                await _customerRepo.AddRangeAsync(entities);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new CustomException(ex.Message, ex);
            }
        }

        public async Task UpdateAsync(Customer entity)
        {
            try
            {
                await _customerRepo.UpdateAsync(entity);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new CustomException(ex.Message, ex);
            }
        }

        public async Task DeleteAsync(long id)
        {
            try
            {
                await _customerRepo.DeleteAsync(id);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new CustomException(ex.Message, ex);
            }
        }

        public async Task DeleteAsync(Customer entity)
        {
            try
            {
                await _customerRepo.DeleteAsync(entity);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new CustomException(ex.Message, ex);
            }
        }
    }
}
