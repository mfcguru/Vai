using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Vai.Frontend.Core.Services;
using Vai.Frontend.Core.Usecases.Process;
using Vai.Frontend.Infrastructure.Configuration;
using Vai.Shared.Models;
using Vai.Shared.Models.Process;
using Vai.Shared.Params;
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

        public async Task<CommandResult<GetAllProcessesCommandModel>> GetAllProcesses(int page, int pageSize)
        {
            var url = client.BaseAddress + "api/process/getAllProcesses?page=" + page.ToString() + "&pageSize=" + pageSize.ToString();

            var json = await client.GetStringAsync(url);

            var result = JsonConvert.DeserializeObject<CommandResult<GetAllProcessesCommandModel>>(json);

            return result;
        }

        public async Task<CommandResult<GetAllBacklogItemsCommandModel>> GetAllBacklogItems(int page, int pageSize)
        {
            var url = client.BaseAddress + "api/process/getAllBacklogItems?page=" + page.ToString() + "&pageSize=" + pageSize.ToString();

            var json = await client.GetStringAsync(url);

            var result = JsonConvert.DeserializeObject<CommandResult<GetAllBacklogItemsCommandModel>>(json);

            return result;
        }

        public async Task<CommandResult<GetProcessCommandModel>> GetProcess(int processId)
        {
            var url = "api/process/getProcess?id=" + processId.ToString();

            var json = await client.GetStringAsync(url);

            var result = JsonConvert.DeserializeObject<CommandResult<GetProcessCommandModel>>(json);

            return result;
        }

        public async Task<CommandResult> AddProcess(AddProcessCommandParams parameters)
        {
            var url = "api/process/addProcess/";

            await client.PostAsJsonAsync(url, parameters);

            return new CommandResult();
        }

        public async Task<CommandResult> EditProcess(EditProcessCommandParams parameters)
        {
            var url = "api/process/editProcess/";

            await client.PutAsJsonAsync(url, parameters);

            return new CommandResult();
        }
    }
}
