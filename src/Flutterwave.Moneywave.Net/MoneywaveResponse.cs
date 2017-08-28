using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flutterwave.Moneywave.Net
{
    /// <summary>
    /// The response sent for all moneywave request
    /// </summary>
    public class MoneywaveResponse
    {
        public string ResponseCode { get; set; }
        public string ResponseHtml { get; set; }
       [JsonProperty("status")]
        public string Status { get; set; }
        public string AuthUrl { get; set; }

        /// <summary>
        /// The message sent by money wave
        /// </summary>
       [JsonProperty("message")]
        public string Message { get; set; }
        /// <summary>
        /// The data returned from the api
        /// </summary>
       [JsonProperty("data", IsReference = true)]
        public object Data { get; set; }
    }
}
