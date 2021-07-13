using Vai.Shared.Models;
using Vai.Shared.Params;

namespace Vai.Shared.Interfaces.Process
{
    public interface IGetAllBacklogItemsCommand : ICommandList<GetAllBacklogItemsCommandModel, GetAllBacklogItemsCommandParams>
    {
    }
}
