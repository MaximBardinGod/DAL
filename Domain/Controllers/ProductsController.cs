using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DataAccessLayer.Controllers
{
    [ApiController]
    [Route("api/Product")]
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
            var response = await _client.GetAsync($"{_dalUrl}/api/Product");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            if (content == null) return NotFound();
            return JsonSerializer.Deserialize<Product[]>(content);

            //return new[]
            //{
            //    new Product{ProductId = 1, Name = "Test name", CountFat = 1, CountProtein = 1, CountUgl = 1 },
            //    new Product{ProductId = 2, Name = "Test Ivan", CountFat = 2, CountProtein = 2, CountUgl = 2 }
            //};
        }
    }
}
