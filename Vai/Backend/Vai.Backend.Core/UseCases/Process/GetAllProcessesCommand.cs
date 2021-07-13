using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Vai.Backend.Core.Entities;
using Vai.Shared.Interfaces.Process;
using Vai.Shared.Models;
using Vai.Shared.Params;
using Vai.Shared.Results;
using Vai.Backend.Core.Helpers;

namespace Vai.Backend.Core.UseCases.Process
{
    public class GetAllProcessesCommand : IGetAllProcessesCommand
    {
        private readonly VaiContext context;

        public GetAllProcessesCommand(VaiContext context)
        {
            this.context = context;
        }
        public async Task<CommandResult<List<GetAllProcessesCommandModel>>> Execute(GetAllProcessesCommandParams parameters)
        {
            var count = await context.Processes.CountAsync();
            var items = await context.Processes
                .Skip((parameters.Page - 1) * parameters.PageSize)
                .Take(parameters.PageSize)
                .Select(o => new GetAllProcessesCommandModel
                {
                    ProcessId = o.ProcessId,
                    Client = o.Client,
                    Robot = o.Robot,
                    TaskDescription = o.Description,
                    StartTime = o.StartTime.ToLongDateString(),
                    ElapsedTime = (DateTime.Now - o.StartTime).ToString(),
                    Status = o.Status,
                    Efficiency = o.Efficiency,
                    Priority = o.Priority,
                }).ToListAsync();

            var result = new PaginationHelper<GetAllProcessesCommandModel>(items, count, parameters.Page, parameters.PageSize);

            return new CommandResult<List<GetAllProcessesCommandModel>> 
            { 
                Data = result, 
                CurrentPage = result.PageIndex, 
                TotalPages = result.TotalPages 
            };
        }
    }
}
