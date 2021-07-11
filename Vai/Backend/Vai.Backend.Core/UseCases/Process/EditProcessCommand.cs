using System.Threading.Tasks;

namespace Vai.Backend.Core.UseCases.Process
{
    using Vai.Shared;
    using Vai.Shared.Feagtures.EditProcess;

    public class EditProcessCommand : IEditProcessCommand
    {
        public async Task<CommandResult> Execute(EditProcessCommandParameters parameters)
        {
            // perform add logic here

            return new CommandResult();
        }
    }
}
