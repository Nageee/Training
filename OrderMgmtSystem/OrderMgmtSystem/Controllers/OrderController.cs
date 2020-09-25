using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrderMgmtSystem.Entities;

namespace OrderMgmtSystem.Controllers
{
    [ApiController]
    public class OrderCOntroller : ControllerBase
    {
        [HttpGet]
        [Route("Name/GetYourName")]
        public string Get([FromQuery] OrderDetails ordertdetials)
        {
            return "Reshmi & Nagee, both are super star."; 
        }
    }
}
