using System.Threading.Tasks;

namespace Vai.Backend.Core.UseCases.Process
{
    using Vai.Backend.Core.Entities;
    using Vai.Shared.Interfaces;
    using Vai.Shared.Interfaces.Process;
    using Vai.Shared.Params;
    using Vai.Shared.Results;

    public class EditProcessCommand : IEditProcessCommand
    {
        private readonly VaiContext context;

        public EditProcessCommand(VaiContext context)
        {
            this.context = context;
        }
        public async Task<CommandResult> Execute(EditProcessCommandParams parameters)
        {
            var result = await context.Processes.FindAsync(parameters.ProcessId);

            result.Client = parameters.Client;
            result.Robot = parameters.Robot;
            result.Description = parameters.TaskDescription;
            result.Efficiency = parameters.Efficiency;
            result.Status = parameters.Status;
            result.Priority = parameters.Priority;

            return new CommandResult();
        }
    }
}
