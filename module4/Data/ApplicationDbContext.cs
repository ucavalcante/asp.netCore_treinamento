using Microsoft.EntityFrameworkCore;
using module4.Domain;

namespace module4.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Prod");
            modelBuilder.Entity<Product>().Property(p => p.Name).HasMaxLength(100);
            modelBuilder.Entity<Category>().ToTable("Cat");
            modelBuilder.Entity<Category>().Property(p => p.Name).HasMaxLength(50);
        }
    }
}