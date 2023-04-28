using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class Client
{
    [Key]
    public int ClientId { get; set; }
    public string? NameClient { get; set; }
    public string? Login { get; set; }
    public string? Password { get; set; }
    public int MentorId { get; set; }

    public Mentor? Mentor { get; set; }
}