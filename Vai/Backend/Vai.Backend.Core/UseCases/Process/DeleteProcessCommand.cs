using System.Threading.Tasks;

namespace Vai.Backend.Core.UseCases.Process
{
    using Vai.Shared.Interfaces;
    using Vai.Shared.Results;

    public class DeleteProcessCommand : ICommand<int>
    {
        public async Task<CommandResult> Execute(int id)
        {
            // perform add logic here

            return new CommandResult();
        }
    }
}
