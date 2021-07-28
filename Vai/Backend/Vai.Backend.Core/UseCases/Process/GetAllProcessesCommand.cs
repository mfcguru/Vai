using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Vai.Backend.Core.Entities;
using Vai.Shared.Interfaces.Process;
using Vai.Shared.Models;
using Vai.Shared.Params;
using Vai.Shared.Results;

namespace Vai.Backend.Core.UseCases.Process
{
    public class GetAllProcessesCommand : IGetAllProcessesCommand
    {
        private readonly VaiContext context;

        public GetAllProcessesCommand(VaiContext context)
        {
            this.context = context;
        }
        public async Task<CommandResult<GetAllProcessesCommandModel>> Execute(GetAllProcessesCommandParams parameters)
        {
            var count = await context.Processes.CountAsync();
            var items = await context.Processes
                .Skip((parameters.Page - 1) * parameters.PageSize)
                .Take(parameters.PageSize)
                .Select(o => new GetAllProcessesCommandModel.ProcessAttribute
                {
                    ProcessId = o.ProcessId,
                    Client = o.Client,
                    Robot = o.Robot,
                    TaskDescription = o.Description,
                    StartTime = o.StartTime.ToLongDateString(),
                    ElapsedTime =
                        (DateTime.Now.Day - o.StartTime.Day).ToString() + " Days - " +
                        (DateTime.Now.Hour - o.StartTime.Hour).ToString() + " Hours - " +
                        (DateTime.Now.Minute - o.StartTime.Minute).ToString() + " Mins",
                    Status = o.Status,
                    Efficiency = o.Efficiency,
                    Priority = o.Priority,
                }).ToListAsync();

            var result = new GetAllProcessesCommandModel
            {
                Processes = items,
                Count = count,
                CurrentPage = parameters.Page,
                TotalPages = (int)Math.Ceiling(count / (double)parameters.PageSize)
            };

            return new CommandResult<GetAllProcessesCommandModel>
            {
                Data = result
            };
        }
    }
}
