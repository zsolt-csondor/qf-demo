using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QFDemoAPI.Models;

namespace QFDemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagersController : ControllerBase
    {
        private readonly IManagerRepository managerRepo;

        public ManagersController(IManagerRepository managerRepo)
        {
            this.managerRepo = managerRepo;
        }

        //GET api/managers/with-clients
        [HttpGet]
        [Route("with-clients")]
        public IEnumerable<ManagerClientList> GetList()
        {
            return managerRepo.GetManagersWithClients();
        }

        //GET api/managers/bill
        [HttpGet("{username}")]
        [Route("{username}")]
        public IEnumerable<ClientList> GetClientsOfManager(string username)
        {
            return managerRepo.GetClientsOfManager(username);
        }
    }
}