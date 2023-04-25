using System.IO;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccessLayer
{
    public class ApplicationContext:DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Mentor> Mentors { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsetting.json");
            var config = builder.Build();
            
            optionsBuilder.UseSqlServer("DefaultConnection");
        }
    }
}
