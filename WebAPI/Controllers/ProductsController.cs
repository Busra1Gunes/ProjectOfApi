using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]   //ATTIRIBUTE:bir class ile ilgili bilgi verme imzalama yönetemidir
    //Controller isimleri çogul yazılır 
    public class ProductsController : ControllerBase
    {    //ismlenirmede _ kullanma naming convention
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            //Loosely coupled //Gevşek bağımlılık (bir bağımlılığı var ama soyut class'a)
            //IoC Container--Inversion of Control 
            _productService = productService;
        }
        [HttpGet]
        public List<Product> Get()
        { 
           
            var result=_productService.GetAll();
            return result.Data;
           
        }

    }
}
