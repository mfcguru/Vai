
namespace Vai.Shared.Models
{
    public class GetAllProcessesCommandModel
    {
        public int ProcessId { get; set; }
        public string Client { get; set; }
        public string Robot { get; set; }
        public string TaskDescription { get; set; }
        public string StartTime { get; set; }
        public string ElapsedTime { get; set; }
        public string Status { get; set; }
        public string Efficiency { get; set; }
        public string Priority { get; set; }
        public int TotalPages { get; set; }
    }
}
