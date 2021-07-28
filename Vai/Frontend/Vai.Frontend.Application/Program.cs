using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Vai.Frontend.Application
{
    using Vai.Frontend.Core.Services;
    using Vai.Frontend.Core.Usecases.Process;
    using Vai.Frontend.Infrastructure.Configuration;
    using Vai.Frontend.Infrastructure.Services;
    using Vai.Shared.Interfaces.Process;
    using Blazorise;
    using Blazorise.Bootstrap;
    using Blazorise.Icons.FontAwesome;

    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services
             .AddBlazorise(options =>
             {
                 options.ChangeTextOnKeyPress = true;
             })
             .AddBootstrapProviders()
             .AddFontAwesomeIcons();

            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddTransient<IApiService, ApiService>();
            builder.Services.AddTransient<IGetAllProcessesCommand, GetAllProcessesCommand>();
            builder.Services.AddTransient<IGetAllBacklogItemsCommand, GetAllBacklogItemsCommand>();
            builder.Services.AddTransient<IGetProcessCommand, GetProcessCommand>();

            await ConfigureSettings(builder);
            await builder.Build().RunAsync();
        }

        private static async Task ConfigureSettings(WebAssemblyHostBuilder builder)
        {
            var http = new HttpClient() { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
            builder.Services.AddScoped(sp => http);

            using var response = await http.GetAsync("apiConfiguration.json");
            using var stream = await response.Content.ReadAsStreamAsync();

            builder.Configuration.AddJsonStream(stream);
            builder.Services.Configure<ApiConfiguration>(options => builder.Configuration.GetSection("ApiConfiguration").Bind(options));
        }
    }
}
