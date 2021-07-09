using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using Vai.Frontend.Core.Services;
using Vai.Frontend.Infrastructure.Configuration;

namespace Vai.Frontend.Infrastructure.Services
{
    public class ApiService : IApiService
    {
        private readonly IOptions<ApiConfiguration> configuration;

        public ApiService(IOptions<ApiConfiguration> configuration)
        {
            this.configuration = configuration;
        }
    }
}
