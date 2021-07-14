using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vai.Backend.Core.Entities;
using Vai.Shared.Interfaces.User;
using Vai.Shared.Models.User;
using Vai.Shared.Params.User;
using Vai.Shared.Results;

namespace Vai.Backend.Core.UseCases.User
{
    class RegisterUserCommand : IRegisterUserCommand
    {
        private readonly VaiContext context;

        public RegisterUserCommand(VaiContext context)
        {
            this.context = context;
        }
        public Task<CommandResult<RegisterUserCommandModel>> Execute(RegisterUserCommandParams parameters)
        {
            throw new NotImplementedException();
        }
    }
}
