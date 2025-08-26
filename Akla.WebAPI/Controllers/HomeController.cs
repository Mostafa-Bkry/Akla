namespace Akla.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly CustomerServices _customerServices;

        public HomeController(CustomerServices customerServices)
        {
            _customerServices = customerServices;
        }

        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetAll()
        {
            var customers = await _customerServices.GetAllAsync();
            return Ok(customers);
        }
    }
}
