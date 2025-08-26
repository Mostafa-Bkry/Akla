namespace Akla.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerServices _customerServices;

        public CustomersController(ICustomerServices customerServices)
        {
            _customerServices = customerServices;
        }

        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetAll()
        {
            try
            {
                var customers = await _customerServices.GetAllCustomersAsync(isAsNoTracking: true);
                return Ok(customers);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return BadRequest();
        }

        [HttpGet("search")]
        public async Task<ActionResult<List<Customer>>> GetAll([FromQuery] string phoneSearch)
        {
            var customers = await _customerServices
                .GetAllCustomersAsync(c => c.PhoneNumbers.Where(phone => phone.PhoneNumber.Contains(phoneSearch)).Any(), isAsNoTracking: true);
            return Ok(customers);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Customer>> GetCustomer(long id)
        {
            var customer = await _customerServices.GetCustomerByIdAsync(id);
            return Ok(customer);
        }

        [HttpPost]
        public async Task<ActionResult<Customer>> AddCustomer(Customer model)
        {
            await _customerServices.AddCustomerAsync(model);
            var customer = await _customerServices.GetCustomerByIdAsync(model.Id);
            return Ok(customer);
        }
    }
}
