using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Flutterwave.Moneywave.Net
{
    /// <summary>
    /// Idealy, there should be only one instance of this class
    /// </summary>
	internal class MoneyWaveRequest
    {
        private MerchantToken _merchantToken;

        public HttpClient HttpClient { get; }

        public MoneyWaveRequest(MoenyWavGateWayConfig config)
        {
            Config = config;

            HttpClient = new HttpClient()
            {
                BaseAddress = Config.IsLive
                    ? new Uri(FlutterwaveMoneyWaveConstants.LiveUrl)
                    : new Uri(FlutterwaveMoneyWaveConstants.DemoUrl)
            };
            HttpClient.DefaultRequestHeaders.Accept.Clear();
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public string RedirectUrl { get; set; }
        public MoenyWavGateWayConfig Config { get; }

        /// <summary>
        /// Access Token to be used for all requests
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        public async Task<MoneywaveResponse> Request(HttpRequestMessage requestBody)
        {
            if (MerchantToken == null || string.IsNullOrEmpty(MerchantToken.Token))
            {
                _merchantToken = await RequestToken();
            }
            HttpClient.DefaultRequestHeaders.Add("Authorization", MerchantToken.Token);

            var httpResponse = await HttpClient.SendAsync(requestBody);
            MoneywaveResponse response = null;
            if (httpResponse.IsSuccessStatusCode)
            {
                response =
                    JsonConvert.DeserializeObject<MoneywaveResponse>(await httpResponse.Content.ReadAsStringAsync());
            }
            return response;
        }

        /// <summary>
        /// A merchant request token to be included in all request.
        /// The token represents you as a merchant and grants you access to every other endpoint
        /// </summary>
        /// <remarks>Please note that the tokens expire after 2hrs</remarks>

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

            var client = HttpClient;//FlutterwaveMoneywaveUtility.CreateClient(Config.IsLive);
            var payload = new { apiKey = Config.ApiKey, secret = Config.SecretKey };
            var response = await client.PostAsync("/v1/merchant/verify",
                new StringContent(JsonConvert.SerializeObject(payload)));

            var responseData = JsonConvert.DeserializeObject<MerchantToken>(await response.Content.ReadAsStringAsync());
            _merchantToken = responseData;
            return responseData;
        }
    }

}
