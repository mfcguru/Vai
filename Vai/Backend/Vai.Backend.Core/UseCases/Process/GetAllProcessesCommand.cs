using System.Collections.Generic;
using System.Threading.Tasks;

namespace Vai.Backend.Core.UseCases.Process
{
    using Vai.Shared;
    using Vai.Shared.Feagtures.GetAllProcesses;

    public class GetAllProcessesCommand : IGetAllProcessesCommand
    {
        public async Task<CommandResult<List<GetAllProcessesCommandModel>>> Execute(GetAllProcessesCommandParams parameters)
        {
            var result = new List<GetAllProcessesCommandModel>();

            // perform logic here

            return new CommandResult<List<GetAllProcessesCommandModel>> { Data = result };
        }
    }
}
