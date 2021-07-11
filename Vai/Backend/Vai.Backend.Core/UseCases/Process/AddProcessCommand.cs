using System.Threading.Tasks;

namespace Vai.Backend.Core.UseCases.Process
{
    using Vai.Backend.Core.Entities;
    using Vai.Shared.Interfaces.Process;
    using Vai.Shared.Params;
    using Vai.Shared.Results;

    public class AddProcessCommand : IAddProcessCommand
    {
        private readonly VaiContext context;

        public AddProcessCommand(VaiContext context)
        {
            this.context = context;
        }

        public async Task<CommandResult> Execute(AddProcessCommandParams parameters)
        {
            // perform add logic here

            return new CommandResult();
        }
    }
}
