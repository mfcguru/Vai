using System.Threading.Tasks;
using Vai.Frontend.Core.Services;
using Vai.Shared.Interfaces.Process;
using Vai.Shared.Models;
using Vai.Shared.Results;

namespace Vai.Frontend.Core.Usecases.Process
{
    public class GetProcessCommand : IGetProcessCommand
    {
        private readonly IApiService apiService;

        public GetProcessCommand(IApiService apiService)
        {
            this.apiService = apiService;
        }

        public async Task<CommandResult<GetProcessCommandModel>> Execute(int parameters)
        {
            return await apiService.GetProcess(parameters);
        }
    }
}
