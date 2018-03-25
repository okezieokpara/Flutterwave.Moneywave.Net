using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Flutterwave.Moneywave.Net.Requests
{
    internal static class HttpUtil
    {
        internal static Uri GetBaseUri(bool isLive)
        {
            var result = isLive ? new Uri(FlutterwaveMoneyWaveConstants.LiveUrl) : new Uri(FlutterwaveMoneyWaveConstants.DemoUrl);
            return result;
        }

        internal static HttpClient CreateClient(bool isLive)
        {
            var uri = GetBaseUri(isLive);
            var client = new HttpClient() { BaseAddress = uri };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }
    }
}
