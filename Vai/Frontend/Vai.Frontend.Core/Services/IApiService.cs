using System.Collections.Generic;
using System.Threading.Tasks;
using Vai.Shared.Models;
using Vai.Shared.Results;

namespace Vai.Frontend.Core.Services
{
    public interface IApiService
    {
        Task<CommandResult<GetAllProcessesCommandModel>> GetAllProcesses(int page, int pageSize);

        Task<CommandResult<GetAllBacklogItemsCommandModel>> GetAllBacklogItems(int page, int pageSize);
    }
}
