using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace OrdersApi.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase
    {
      
        [HttpGet]
        public IActionResult  GetOrders()
        {
            var o1 = new Order("ID1",200,"PROD 01");
            var o2 = new Order("ID2",400, "PROD 02");
            return Ok(new List<Order>{o1,o2});
        }
    }

    
}
