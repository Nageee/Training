using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace OrderMgmtSystem.Controllers
{
    public class CourierController : ControllerBase
    {
        [HttpGet]
        [Route("Courier/CourierName")]
        public string Get()
        {
            return "Reshmi & Nagee, both are super star.";

        }
    }
    

}
