using System;
using System.Threading.Tasks;
using Vai.Backend.Core.Entities;
using Vai.Shared.Interfaces.Process;
using Vai.Shared.Params;
using Vai.Shared.Results;

namespace Vai.Backend.Core.UseCases.Process
{
    public class AddProcessCommand : IAddProcessCommand
    {
        private readonly VaiContext context;

        public AddProcessCommand(VaiContext context)
        {
            this.context = context;
        }

        public async Task<CommandResult> Execute(AddProcessCommandParams parameters)
        {
            var entity = new Entities.Process
            {
                Client = parameters.Client,
                Robot = parameters.Robot,
                Description = parameters.TaskDescription,
                StartTime = DateTime.Now,
                Efficiency = parameters.Efficiency,
                Status = parameters.Status,
                Priority = parameters.Priority
            };

            await context.Processes.AddAsync(entity);

            await context.SaveChangesAsync();

            return new CommandResult();
        }
    }
}
