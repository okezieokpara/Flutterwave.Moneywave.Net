using Flutterwave.Moneywave.Net.Reflection;
using System;
using System.Linq;
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
        internal static string RequestQueryBuilder(object input)
        {
            var serializedData = ReflectionUtil.GetAllJsonAttributes(input);
            var resultString = "?";
            var attrData = serializedData.AllKeys.SelectMany(serializedData.GetValues, (s, i) => new { key = s, value = i });
            foreach (var obj in attrData)
            {
                if (resultString == "?")
                {
                    resultString = resultString + $"{obj.key}={obj.value}";
                    continue;
                }

                resultString = resultString + $"&{obj.key}={obj.value}";
            }
            return resultString;
        }
    }
}
