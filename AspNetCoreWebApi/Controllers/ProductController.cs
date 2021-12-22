using Microsoft.AspNetCore.Mvc;
using AspNetCoreWebApi.Services;
using AspNetCoreWebApi.Models;
namespace AspNetCoreWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        ProductService _productService;
        public ProductController(ProductService productService){
            this._productService=productService;
        }

        [HttpGet]
        public ActionResult Get(){
            return Ok(this._productService.GetProducts());
        }

        [HttpPost]
        public ActionResult Post(Product product){
            this._productService.AddProduct(product);
            return Ok();
        }
    }
}