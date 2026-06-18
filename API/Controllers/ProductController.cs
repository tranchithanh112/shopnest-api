using Application.DTOs.Product;
using Application.Service;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;
        public ProductController(ProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<ActionResult<List<ProductResponse>>> GetAll()
        {

            var products = await _productService.GetAllProducts();

            return Ok(products);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductResponse>> Get(int id) 
        { 
            var product = await _productService.GetProductById(id);
            if (product == null) return NotFound();
            return Ok(product);
        }
        [HttpPost]
        public async Task<ActionResult<ProductResponse>> Create(CreateProductRequest product)
        {
            var result = await _productService.CreateProduct(product);
            return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<ProductResponse>> Update(int id, UpdateProductRequest product)
        {
            var result = await _productService.UpdateProduct(id,product);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) 
        {
            await _productService.DeleteProduct(id);
            return NoContent();
        }
        
    }
}
