using AutoMapper;
using Market.Services.ProductAPI.Models;
using Market.Services.ProductAPI.Models.Dtos;

namespace Market.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto,Product>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
