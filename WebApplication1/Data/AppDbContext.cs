using System.Net.Http.Headers;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> products { get; set; } 
        public DbSet<Category> categories { get; set; }
        
    }
}
