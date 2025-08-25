namespace Akla.WebAPI.Services
{
    public class CustomerServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<Customer> _customerRepo;

        public CustomerServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _customerRepo = _unitOfWork.Repository<Customer>();
        }

        public async Task<List<Customer>> GetAll()
        {
            var result = await _customerRepo.GetAllAsync();
            return result.ToList() ?? new List<Customer>();
        }
    }
}
