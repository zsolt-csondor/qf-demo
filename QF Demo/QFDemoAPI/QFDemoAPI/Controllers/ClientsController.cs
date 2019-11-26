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
    public class ClientsController : ControllerBase
    {
        private readonly IClientRepository clientRepo;

        public ClientsController(IClientRepository clientRepo)
        {
            this.clientRepo = clientRepo;
        }

        //GET api/clients/with-managers
        [HttpGet]
        [Route("with-managers")]
        public IEnumerable<ClientManagerList> GetList()
        {
            return clientRepo.GetClientsWithManagers();
        }
    }
}