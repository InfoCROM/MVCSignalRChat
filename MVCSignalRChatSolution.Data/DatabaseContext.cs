using MVCSignalRChatSolution.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSignalRChatSolution.Data
{
    class DatabaseContext : DbContext
    {
        // SI LA CLASE DEL DbContext SE LLAMA IGUAL QUE EL ConnectionString, 
        // NO HACE FALTA PASARLE A LA CLASE BASE EL NOMBRE DEL ConnectionString.
        public DatabaseContext()
            : base("DatabaseContext")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Connection> Connections { get; set; }

    }
}
