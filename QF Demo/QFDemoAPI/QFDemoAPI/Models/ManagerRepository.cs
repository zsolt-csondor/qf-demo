using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QFDemoAPI.Models
{
    public class ManagerRepository : IManagerRepository
    {
        private readonly QFDemoDbContext context;

        public ManagerRepository(QFDemoDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<ClientList> GetClientsOfManager(string username)
        {
            return context.ClientList.FromSql($"GetClientListForManager {username}").ToList();
        }

        public IEnumerable<ManagerClientList> GetManagersWithClients()
        {
            return context.ManagersWithClients.FromSql("GetAllManagersWithClients").ToList();
        }

        //public void CreateManager()
        //{
        //    throw new NotImplementedException();
        //}

        //public void DeleteManager()
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<Manager> GetAllManagers()
        //{
        //    throw new NotImplementedException();
        //}

        //public Manager GetManager(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public void UpdateManager(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
