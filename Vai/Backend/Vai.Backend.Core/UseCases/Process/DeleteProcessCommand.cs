using System.Threading.Tasks;

namespace Vai.Backend.Core.UseCases.Process
{
    using Vai.Shared;
    using Vai.Shared.Feagtures.DeleteProcess;

    public class DeleteProcessCommand : IDeleteProcessCommand
    {
        public async Task<CommandResult> Execute(DeleteProcessCommandParams parameters)
        {
            // perform add logic here

            return new CommandResult();
        }
    }
}
