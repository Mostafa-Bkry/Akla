using Akla.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Akla.Services
{
    public static class Extensions
    {
        public static IServiceCollection AddAklaServices(this IServiceCollection services)
        {
            services.AddScoped<IAPIServices<Customer>, CustomerServices>();
            return services;
        }
    }
}
