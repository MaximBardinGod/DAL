using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Controllers;

[ApiController]
[Route("api/DAL/SubscriptionStyle")]
public class SubscriptionStyleController : ControllerBase
{
    private readonly ILogger<SubscriptionStyleController> _logger;
    private readonly IRepository _repositories;

    public SubscriptionStyleController(ILogger<SubscriptionStyleController> logger, IRepository repositories)
    {
        _logger = logger;
        _repositories = repositories;
    }

    [HttpGet("SubscriptionStyleList")]
    public async Task<IActionResult> SubscriptionStyleList()
    {
        var subscriptionStyle = await _repositories.GetSubscriptionsStyle();
        if (subscriptionStyle == null) return NotFound();
        return Ok(subscriptionStyle);
    }

    [HttpGet("{id}")]
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

