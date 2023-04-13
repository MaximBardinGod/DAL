using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Controllers
{
    public class MentorController : DbContext
    {
        [Route("/Mentor")]
        [ApiController]
        public class MentorsController : Controller
        {
            private readonly ApplicationContext _context;
            public MentorsController(ApplicationContext context)
            {
                _context = context;
            }

            [HttpGet]
            public async Task<ActionResult<IEnumerable<Mentor>>> GetMentors()
            {
                return await _context.Mentors.ToListAsync();
            }

            [HttpGet("GetMentor/{id}")]
            public async Task<ActionResult<Mentor>> GetMentor(int id)
            {
                var mentor = await _context.Mentors.FindAsync(id);
                if (mentor == null) return NotFound();
                return mentor;
            }
            
            [HttpPost("PostMentor")] //api/client/updateMentor
            public async Task<ActionResult<Mentor>> PostMentor(Mentor mentor)
            {
                if (mentor == null) return BadRequest();
                _context.Mentors.Add(mentor);
                await _context.SaveChangesAsync();
                return Ok(mentor);
            }
            
            [HttpPut("PutMentor")]
            public async Task<ActionResult<Mentor>> Put(Mentor mentor)
            {
                if (mentor == null) return BadRequest();

                _context.Update(mentor);
                await _context.SaveChangesAsync();
                return Ok(mentor);
            }

            [HttpDelete("DeleteMentor/{Id}")]
            public async Task<ActionResult<Mentor>> Delete(int id)
            {
                var mentor = _context.Mentors.FirstOrDefaultAsync(p => p.MentorId == id);
                if (mentor == null) return NotFound();
                _context.Mentors.Remove(await mentor);
                await _context.SaveChangesAsync();
                return Ok(mentor);
            } 

        }
    }
}
