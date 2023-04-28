using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Controllers
{
        [ApiController]
        [Route("api/Client")]
        public class ClientsController : ControllerBase
        {
            private readonly ApplicationContext _context;
            public ClientsController(ApplicationContext context)
            {
                _context = context;
            }

            [HttpGet]
            public async Task<ActionResult<IEnumerable<Client>>> GetClients()
            {
                return await _context.Client.ToListAsync();
            }

            [HttpGet("/{id}")]
            public async Task<ActionResult<Client>> GetClient(int id)
            {
                if (id != 0)
                {
                    var client = await _context.Client.FirstOrDefaultAsync(p => p.ClientId == id);
                    if (client == null) return NotFound();
                    return client;
                }
                else return NotFound();
            }
        
            [HttpPost("PostClient")]
            public async Task<ActionResult<Client>> PostClient([FromBody] Client client)
            {
                if (client != null)
                {
                    _context.Client.Add(client);
                    await _context.SaveChangesAsync();

                    return Ok(client);
                }
                else return BadRequest();
            }
            

            [HttpPut("PutClient/{id}")]
            public async Task<IActionResult> PutClient( [FromBody] Client client)
            {
                if (!_context.Client.Any(p => p.ClientId == client.ClientId)) return NotFound();

                _context.Update(client);
                await _context.SaveChangesAsync();
                return Ok(client);
            }
            
            [HttpDelete("DeleteClient/{id}")]
            public async Task<IActionResult> DeleteClient(int id)
            {
                var _client = _context.Client.FirstOrDefaultAsync(p => p.ClientId == id);
                _context.Client.Remove(await _client);
                
                await _context.SaveChangesAsync();
                return Ok(_client);
            }
        }
    }
