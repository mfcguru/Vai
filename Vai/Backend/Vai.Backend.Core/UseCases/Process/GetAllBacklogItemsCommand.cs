using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vai.Backend.Core.Entities;
using Vai.Shared.Interfaces.Process;
using Vai.Shared.Models;
using Vai.Shared.Params;
using Vai.Shared.Results;

namespace Vai.Backend.Core.UseCases.Process
{
    public class GetAllBacklogItemsCommand : IGetAllBacklogItemsCommand
    {
        private readonly VaiContext context;

        public GetAllBacklogItemsCommand(VaiContext context)
        {
            this.context = context;
        }

        public async Task<CommandResult<List<GetAllBacklogItemsCommandModel>>> Execute(GetAllBacklogItemsCommandParams parameters)
        {
            var count = await context.Processes.CountAsync();
            var totalPages = (count + parameters.PageSize - 1) / parameters.PageSize;

            var result = await context.Processes
                .Select(o => new GetAllBacklogItemsCommandModel
                {
                    ProcessId = o.ProcessId,
                    Client = o.Client,
                    Robot = o.Robot,
                    TaskDescription = o.Description,
                    TotalPages = totalPages
                }).ToListAsync();

            return new CommandResult<List<GetAllBacklogItemsCommandModel>> { Data = result };
        }
    }
}
