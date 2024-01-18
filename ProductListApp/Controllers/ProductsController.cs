using ProductListApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductListApp.Controllers
{
    public class ProductsController : ApiController {
        Product[] products = new Product[] {
            new Product { Id = 1, Name = "Bobi", Category = "Programmer", Price = 85.4M},
            new Product { Id = 2, Name = "Tivkiot Don", Category = "Books", Price = 15.5M},
            new Product { Id = 1, Name = "Canyon", Category = "Bicycle", Price = 2424.8M}
        };
        public IEnumerable<Product> GetProducts() {
            return products;
        }

        public IHttpActionResult GetProduct(int id) {
            var product = products.FirstOrDefault(p => p.Id == id);
            if(product == null) {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
