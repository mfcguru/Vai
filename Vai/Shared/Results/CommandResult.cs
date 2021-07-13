using System.Net;

namespace Vai.Shared.Results
{
    public class CommandResult
    {
        public bool Success { get; set; } = true;
        public int StatusCode { get; set; } = (int) HttpStatusCode.OK;
        public string Error { get; set; } = string.Empty;
    }

    public class CommandResult<TData> : CommandResult
    {
        public TData Data { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
