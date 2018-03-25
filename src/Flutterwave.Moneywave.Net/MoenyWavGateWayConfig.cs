using Flutterwave.Moneywave.Net.Requests;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Flutterwave.Moneywave.Net
{
    public class MoneyWavGateWayConfig
    {
        private MerchantToken _merchantToken;

        public MoneyWavGateWayConfig(bool isLive = false)
        {
            IsLive = isLive;
            ApiVersion = "v1";
        }
     
        public MoneyWavGateWayConfig(string apiKey, string apiSecret, bool isLive)
        {
            IsLive = isLive;
            ApiKey = apiKey;
            SecretKey = apiSecret;
        }

        public bool IsLive { get; set; }
        /// <summary>
        /// The API Key given to your account
        /// </summary>
        public string ApiKey { get; set; }
        public string SecretKey { get; set; }
        /// <summary>
        /// The current api version to use
        /// Defaut is v1
        /// </summary>
        public string ApiVersion { get; }

        public MerchantToken MerchantToken
        {
            get => _merchantToken;
            set => _merchantToken = value;
        }
        /// <summary>
        /// Request a new merhcant token
        /// </summary>
        /// <returns>A new merchant token. Note: expires in 24 hours</returns>
        public async Task<MerchantToken> RequestToken()
        {
            var client = HttpUtil.CreateClient(IsLive);
            var payload = new { apiKey = ApiKey, secret = SecretKey };
            var response = await client.PostAsync(Endpoints.AccessToken,
                new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json"));
            MerchantToken result = null;
            if (response.IsSuccessStatusCode)
            {
                // Set this only when succeeded
                result = JsonConvert.DeserializeObject<MerchantToken>(await response.Content.ReadAsStringAsync());

            }
            _merchantToken = result; // This could be null
            return result;
        }

    }

}
