using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Vai.Frontend.Core.Services;
using Vai.Shared.Interfaces.Process;
using Vai.Shared.Models;
using Vai.Shared.Params;
using Vai.Shared.Results;

namespace Vai.Frontend.Core.Usecases.Process
{
    public class GetAllProcessesCommand : IGetAllProcessesCommand
    {
        private readonly IApiService apiService;

        public GetAllProcessesCommand(IApiService apiService)
        {
            this.apiService = apiService;
        }

        public async Task<CommandResult<List<GetAllProcessesCommandModel>>> Execute(GetAllProcessesCommandParams parameters)
        {
            return await apiService.GetAllProcesses(parameters.Page, parameters.PageSize);
        }
    }
}
