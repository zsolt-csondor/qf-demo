using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QFDemoAPI.Models
{
    public class ClientRepository : IClientRepository
    {
        private readonly QFDemoDbContext context;

        public ClientRepository(QFDemoDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<ClientManagerList> GetClientsWithManagers()
        {
            return context.ClientManagerList.FromSql("GetAllClientsWithManagers").ToList();
        }

        //public Client GetClient(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<Client> GetAllClients()
        //{
        //    throw new NotImplementedException();

        //}


        //public void DeleteClient()
        //{
        //    throw new NotImplementedException();
        //}

        //public void CreateClient()
        //{
        //    throw new NotImplementedException();
        //}

        //public void UpdateClient(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
