using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace DataAccessLayer.Controllers
{
    public class ClientController:DbContext
    {
        
        [ApiController]
        public class ClientsController : Controller
        {
            private readonly ApplicationContext AppContext;
            public ClientsController(ApplicationContext applicationContext)
            {
                AppContext = applicationContext;
            }

            [HttpGet]
            public async Task<ActionResult<IEnumerable<Client>>> GetClients()
            {
                return await AppContext.Clients.ToListAsync();
            }
            [HttpGet("GetClient/{id}")]
            public async Task<ActionResult<Client>> GetClient(int id)
            {
                var client = await AppContext.Clients.FindAsync(id);
                if (client == null) return NotFound();
                return client;
            }
            [HttpPost("PostClient")] //api/client/PostClient
            public async Task<ActionResult<Client>> PostClient(Client client)
            {
                AppContext.Clients.Add(client);
                await AppContext.SaveChangesAsync();

                return CreatedAtAction(nameof(GetClients), new { id = client.ClientId }, client);
            }
            

            [HttpPut("PutClient/{id}")] // /api/client?id=17  id=17
            public async Task<IActionResult> PutClient([FromQuery] int id, [FromBody] Client client)
            {
                return id == client.ClientId ? (IActionResult)NoContent() : BadRequest();
            }
            [HttpPut("PutMentor/{id}")] // /api/client?id=17  id=17
            public async Task<IActionResult> PutMentor([FromQuery] int id, [FromBody] Mentor mentor)
            {
                return id == mentor.MentorId ? (IActionResult)NoContent() : BadRequest();
            }
            [HttpDelete("DeleteClient/{id}")]
            public async Task<IActionResult> DeleteClient(int id)
            {
                if (AppContext.Clients == null) return NotFound();
                var client = await AppContext.Clients.FindAsync(id);
                if (client == null) return NotFound();
                AppContext.Clients.Remove(client);
                await AppContext.SaveChangesAsync();
                return NoContent();
            }
            [HttpDelete("DeleteMentor/{id}")]
            public async Task<IActionResult> DeleteMentor(int id)
            {
                if (AppContext.Mentors == null) return NotFound();
                var mentor = await AppContext.Mentors.FindAsync(id);
                if (mentor == null) return NotFound();
                AppContext.Mentors.Remove(mentor);
                await AppContext.SaveChangesAsync();
                return NoContent();
            }
        }
    }
}
