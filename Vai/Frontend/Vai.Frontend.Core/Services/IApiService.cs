using System.Collections.Generic;
using System.Threading.Tasks;
using Vai.Shared.Models;
using Vai.Shared.Results;

namespace Vai.Frontend.Core.Services
{
    public interface IApiService
    {
        Task<CommandResult<List<GetAllProcessesCommandModel>>> GetAllProcesses(int page, int pageSize);

        Task<CommandResult<List<GetAllBacklogItemsCommandModel>>> GetAllBacklogItems(int page, int pageSize);
    }
}
