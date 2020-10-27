using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CatalogApi.Controllers
{
    [ApiController]
    [Route("api/currencies")]    
    public class CurrenciesController : ControllerBase
    {
       [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
           return new string[] {"soles","Dolar","Euro" };
        }
    }

    
}