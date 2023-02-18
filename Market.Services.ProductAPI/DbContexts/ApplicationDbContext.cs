using Market.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Market.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<Product> products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);                                                                         

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "P1",
                CategoryName = "Glossery",
                Description = "An Excellent Product of Wood",
                ImageUrl = "",
                Price = 1000
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "P2",
                CategoryName = "TV",
                Description = "An Excellent Product in TV",
                ImageUrl = "",
                Price = 3000
            }); 
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "P3",
                CategoryName = "Glossery",
                Description = "An Excellent Product of Vahid's land",
                ImageUrl = "",
                Price = 500
            }); 
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "P4",
                CategoryName = "Glossery",
                Description = "An Excellent Product of Delsa's Hand",
                ImageUrl = "",
                Price = 1000
            }); 
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "P5",
                CategoryName = "Mobile",
                Description = "An Excellent Product of Apple",
                ImageUrl = "",
                Price = 10000
            }); 
        }
    }
}
