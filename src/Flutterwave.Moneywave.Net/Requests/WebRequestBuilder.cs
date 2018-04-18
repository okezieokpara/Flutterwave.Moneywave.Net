using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;

namespace Flutterwave.Moneywave.Net.Requests
{
    internal class WebRequestBuilder : IWebRequestBuilder
    {
        public HttpRequestMessage BuildWebRequest(HttpMethod httpMethod, string url, object payload = null)
        {
            var result = new HttpRequestMessage(httpMethod, url);

            switch (httpMethod)
            {
                // This is some mad stuff from C# 7 called pattern matching
                case HttpMethod m when m == HttpMethod.Get:
                    var queryUrl = HttpUtil.RequestQueryBuilder(payload);
                    result.RequestUri = new Uri(queryUrl);
                    break;
                case HttpMethod m when m == HttpMethod.Post:
                    var jsonPayload = JsonConvert.SerializeObject(payload);
                    if (payload != null)
                    {
                        result.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                    }
                    break;
                default:
                    break;

            }
            result.Method = httpMethod;
            return result;
        }
    }
}
