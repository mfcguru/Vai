using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vai.Shared.Models.Process
{
    public class AddProcessCommandModel
    {
        public string Client { get; set; }
        public string Robot { get; set; }
        public string TaskDescription { get; set; }
        public string StartTime { get; set; }
        public string ElapsedTime { get; set; }
        public string Status { get; set; }
        public string Efficiency { get; set; }
        public string Priority { get; set; }
    }
}
