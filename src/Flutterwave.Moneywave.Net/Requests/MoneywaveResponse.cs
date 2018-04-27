using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Runtime.Serialization;

namespace Flutterwave.Moneywave.Net.Requests
{
    /// <summary>
    /// The response sent for all moneywave request
    /// </summary>
    public class MoneywaveResponse<T> : IMoneywaveResponse<T> where T : IMoneywaveResponseData
    {
        public string ResponseCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }


        /// <summary>
        /// The message sent by money wave
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
        /// <summary>
        /// The data returned from the api
        /// </summary>
        [JsonProperty("data", IsReference = true)]
        public T Data { get; set; }

        [OnError]
        internal void OnError(StreamingContext streamingContext, ErrorContext error)
        {

#if DEBUG
            error.Handled = false;
#else
            if (error.Error is JsonSerializationException) //This tries to cover up for what I percieve to be a bug in the RavePay API
            {
                Data = default(T);
                error.Handled = true;
                return;
            }
#endif
        }
    }
}
