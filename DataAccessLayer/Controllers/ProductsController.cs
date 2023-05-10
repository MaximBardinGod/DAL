using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Services;

namespace DataAccessLayer.Controllers;

[ApiController]
[Route("api/DAL/Product")]
public class ProductsController : ControllerBase
{
    private readonly ILogger<ProductsController> _logger;
    private readonly IServicesProduct _servicesProduct;

    public ProductsController(ILogger<ProductsController> logger, IServicesProduct servicesProduct)
    {
        _logger = logger;
        _servicesProduct = servicesProduct;
    }

    [HttpGet("ProductList")]
    public async Task<IActionResult> ProductList()
    {
        var product = await _servicesProduct.GetProduct();
        if (product == null) return NotFound();
        return Ok(product);
    }

    [HttpGet("GetProductById/id={id}")]
    public async Task<IActionResult> ProductGet(int id) 
    {
        var product = await _servicesProduct.GetProductById(id);
        return Ok(product);
    }

    [HttpGet("GetProductById/name={name}")]
    public async Task<IActionResult> ProductGet(string name)
    {
        var product = await _servicesProduct.GetProductByName(name);
        return Ok(product);
    }

    [HttpPost("AddProduct")]
    public async Task<IActionResult> AddProduct(Product product)
    {
        var result = await _servicesProduct.AddProduct(product);
        return Ok(result);
    }

    [HttpPut("UpdateProduct")]
    public async Task<IActionResult> UpdateProduct(Product product)
    {
        var result = await _servicesProduct.UpdateProduct(product);
        return Ok(result);
    }

    [HttpDelete("DeleteProduct/{Id}")]
    public async Task<IActionResult> DeleteProduct(int id)
    {
        var result = await _servicesProduct.DeleteProduct(id);
        return Ok(result);
    }
}
