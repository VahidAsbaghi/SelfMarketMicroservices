using Market.Web.Models;
using Market.Web.Models.Dtos;
using Market.Web.Services.Contracts;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Market.Web.Services
{
    public class BaseService : IBaseService
    {
        public ResponseDto ResponseModel { get; set; }

        private IHttpClientFactory httpClient { get; set; }

        public BaseService(IHttpClientFactory httpClient)
        {
            ResponseModel = new ResponseDto();
            this.httpClient = httpClient;
        }

        public async Task<T> SendAsync<T>(ApiRequest request)
        {
            try
            {
                var client = httpClient.CreateClient();
                HttpRequestMessage requestMessage = new HttpRequestMessage();
                requestMessage.Headers.Add("Accept", "application/json");
                requestMessage.RequestUri = new Uri(request.ApiUrl);
                client.DefaultRequestHeaders.Clear();
                if (request.ApiData != null)
                {
                    requestMessage.Content = new StringContent(JsonConvert.SerializeObject(request.ApiData), System.Text.Encoding.UTF8, "application/json");
                }

                HttpResponseMessage responseMessage = null;
                switch (request.ApiMethod)
                {
                    case StaticDetails.ApiType.POST:
                        requestMessage.Method = HttpMethod.Post;
                        break;
                    case StaticDetails.ApiType.PUT:
                        requestMessage.Method = HttpMethod.Put;
                        break;
                    case StaticDetails.ApiType.DELETE:
                        requestMessage.Method = HttpMethod.Delete;
                        break;
                    default:
                        requestMessage.Method = HttpMethod.Get;
                        break;
                }

                responseMessage = await client.SendAsync(requestMessage);

                string responseContent = await responseMessage.Content.ReadAsStringAsync();
                var responseDto = JsonConvert.DeserializeObject<T>(responseContent);
                return responseDto;
            }
            catch (Exception e)
            {
                var errorResponseDto = new ResponseDto();
                errorResponseDto.IsSuccess = false;
                errorResponseDto.Message = "Error";
                errorResponseDto.ErrorMessages = new List<string> { e.Message };
                var serializedDto = JsonConvert.SerializeObject(errorResponseDto);
                var returnDto = JsonConvert.DeserializeObject<T>(serializedDto);
                return returnDto;
            }

        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
    }
}
