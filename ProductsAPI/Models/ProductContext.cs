using Microsoft.EntityFrameworkCore;

namespace ProductsAPI.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }

        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Telephone Samsung s10 plus",
                    Price = 200.00,
                    Quantity = 200
                },
                new Product
                { 
                    Id= 2,
                    Name = "Laptop HP",
                    Price = 200.00,
                    Quantity = 200
                },
                new Product
                {
                    Id = 3,
                    Name = "Ryzen 7 5700X",
                    Price = 500.00,
                    Quantity = 200
                }
            );
        }
    }
}
