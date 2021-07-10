using System.Collections.Generic;
using System.Threading.Tasks;

namespace Vai.Shared.Interfaces
{
    using Vai.Shared.Results;

    public interface ICommand<TParams>
    {
        Task<CommandResult> Execute(TParams parameters);
    }

    public interface ICommand<TParams, TModel>
    {
        Task<CommandResult<TModel>> Execute(TParams parameters);
    }

    public interface ICommandEnumerable<TModel>
    {
        Task<CommandResult<List<TModel>>> Execute();
    }

    public interface ICommandList<TModel, TParams>
    {
        Task<CommandResult<List<TModel>>> Execute(TParams parameters);
    }
}
