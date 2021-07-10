﻿using System.Threading.Tasks;

namespace Vai.Backend.Core.UseCases.Process
{
    using Vai.Shared.Interfaces;
    using Vai.Shared.Params;
    using Vai.Shared.Results;

    public class AddProcessCommand : ICommand<AddProcessCommandParams>
    {
        public async Task<CommandResult> Execute(AddProcessCommandParams parameters)
        {
            // perform add logic here

            return new CommandResult();
        }
    }
}
