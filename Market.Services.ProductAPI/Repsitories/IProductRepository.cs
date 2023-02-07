using Market.Services.ProductAPI.Models.Dtos;

namespace Market.Services.ProductAPI.Repsitories
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetAll();
        Task<ProductDto> GetById(int id);
        Task<ProductDto> CreateUpdate(ProductDto productDto);
        Task<bool> DeleteById(int id);
        
    }
}
