using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vai.Backend.Core.Entities;
using Vai.Shared.Interfaces.Process;
using Vai.Shared.Models;
using Vai.Shared.Results;

namespace Vai.Backend.Core.UseCases.Process
{
    public class GetProcessCommand : IGetProcessCommand
    {
        private readonly VaiContext context;

        public GetProcessCommand(VaiContext context)
        {
            this.context = context;
        }

        public async Task<CommandResult<GetProcessCommandModel>> Execute(int id)
        {
            var result = await context.Processes.SingleOrDefaultAsync(o => o.ProcessId == id);

            var data = new GetProcessCommandModel
            {
                Client = result.Client,
                Robot = result.Robot,
                TaskDescription = result.Description,
                StartTime = result.StartTime.ToString(),
                ElapsedTime = 
                    (DateTime.Now.Day - result.StartTime.Day).ToString() + " Days - " +
                    (DateTime.Now.Hour - result.StartTime.Hour).ToString() + " Hours - " +
                    (DateTime.Now.Minute - result.StartTime.Minute).ToString() + " Mins",
                Efficiency = result.Efficiency,
                Status = result.Status,
                Priority = result.Priority
            };

            return new CommandResult<GetProcessCommandModel> { Data = data };
        }
    }
}
