using System;

using System.Net.Http;
using System.Net.Http.Headers;

namespace Flutterwave.Moneywave.Net
{
    internal static class FlutterwaveMoneywaveUtility
    {
        public static Uri GetBaseUri(bool isLive)
        {
            var result = isLive ? new Uri(FlutterwaveMoneyWaveConstants.LiveUrl) : new Uri(FlutterwaveMoneyWaveConstants.DemoUrl);
            return result;
        }

        public static HttpClient CreateClient(bool isLive)
        {
            var uri = isLive ? new Uri(FlutterwaveMoneyWaveConstants.LiveUrl) : new Uri(FlutterwaveMoneyWaveConstants.DemoUrl);
            var client = new HttpClient() { BaseAddress = uri };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }
    }
}
