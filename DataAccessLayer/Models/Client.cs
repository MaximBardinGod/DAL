using DataAccessLayer.Models;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class Client
    {

        [Key]
        public int ClientId { get; set; }
        public string? NameClient { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public int MentorId { get; set; }

        public Mentor? Mentor { get; set; }
        
        public Client() { }
        
        public Client(int clientId, string nameClient, string login, string password)
        {
            ClientId = clientId;
            NameClient = nameClient;
            Login = login;
            Password = password;
        }
    }
}