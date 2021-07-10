using System.Threading.Tasks;

namespace Vai.Backend.Core.UseCases.Process
{
    using Vai.Shared.Interfaces;
    using Vai.Shared.Params;
    using Vai.Shared.Results;

    public class EditProcessCommand : ICommand<EditProcessCommandParameters>
    {
        public async Task<CommandResult> Execute(EditProcessCommandParameters parameters)
        {
            // perform add logic here

            return new CommandResult();
        }
    }
}
