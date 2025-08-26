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
                return Ok(customers ?? new List<Customer>());
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return BadRequest(ModelState);
        }

        [HttpGet("search")]
        public async Task<ActionResult<List<CustomerDTO>>> GetAll([FromQuery] string phoneSearch)
        {
            try
            {
                var customers = await _customerServices
                        .GetAllCustomersAsync(c => c.PhoneNumbers
                            .Where(phone => phone.PhoneNumber.Contains(phoneSearch))
                            .Any()
                        , isAsNoTracking: true);

                var result = customers.Select(c => new CustomerDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                    JoinDate = c.JoinDate,
                    PhoneNumbers = c.PhoneNumbers.Select(p => p.PhoneNumber).ToList()
                }).ToList();

                return Ok(result ?? new List<CustomerDTO>());
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return BadRequest(ModelState);
        }

        [HttpGet("{id:long}")]
        public async Task<ActionResult<Customer>> GetCustomer(long id)
        {
            try
            {
                var customer = await _customerServices.GetCustomerByIdAsync(id);
                if(customer != null)
                    return Ok(customer);

                ModelState.AddModelError("", $"Customer With Id = {id} Not Found");
                return NotFound(ModelState);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return BadRequest(ModelState);
        }

        [HttpPost]
        public async Task<ActionResult<Customer>> AddCustomer(Customer model)
        {
            try
            {
                await _customerServices.AddCustomerAsync(model);
                var customer = await _customerServices.GetCustomerByIdAsync(model.Id);
                if(customer != null)
                    return Ok(customer);

                ModelState.AddModelError("","Faild to add this customer");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return BadRequest(ModelState);
        }

        [HttpPost("many")]
        public async Task<ActionResult<Customer>> AddManyCustomers(List<Customer> model)
        {
            try
            {
                await _customerServices.AddRangeOfCustomersAsync(model);
                var customers = await _customerServices
                    .GetAllCustomersAsync(c => model.Contains(c), true);

                if(customers != null && customers.Count == model.Count) 
                    return Ok(customers);

                ModelState.AddModelError("", "Faild to add all these customers or some of them");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return BadRequest(ModelState);
        }

        [HttpPut("{id:long}")]
        public async Task<ActionResult<Customer>> UpdateCustomer(long id, Customer model)
        {
            if (id != model.Id)
            {
                ModelState.AddModelError("", "ID in URL does not match ID in body.");
                return BadRequest(ModelState);
            }

            try
            {    
                var existingCustomer = await _customerServices.GetCustomerByIdAsync(id);
                if (existingCustomer == null)
                {
                    ModelState.AddModelError("", $"Customer With Id = {id} Not Found");
                    return NotFound(ModelState);
                }

                await _customerServices.UpdateAsync(model);
                return Ok(existingCustomer);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return BadRequest(ModelState);
        }

        [HttpDelete("{id:long}")]
        public async Task<ActionResult<Customer>> DeleteCustomer(long? id, Customer model)
        {
            if (id.HasValue && id != model.Id)
            {
                ModelState.AddModelError("", "ID in URL does not match ID in body.");
                return BadRequest(ModelState);
            }

            try
            {
                var existingCustomer = await _customerServices.GetCustomerByIdAsync(id ?? model.Id);
                if (existingCustomer == null)
                {
                    ModelState.AddModelError("", $"Customer With Id = {id} Not Found");
                    return NotFound(ModelState);
                }

                await _customerServices.DeleteAsync(model);
                return Ok("Deleted Successfully");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return BadRequest(ModelState);
        }
    }
}
