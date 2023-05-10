using Domain.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Domain.Controllers;

[ApiController]
[Microsoft.AspNetCore.Mvc.Route("api/Domain/Product")]
public class ProductsController : ControllerBase
{
    private readonly string? _dalUrl;
    private readonly HttpClient _client;

    public ProductsController(IConfiguration conf)
    {
        _dalUrl = conf.GetValue<string>("DalUrl");
        _client = new HttpClient();
    }

    [HttpGet]
    public async Task<ActionResult<Product[]>> GetProducts()
    {
        var response = await _client.GetAsync($"{_dalUrl}/api/DAL/Product/ProductList");
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        if (content == null) return NotFound();
        
        return JsonSerializer.Deserialize<Product[]>(content, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        }) ?? Array.Empty<Product>();
    }
    
    [HttpGet("ProductId={id}")]
    public async Task<ActionResult<Product[]>> GetProduct(int id)
    {
        var response = await _client.GetAsync($"{_dalUrl}/api/DAL/Product/GetProduct/id={id}");
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        if (content == null) return NotFound();

        return JsonSerializer.Deserialize<Product[]>(content, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        }) ?? Array.Empty<Product>();
    }

}
