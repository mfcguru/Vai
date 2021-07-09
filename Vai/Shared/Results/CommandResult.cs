
namespace Vai.Shared.Results
{
    public class CommandResult
    {
        public bool Success { get; set; }
        public int StatusCode { get; set; }
        public string Error { get; set; }
    }

    public class CommandResult<TData> : CommandResult
    {
        TData Data { get; set; }
    }
}
