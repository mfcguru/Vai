using System.Threading.Tasks;

namespace Vai.Backend.Core.UseCases.Process
{
    using Vai.Shared;
    using Vai.Shared.Feagtures.GetProcess;

    public class GetProcessCommand : IGetProcessCommand
    {
        public async Task<CommandResult<GetProcessCommandModel>> Execute(int id)
        {
            // perform logic here

            return new CommandResult<GetProcessCommandModel> { Data = null /* replace null with actual data */ };
        }
    }
}
