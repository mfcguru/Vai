using System.Threading.Tasks;
using Vai.Frontend.Core.Services;
using Vai.Shared.Interfaces.Process;
using Vai.Shared.Params;
using Vai.Shared.Results;

namespace Vai.Frontend.Core.Usecases.Process
{
    public class AddProcessCommand : IAddProcessCommand
    {
        private readonly IApiService apiService;

        public AddProcessCommand(IApiService apiService)
        {
            this.apiService = apiService;
        }

        public Task<CommandResult> Execute(AddProcessCommandParams parameters)
        {
            return apiService.AddProcess(parameters);
        }
    }
}
