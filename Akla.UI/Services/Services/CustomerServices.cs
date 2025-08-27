namespace Akla.UI.Services
{
    public class CustomerServices : IUIServices<CustomerDTO>
    {
        private readonly HttpClient _httpClient;

        public CustomerServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CustomerDTO> GetByIdAsync(long id)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomerDTO>($"/api/Customers/{id}");
            return response;
        }

        public async Task<List<CustomerDTO>> GetAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<CustomerDTO>>("/api/Customers") ?? new List<CustomerDTO>();
        }

        public async Task AddAsync(CustomerDTO entity)
        {
            await _httpClient.PostAsJsonAsync("/api/Customers", entity);
        }

        public async Task<CustomerDTO> UpdateAsync(long id, CustomerDTO entity)
        {
            var response = await _httpClient.PutAsJsonAsync($"/api/Customers/{id}", entity);

            if (response.IsSuccessStatusCode)
            {
                // Try to deserialize the returned entity
                var updatedCustomer = await response.Content.ReadFromJsonAsync<CustomerDTO>();
                return updatedCustomer;
            }

            // Handle errors – you can log, throw, or return null
            var errorContent = await response.Content.ReadAsStringAsync();
            throw new HttpRequestException(
                $"Error updating customer with Id {id}. " +
                $"StatusCode: {response.StatusCode}, Response: {errorContent}");
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var response = await _httpClient.DeleteAsync($"/api/Customers/{id}");

            if (response.IsSuccessStatusCode)
                return true;

            return false;
        }
    }
}
