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
    public async Task<IActionResult> SubscriptionStyleGet(int id)
    {
        var subscriptionStyle = await _repositories.GetSubscriptionStyleById(id);
        return Ok(subscriptionStyle);
    }

    [HttpGet("{name}")]
    public async Task<IActionResult> SubscriptionStyleGet(string name)
    {
        var subscriptionStyle = await _repositories.GetSubscriptionStyleByName(name);
        return Ok(subscriptionStyle);
    }

    [HttpPost("AddSubscriptionStyle")]
    public async Task<IActionResult> AddSubscriptionStyle(SubscriptionStyle subscriptionStyle)
    {
        var result = await _repositories.AddSubscriptionStyle(subscriptionStyle);
        return Ok(result);
    }

    [HttpPut("UpdateSubscriptionStyle")]
    public async Task<IActionResult> UpdateSubscriptionStyle(SubscriptionStyle subscriptionStyle)
    {
        var result = await _repositories.UpdateSubscriptionStyle(subscriptionStyle);
        return Ok(result);
    }

    [HttpDelete("Delete/{Id}")]
    public async Task<IActionResult> DeleteSubscriptionStyle(int id)
    {
        var result = await _repositories.DeleteSubscriptionStyle(id);
        return Ok(result);
    }
}

