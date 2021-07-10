using System.Collections.Generic;
using System.Threading.Tasks;
using Vai.Shared.Interfaces;
using Vai.Shared.Models;
using Vai.Shared.Params;
using Vai.Shared.Results;

namespace Vai.Backend.Core.UseCases.Process
{
    public class AddProcessCommand : ICommand<AddProcessCommandParameters>
    {
        public async Task<CommandResult> Execute(AddProcessCommandParameters parameters)
        {
            // perform add logic here

            return new CommandResult();
        }
    }
}
