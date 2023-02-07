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


    }
}
