using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Mentor
    {
        [Key]
        public int MentorId { get; set; }
        public string? NameMentor { get; set; }
        public string? SurnameMentor { get; set; }
        public string? Post { get; set; }   

        public List<Client> GetClients(ApplicationContext _context)
        {
            return _context.Client.Where(p => p.Mentor.MentorId == MentorId).ToList();
        }
        public Mentor() { }
        public Mentor(int mentorId, string nameMentor, string surnameMentor, string post)
        {
            MentorId = mentorId;
            NameMentor = nameMentor;
            SurnameMentor = surnameMentor;
            Post = post;
        }
    }
}