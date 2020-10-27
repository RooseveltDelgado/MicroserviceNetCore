using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductApi.Models;
using System.Data;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
       private readonly dbventasContext _context;

        [HttpGet]
        public IEnumerable<Product> GetProduct()
        {
             using (var db = new dbventasContext()){
               return db.Product.ToList();
               //return db.Product.Where(prod => prod.Id == 1).ToList();
             }           
          
        }

        // [HttpPost]
        // public IActionResult PostProduct(Product product)
        // {
        //   using (var db = new dbventasContext())
        //   {
        //      db.Product.Add(product);
        //      db.SaveChanges();
        //   }
        //   return Ok("ok");
        // }
    }
}
