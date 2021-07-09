using System.Collections.Generic;
using System.Threading.Tasks;
using Vai.Shared.Results;

namespace Vai.Shared.Interfaces
{
    public interface ICommand<TResult>
    {
        Task<CommandResult<TResult>> Execute();
    }

    public interface ICommand<TResult, TParams>
    {
        Task<CommandResult<TResult>> Execute(TParams parameters);
    }

    public interface ICommandList<TResult>
    {
        Task<CommandResult<List<TResult>>> Execute();
    }

    public interface ICommandList<TResult, TParams>
    {
        Task<CommandResult<List<TResult>>> Execute(TParams parameters);
    }
}
