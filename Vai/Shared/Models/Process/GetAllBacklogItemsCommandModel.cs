using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vai.Shared.Models
{
    public class GetAllBacklogItemsCommandModel
    {
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
        public int Count { get; set; }
        public List<BacklogAttribute> Backlogs { get; set; }
        public class BacklogAttribute
        {
            public int ProcessId { get; set; }
            public string Client { get; set; }
            public string Robot { get; set; }
            public string TaskDescription { get; set; }
        }
    }
}
