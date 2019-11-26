using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QFDemoAPI.Models
{
    public interface IManagerRepository
    {
        //Manager GetManager(int id);

        //IEnumerable<Manager> GetAllManagers();

        //void DeleteManager();

        //void CreateManager();

        //void UpdateManager(int id);

        IEnumerable<ManagerClientList> GetManagersWithClients(); 

        IEnumerable<ClientList> GetClientsOfManager(string username);
    }
}
