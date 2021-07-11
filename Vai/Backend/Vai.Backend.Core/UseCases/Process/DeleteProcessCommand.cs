using System.Threading.Tasks;

namespace Vai.Backend.Core.UseCases.Process
{
    using Vai.Shared.Interfaces.Process;
    using Vai.Shared.Params;
    using Vai.Shared.Results;

    public class DeleteProcessCommand : IDeleteProcessCommand
    {
        public async Task<CommandResult> Execute(DeleteProcessCommandParams parameters)
        {
            // perform add logic here

            return new CommandResult();
        }
    }
}
