using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Vai.Frontend.Core.Services;
using Vai.Frontend.Core.Usecases.Process;
using Vai.Frontend.Infrastructure.Configuration;
using Vai.Shared.Models;
using Vai.Shared.Results;

namespace Vai.Frontend.Infrastructure.Services
{
    public class ApiService : IApiService
    {
        private readonly IOptions<ApiConfiguration> configuration;
        private readonly HttpClient client;

        public ApiService(IOptions<ApiConfiguration> configuration, HttpClient client)
        {
            this.configuration = configuration;
            this.client = client;
        }

        public async Task<CommandResult<List<GetAllProcessesCommandModel>>> GetAllProcesses(int page, int pageSize)
        {
            var url = client.BaseAddress + "api/process/getAllProcesses?page=" + page.ToString() + "&pageSize=" + pageSize.ToString();

            var json = await client.GetStringAsync(url);

            var result = JsonConvert.DeserializeObject<CommandResult<List<GetAllProcessesCommandModel>>>(json);

            return result;
        }

        public async Task<CommandResult<List<GetAllBacklogItemsCommandModel>>> GetAllBacklogItems(int page, int pageSize)
        {
            var url = client.BaseAddress + "api/process/getAllBacklogItems?page=" + page.ToString() + "&pageSize=" + pageSize.ToString();

            var json = await client.GetStringAsync(url);

            var result = JsonConvert.DeserializeObject<CommandResult<List<GetAllBacklogItemsCommandModel>>>(json);

            return result;
        }
    }
}
