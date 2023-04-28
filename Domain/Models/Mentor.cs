using System.ComponentModel.DataAnnotations;

namespace Domain.Models;
public class Mentor
{
    [Key]
    public int MentorId { get; set; }
    public string? NameMentor { get; set; }
    public string? SurnameMentor { get; set; }
    public string? Post { get; set; }

    public List<Client> Clients { get; set; }
}