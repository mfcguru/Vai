﻿
namespace Vai.Shared.Interfaces.Process
{
    using Vai.Shared.Models;
    using Vai.Shared.Params;

    public interface IGetAllProcessesCommand : ICommand<GetAllProcessesCommandParams, GetAllProcessesCommandModel>
    {
    }
}
