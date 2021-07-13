using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vai.Shared.Models
{
    public class GetAllBacklogItemsCommandModel
    {
        public int ProcessId { get; set; }
        public string Client { get; set; }
        public string Robot { get; set; }
        public string TaskDescription { get; set; }
        public int TotalPages { get; set; }
    }
}
