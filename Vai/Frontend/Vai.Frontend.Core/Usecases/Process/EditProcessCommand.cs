using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vai.Frontend.Core.Services;
using Vai.Shared.Interfaces.Process;
using Vai.Shared.Params;
using Vai.Shared.Results;

namespace Vai.Frontend.Core.Usecases.Process
{
    class EditProcessCommand : IEditProcessCommand
    {
        private readonly IApiService apiService;

        public EditProcessCommand(IApiService apiService)
        {
            this.apiService = apiService;
        }

        public Task<CommandResult> Execute(EditProcessCommandParams parameters)
        {
            return apiService.EditProcess(parameters.ProcessId, parameters.Client, parameters.Robot, parameters.TaskDescription, parameters.Efficiency, parameters.Status, parameters.Priority);
        }
    }
}
