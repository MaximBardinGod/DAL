using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Domain.Controllers;

[ApiController]
[Microsoft.AspNetCore.Mvc.Route("api/Domain/SubscriptionStyle")]
public class SubscriptionStyleController : ControllerBase
{
    private readonly string? _dalUrl;
    private readonly HttpClient _client;

    public SubscriptionStyleController(IConfiguration conf)
    {
        _dalUrl = conf.GetValue<string>("DalUrl");
        _client = new HttpClient();
    }

    [HttpGet]
    public async Task<ActionResult<SubscriptionStyle[]>> GetSubscriptionStyles()
    {
        var response = await _client.GetAsync($"{_dalUrl}/api/DAL/SubscriptionStyle/SubscriptionStyleList");
        response.EnsureSuccessStatusCode();
        var result = await response.Content.ReadFromJsonAsync<SubscriptionStyle[]>() ?? Array.Empty<SubscriptionStyle>();
        var content = await response.Content.ReadAsStringAsync();
        //if (string.IsNullOrWhiteSpace(name)) return result;
        //return Array.FindAll(result, p => !string.IsNullOrWhiteSpace(p.Name) && p.Name.Contains(name));
        return JsonSerializer.Deserialize<SubscriptionStyle[]>(content, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });
    }
    /*
    [HttpPost]
    public async Task<ActionResult<Product>> PostProduct(Product product)
    {
        JsonContent content = JsonContent.Create(product);
        using var result = await _client.PostAsync($"{_dalUrl}/api/DAL/Product/AddProduct", content);
        var dalProduct = await result.Content.ReadFromJsonAsync<Product>();
        Console.WriteLine($"{dalProduct?.Name}");

        if (dalProduct == null)
            return BadRequest();
        else
            return dalProduct;
    }

    [HttpGet("ProductId={id}")]
    public async Task<ActionResult<Product>> GetProduct(int id)
    {
        var response = await _client.GetAsync($"{_dalUrl}/api/DAL/Product/GetProduct/id={id}");
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        if (content == null) return NotFound();

        return JsonSerializer.Deserialize<Product>(content, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });
    }*/

}
