using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Controllers
{
    [ApiController]
    [Route("api/Product")]
    public class ProductsController : ControllerBase
    {
        ApplicationContext _context;
        public ProductsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _context.Product.ToListAsync();
        }

        [HttpGet("GetProduct/{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Product.FindAsync(id);
            if (product == null) return NotFound();
            return product;
        }

        [HttpPost("PostProduct")]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            if (product == null) return BadRequest();
            _context.Product.Add(product);
            await _context.SaveChangesAsync();
            return Ok(product);
        }

        [HttpPut("PutProduct")]
        public async Task<ActionResult<Product>> Put(Product product)
        {
            if (product == null) return BadRequest();

            _context.Update(product);
            await _context.SaveChangesAsync();
            return Ok(product);
        }

        [HttpDelete("DeleteProduct/{Id}")]
        public async Task<ActionResult<Product>> Delete(int id)
        {
            var product = _context.Product.FirstOrDefaultAsync(p => p.ProductId == id);
            if (product == null) return NotFound();
            _context.Product.Remove(await product);
            await _context.SaveChangesAsync();
            return Ok(product);
        }

    }
}
