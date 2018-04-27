using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Flutterwave.Moneywave.Net.Requests
{
    internal abstract class MoneyWaveRequestBase<T1, T2> : IMoneyWaveRequest<T1, T2> where T1 : IMoneywaveResponse<T2> where T2 : IMoneywaveResponseData
    {

        public MoneyWaveRequestBase(MoneyWavGateWayConfig config)
        {
            Config = config ?? throw new ArgumentException("The config object is required");

            HttpClient = HttpUtil.CreateClient(config.IsLive);
            RequestBuilder = new WebRequestBuilder();
        }
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        public MoneyWavGateWayConfig Config { get; }

        public IWebRequestBuilder RequestBuilder { get; set; }

        protected HttpClient HttpClient { get; }

        public virtual async Task<MoneywaveResponse<T2>> Request(HttpRequestMessage requestBody)
        {
            if (Config.MerchantToken == null)
            {
                var token = await Config.RequestToken();

                if (token != null && !string.IsNullOrEmpty(token.Token))
                {
                    HttpClient.DefaultRequestHeaders.Add("Authorization", Config.MerchantToken.Token);
                }
            }
            HttpResponseMessage httpResponse;

            httpResponse = await HttpClient.SendAsync(requestBody);
            var response =
              JsonConvert.DeserializeObject<MoneywaveResponse<T2>>(await httpResponse.Content.ReadAsStringAsync());
            return response;


        }
    }
}
