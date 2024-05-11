using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Data;
using WebApi.Interfaces;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Product> products = await _productRepository.GetAllAsync();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _productRepository.GetByIdAsync(id);
            if(result == null)
            {
                return NotFound(id);
            }
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            Product result = await _productRepository.CreateAsync(product);
            return Created($"/api/products/{product.Id}", result);
        }
        [HttpPut]
        public async Task<IActionResult> Update(Product product)
        {
            Product checkProduct = await _productRepository.GetByIdAsync(product.Id);
            if (checkProduct == null)
            {
                return NotFound();
            }
            await _productRepository.UpdateAsync(product);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Product checkProduct = await _productRepository.GetByIdAsync(id);
            if (checkProduct == null)
            {
                return NotFound();
            }
            await _productRepository.RemoveAsync(id);
            return NoContent();
        }
    }
}
