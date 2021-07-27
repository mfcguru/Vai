using Microsoft.EntityFrameworkCore;
using System;
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

        public async Task<CommandResult<GetAllBacklogItemsCommandModel>> Execute(GetAllBacklogItemsCommandParams parameters)
        {
            var count = await context.Processes.CountAsync();
            var items = await context.Processes
                .Skip((parameters.Page - 1) * parameters.PageSize)
                .Take(parameters.PageSize)
                .Select(o => new GetAllBacklogItemsCommandModel.BacklogAttribute
                {
                    ProcessId = o.ProcessId,
                    Client = o.Client,
                    Robot = o.Robot,
                    TaskDescription = o.Description,
                }).ToListAsync();

            var result = new GetAllBacklogItemsCommandModel
            {
                Backlogs = items,
                Count = count,
                CurrentPage = parameters.Page,
                TotalPages = (int)Math.Ceiling(count / (double)parameters.PageSize)
            };

            return new CommandResult<GetAllBacklogItemsCommandModel> 
            { 
                Data = result, 
            };
        }
    }
}
