using Application.Service;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productSerivce;
        public ProductController(ProductService productSerivce)
        {
            _productSerivce = productSerivce;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAll()
        {
            var products = await _productSerivce.GetAllProducts();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Get(int id) 
        { 
            var product = await _productSerivce.GetProductById(id);
            return Ok(product);
        }
        [HttpPost]
        public async Task<ActionResult<Product>> Create(Product product)
        {
            var result = await _productSerivce.CreateProduct(product);
            return Ok(result);
        }
        [HttpPut]
        public async Task<ActionResult<Product>> Update(Product product)
        {
            var result = await _productSerivce.UpdateProduct(product);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) 
        {
            await _productSerivce.DeleteProduct(id);
            return NoContent();
        }
        
    }
}
