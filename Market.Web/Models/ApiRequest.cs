using static Market.Web.StaticDetails;

namespace Market.Web.Models
{
    public class ApiRequest
    {
        public ApiType ApiMethod { get; set; }=ApiType.GET;
        public string ApiUrl { get; set; }
        public object ApiData { get; set; }
        public string AccessToken { get; set; }
    }
}
