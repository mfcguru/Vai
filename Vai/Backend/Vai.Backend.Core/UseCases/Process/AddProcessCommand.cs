using System.Threading.Tasks;

namespace Vai.Backend.Core.UseCases.Process
{
    using Vai.Shared.Interfaces;
    using Vai.Shared.Params;
    using Vai.Shared.Results;

    public class AddProcessCommand : ICommand<AddProcessCommandParameters>
    {
        public async Task<CommandResult> Execute(AddProcessCommandParameters parameters)
        {
            // perform add logic here

            return new CommandResult();
        }
    }
}
