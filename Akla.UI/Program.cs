using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace Akla.UI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#Akla");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(
                sp => new HttpClient { 
                    BaseAddress = new Uri(sp.GetRequiredService<IConfiguration>()["APIhost"] 
                        ?? builder.HostEnvironment.BaseAddress
                        ) 
                });

            await builder.Build().RunAsync();
        }
    }
}
