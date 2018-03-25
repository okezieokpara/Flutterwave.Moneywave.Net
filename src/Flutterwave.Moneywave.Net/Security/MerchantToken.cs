using Newtonsoft.Json;

namespace Flutterwave.Moneywave.Net
{
    public class MerchantToken
    {
        public MerchantToken()
        {
            Status = "";
            Token = "";
        }
        public MerchantToken(string status, string token)
        {
            Status = status;
            Token = token;
        }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("config")]
        public object Config { get; set; }
    }
}
