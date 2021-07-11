using System;
using System.Collections.Generic;

#nullable disable

namespace Vai.Backend.Api.Entities
{
    public partial class Process
    {
        public int ProcessId { get; set; }
        public string Client { get; set; }
        public string Robot { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
    }
}
