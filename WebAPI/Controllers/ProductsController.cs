using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]   //ATTIRIBUTE:bir class ile ilgili bilgi verme imzalama yönetemidir
    //Controller isimleri çogul yazılır 
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public List<Product> Get()
        {
            return new List<Product>
            {
                new Product { ProductId = 1,  ProductName = "Elma" },
                new Product { ProductId = 2, ProductName = "Armut" }
            };
           
        }

    }
}
