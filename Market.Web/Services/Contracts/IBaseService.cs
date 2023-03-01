using Market.Web.Models;
using Market.Web.Models.Dtos;

namespace Market.Web.Services.Contracts
{
    public interface IBaseService:IDisposable
    {
        ResponseDto ResponseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequest request);
    }
}
