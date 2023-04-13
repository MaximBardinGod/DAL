using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Controllers
{
    public class MentorController
    {


        /*[ApiController]
        public class MentorsController : Controller
        {
            private readonly ApplicationContext AppContext;
            public MentorsController(ApplicationContext applicationContext)
            {
                AppContext = applicationContext;
            }

            [HttpGet]
            public async Task<ActionResult<IEnumerable<Mentor>>> GetMentors()
            {
                return await AppContext.Mentors.ToListAsync();
            }

            [HttpGet("GetMentor/{id}")]
            public async Task<ActionResult<Mentor>> GetMentor(int id)
            {
                var mentor = await AppContext.Mentors.FindAsync(id);
                if (mentor == null) return NotFound();
                return mentor;
            }
            [HttpPost("PostMentor")] //api/client/updateMentor
            public async Task<ActionResult<Mentor>> PostMentor(Mentor mentor)
            {
                AppContext.Mentors.Add(mentor);
                await AppContext.SaveChangesAsync();
                return CreatedAtAction(nameof(GetMentors), new { id = mentor.MentorId }, mentor);
            }
        

        }*/
    }
}
