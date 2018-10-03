using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCSignalRChatSolution.Models
{
    public class User
    {
        public User()
        {
            this.UserId = Guid.NewGuid();
        }

        [Key]
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public ICollection<Connection> Connections { get; set; }
    }
}