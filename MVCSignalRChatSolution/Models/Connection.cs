using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSignalRChatSolution.Models
{
    public class Connection
    {
        public string ConnectionID { get; set; }
        public string UserAgent { get; set; }
        public bool Connected { get; set; }
    }
}