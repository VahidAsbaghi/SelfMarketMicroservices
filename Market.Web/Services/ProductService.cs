using Market.Web.Models.Dtos;
using Market.Web.Services.Contracts;

namespace Market.Web.Services
{
    public class ProductService : BaseService, IProductService
    {
        private IHttpClientFactory httpClient { get; set; }

        public ProductService(IHttpClientFactory httpClient):base(httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<T> CreateProductAsync<T>(ProductDto productDto)
        {
            return await SendAsync<T>(new Models.ApiRequest
            {
                AccessToken = "",
                ApiData = productDto,
                ApiMethod = StaticDetails.ApiType.POST,
                ApiUrl = StaticDetails.ProductAPIBase + "/api/products/"
            });
        }

        public async Task<T> DeleteProductAsync<T>(int id)
        {
            return await SendAsync<T>(new Models.ApiRequest
            {
                AccessToken = "",
                ApiMethod = StaticDetails.ApiType.DELETE,
                ApiUrl = StaticDetails.ProductAPIBase + "/api/products/" + id
            });
        }

        public async Task<T> GetAllProductsAsync<T>()
        {
            return await SendAsync<T>(new Models.ApiRequest
            {
                AccessToken = "",
                ApiMethod = StaticDetails.ApiType.GET,
                ApiUrl = StaticDetails.ProductAPIBase + "/api/products/"
            });
        }

        public async Task<T> GetProductByIdAsync<T>(int id)
        {
            return await SendAsync<T>(new Models.ApiRequest
            {
                AccessToken = "",
                ApiMethod = StaticDetails.ApiType.GET,
                ApiUrl = StaticDetails.ProductAPIBase + "/api/products/"+id
            });
        }

        public async Task<T> UpdateProductAsync<T>(ProductDto productDto)
        {
            return await SendAsync<T>(new Models.ApiRequest
            {
                AccessToken = "",
                ApiData = productDto,
                ApiMethod = StaticDetails.ApiType.PUT,
                ApiUrl = StaticDetails.ProductAPIBase + "/api/products/"
            });
        }
    }
}
