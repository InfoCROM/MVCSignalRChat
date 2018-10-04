using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSignalRChatSolution.Data.Models
{
    public class Image
    {
        public Image()
        {
                
        }

        public Guid ImageId { get; set; }
        public string Name { get; set; }
    }
}
