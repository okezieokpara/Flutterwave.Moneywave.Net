using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Flutterwave.Moneywave.Net
{
    public class MoneyWaveRequest
    {
        private MerchantToken _merchantToken { get; set; }
        public MoneyWaveRequest(MoenyWavGateWayConfig config)
        {
            Config = config;
        }
        public string RedirectUrl { get; set; }
        public MoenyWavGateWayConfig Config { get; }

        /// <summary>
        /// Access Token to be used for all requests
        /// </summary>
      [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        public MoneywaveResponse Request(MerchantToken token)
        {
            HttpClient client;

            if (Config.IsLive)
            {
                client = new HttpClient() { BaseAddress = new Uri(FlutterwaveMoneyWaveConstants.LiveUrl) };
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }

            return new MoneywaveResponse();
        }

		/// <summary>
		/// A merchant request token to be included in all request.
		/// The token represents you as a merchant and grants you access to every other endpoint
		/// </summary>
		/// <remarks>Please note that the tokens expire after 2hrs</remarks>
		public MerchantToken MerchantToken
		{
			get { return _merchantToken ?? RequestToken().Result; }
		}

		/// <summary>
		/// Request a new merhcant token
		/// </summary>
		/// <returns>A new merchant token. Note: expires in 24 hours</returns>
		public async Task<MerchantToken> RequestToken()
		{

			var client = FlutterwaveMoneywaveUtility.CreateClient(Config.IsLive);
			var payload = new { apiKey = Config.ApiKey, secret = Config.SecretKey };
			var response = await client.PostAsync("/v1/merchant/verify",
				new StringContent(JsonConvert.SerializeObject(payload)));

			var responseData = JsonConvert.DeserializeObject<MerchantToken>(await response.Content.ReadAsStringAsync());
			_merchantToken = responseData;
			return responseData;
		}
	}

}
