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
        public TokenConfig Config { get; set; }

        public class TokenConfig
        {
            [JsonProperty("daily_limit")]
            public long DailyLimit { get; set; }

            [JsonProperty("maximum_limit")]
            public long MaximumLimit { get; set; }

            [JsonProperty("merchant_fee")]
            public long MerchantFee { get; set; }

            [JsonProperty("minimum_limit")]
            public int MinimumLimit { get; set; }
        }
    }
}
