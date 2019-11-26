using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QFDemoAPI.Models
{
    public class QFDemoDbContext : DbContext
    {
        public QFDemoDbContext(DbContextOptions<QFDemoDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        //public DbSet<Manager> Managers { get; set; }

        //public DbSet<Client> Clients { get; set; }

        public DbSet<ManagerClientList> ManagersWithClients { get; set; } //TODO: rename this to ManagerClientList

        public DbSet<ClientList> ClientList { get; set; }

        public DbSet<ClientManagerList> ClientManagerList { get; set; }
    }
}
