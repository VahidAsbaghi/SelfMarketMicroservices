using Market.Services.ProductAPI.Models.Dtos;
using Market.Services.ProductAPI.Repsitories;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace Market.Services.ProductAPI.Controllers
{
    [Route("api/products")]
    public class ProductAPIController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        private ResponseDto responseDto;

        public ProductAPIController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
            responseDto=new ResponseDto();
        }

        [HttpGet]
        public async Task<object> Get()
        {
            try
            {
                var products = await productRepository.GetAll();
                responseDto.Result = products;
            }
            catch (Exception ex)
            {
                responseDto.IsSuccess = false;
                responseDto.ErrorMessages = new List<string>() { ex.ToString() };
            }

            return responseDto;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<object> GetById(int id)
        {
            try
            {
                var product = await productRepository.GetById(id);
                responseDto.Result = product;
            }
            catch (Exception ex)
            {
                responseDto.IsSuccess = false;
                responseDto.ErrorMessages = new List<string>() { ex.ToString() };
            }

            return responseDto;
        }

        [HttpPost]
        public async Task<object> Post([FromBody]ProductDto productDto)
        {
            try
            {
                var product = await productRepository.CreateUpdate(productDto);
                responseDto.Result = product;
            }
            catch (Exception ex)
            {
                responseDto.IsSuccess = false;
                responseDto.ErrorMessages = new List<string>() { ex.ToString() };
            }

            return responseDto;
        }

        [HttpPut]
        public async Task<object> Put([FromBody]ProductDto productDto)
        {
            try
            {
                var product = await productRepository.CreateUpdate(productDto);
                responseDto.Result = product;
            }
            catch (Exception ex)
            {
                responseDto.IsSuccess = false;
                responseDto.ErrorMessages = new List<string>() { ex.ToString() };
            }

            return responseDto;
        }

        [HttpDelete]
        public async Task<object> Delete(int id)
        {
            try
            {
                var isSuccess = await productRepository.DeleteById(id);
                responseDto.Result = isSuccess;
            }
            catch (Exception ex)
            {
                responseDto.IsSuccess = false;
                responseDto.ErrorMessages = new List<string>() { ex.ToString() };
            }

            return responseDto;
        }
    }
}
