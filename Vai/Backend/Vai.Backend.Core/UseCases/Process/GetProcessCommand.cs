﻿using System.Threading.Tasks;

namespace Vai.Backend.Core.UseCases.Process
{
    using Vai.Shared.Interfaces;
    using Vai.Shared.Models;
    using Vai.Shared.Results;

    public class GetProcessCommand : ICommand<int, GetProcessCommandModel>
    {
        public async Task<CommandResult<GetProcessCommandModel>> Execute(int id)
        {
            // perform logic here

            return new CommandResult<GetProcessCommandModel> { Data = null /* replace null with actual data */ };
        }
    }
}