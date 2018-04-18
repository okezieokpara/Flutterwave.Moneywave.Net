using System;
using System.Net.Http;

namespace Flutterwave.Moneywave.Net.Requests
{
    /// <summary>
    /// For lack of a better name
    /// Responsible for making api requests
    /// </summary>
    internal interface IWebRequestBuilder
    {
        /// <summary>
        /// This is responsible for making http requests to be sent to the server
        /// </summary>
        /// <returns></returns>
        HttpRequestMessage BuildWebRequest(HttpMethod httpMethod, string url, object payload = null);
    }
}
