using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QFDemoAPI.Models
{
    public interface IClientRepository
    {
        //Client GetClient(int id);

        //IEnumerable<Client> GetAllClients();

        //void DeleteClient();

        //void CreateClient();

        //void UpdateClient(int id);

        IEnumerable<ClientManagerList> GetClientsWithManagers();
    }
}
