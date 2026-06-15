using Microsoft.EntityFrameworkCore;
using MVCProject1.Models;
namespace MVCProject1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<CreateProductViewModel> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=MVCProject1;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Mobiles" },
                new Category() { Id = 2, Name = "Tablets" },
                new Category() { Id = 3, Name = "Laptops" }
                );
            modelBuilder.Entity<CreateProductViewModel>().HasData(
                new CreateProductViewModel() { Id = 1, Name = "Prod1", Description = "This is product 1", Price = 300, Quantity = 100, Rate = 0, CategoryId = 1 },
                new CreateProductViewModel() { Id = 2, Name = "Prod2", Description = "This is product 2", Price = 100, Quantity = 50, Rate = 0, CategoryId = 1 },
                new CreateProductViewModel() { Id = 3, Name = "Prod3", Description = "This is product 3", Price = 200, Quantity = 130, Rate = 0, CategoryId = 3 }
                );
        }
    }
}
