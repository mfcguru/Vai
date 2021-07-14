using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vai.Shared.Models.User;
using Vai.Shared.Params.User;
using Vai.Shared.Results;

namespace Vai.Shared.Interfaces.User
{
    public interface IRegisterUserCommand : ICommand<RegisterUserCommandParams, RegisterUserCommandModel>
    {
    }
}
