using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Helpers;
public static class MentorHelper
{
    public static async Task<Mentor> WithClients(this Mentor mentor, ApplicationContext db)
    {
        mentor.Clients = await db.Client.Where(c => c.MentorId == mentor.MentorId).ToListAsync();
        return mentor;
    }
}
