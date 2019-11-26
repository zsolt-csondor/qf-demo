using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace QFDemoAPI.Controllers
{
    public class HomeController : ControllerBase
    {
        public string Index()
        {
            return "QF Demo API Online. Use /api/{resource} for the endpoints.";
        }
    }
}