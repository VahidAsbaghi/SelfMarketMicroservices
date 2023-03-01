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
                ImageUrl = "https://drive.google.com/file/d/14FaHqkl3tdAzCK7LdnTDOiXTjgPkQuOs/view?usp=share_link",
                Price = 1000
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "P2",
                CategoryName = "TV",
                Description = "An Excellent Product in TV",
                ImageUrl = "https://drive.google.com/file/d/1wGdfFJ9D8FCEBpNSK6N-YBZn7o8OYtDA/view?usp=share_link",
                Price = 3000
            }); 
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "P3",
                CategoryName = "Glossery",
                Description = "An Excellent Product of Vahid's land",
                ImageUrl = "https://drive.google.com/file/d/1mflyDEZJPoHEsGoaDINJExFPZH-GgJlR/view?usp=share_link",
                ImageUrl = "",
                Price = 500
            }); 
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "P4",
                CategoryName = "Glossery",
                Description = "An Excellent Product of Delsa's Hand",
                ImageUrl = "https://drive.google.com/file/d/1tviPDv5KFEk4-c21vy5jak27jOr54rrV/view?usp=share_link",
                ImageUrl = "",
                Price = 1000
            }); 
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "P5",
                CategoryName = "Mobile",
                Description = "An Excellent Product of Apple",
                ImageUrl = "https://drive.google.com/file/d/14ViuJVRMnrSmnJq-ohfcyMO-zJAVJ6eS/view?usp=share_link",
                ImageUrl = "",
                Price = 10000
            }); 
        }
    }
}
