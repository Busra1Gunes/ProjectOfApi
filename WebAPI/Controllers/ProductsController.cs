using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
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
        [HttpGet("GetAll")]
        //IActionResult
        public IActionResult GetAll()
        { 
           
            var result=_productService.GetAll();
            if (result.Success) return Ok(result.Data);
            return BadRequest(result);
           
        }
        [HttpPost]
        public IActionResult ProductAdd([FromForm] ProductDto product)
        {
            var baseUri = new Uri(this.Request.GetEncodedUrl());
            var baseUrl = $"{baseUri.GetLeftPart(UriPartial.Authority)}{this.Request.PathBase}/";
            var result=  _productService.Add(product, baseUrl);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id) 
        {
            var result=_productService.GetById(id);
            if (result.Success) return Ok(result);
            return BadRequest(result);


        }

    }
}
