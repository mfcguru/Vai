using System.Collections.Generic;
using System.Threading.Tasks;

namespace Vai.Backend.Core.UseCases.Process
{
    using Vai.Shared.Interfaces.Process;
    using Vai.Shared.Models;
    using Vai.Shared.Params;
    using Vai.Shared.Results;

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
