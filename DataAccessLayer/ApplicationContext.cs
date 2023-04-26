using System.IO;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class ApplicationContext:DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
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
