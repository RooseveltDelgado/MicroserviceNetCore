using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ClientApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
             return new string[] {"soles","Dolar","Euro" };
        }
    }
}
