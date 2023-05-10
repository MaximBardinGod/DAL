using System.IO;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer;

public class ApplicationContext:DbContext
{
    public DbSet<Client> Client { get; set; }
    public DbSet<Mentor> Mentor { get; set; }
    public DbSet<Product> Product { get; set; }
    public DbSet<Subscription> Subscription { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options)
       : base(options)
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new ConfigurationBuilder();
        builder.SetBasePath(Directory.GetCurrentDirectory());
        builder.AddJsonFile("appsettings.json");
        var config = builder.Build();
        string connectionString = config.GetConnectionString("DefaultConnection");

        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Mentor>().Ignore(m => m.Clients);
    }
}
