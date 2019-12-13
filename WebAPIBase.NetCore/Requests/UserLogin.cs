using Newtonsoft.Json;

namespace WebAPIBase.API.Requests
{
    public class UserLogin
    {
        [JsonProperty(PropertyName = "username", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        [JsonProperty(PropertyName = "password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }
    }
}