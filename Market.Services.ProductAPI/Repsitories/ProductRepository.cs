using AutoMapper;
using Market.Services.ProductAPI.DbContexts;
using Market.Services.ProductAPI.Models;
using Market.Services.ProductAPI.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Market.Services.ProductAPI.Repsitories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public ProductRepository(ApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public async Task<ProductDto> CreateUpdate(ProductDto productDto)
        {
            var product = mapper.Map<Product>(productDto);
            if(product.ProductId>0)
            {
                dbContext.products.Update(product);
            }
            else
            {
                dbContext.products.Add(product);
            }

            await dbContext.SaveChangesAsync();

            return mapper.Map<ProductDto>(product);
        }

        public async Task<bool> DeleteById(int id)
        {
            try
            {
                var product = await dbContext.products.FirstOrDefaultAsync(pr => pr.ProductId == id);
                if (product == null)
                    return false;
                dbContext.products.Remove(product);
                await dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public async Task<IEnumerable<ProductDto>> GetAll()
        {
            var products = await dbContext.products.ToListAsync();
            return mapper.Map<IEnumerable<ProductDto>>(products);
        }

        public async Task<ProductDto> GetById(int id)
        {
            var product = await dbContext.products.FirstOrDefaultAsync(pr => pr.ProductId == id);
            return mapper.Map<ProductDto>(product);
        }
    }
}
