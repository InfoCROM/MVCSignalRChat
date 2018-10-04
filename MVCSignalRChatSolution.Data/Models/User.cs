using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCSignalRChatSolution.Data.Models
{
    public class User
    {
        public User()
        {
            this.UserId = Guid.NewGuid();
            //this.Connections = new List<Connection>();
        }

        [Key]
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string ConnectionId { get; set; }
        public string ImageId { get; set; }
        //public ICollection<Connection> Connections { get; set; }
    }
}