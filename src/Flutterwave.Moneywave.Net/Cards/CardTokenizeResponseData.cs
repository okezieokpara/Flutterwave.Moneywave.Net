using Flutterwave.Moneywave.Net.Requests;
using Newtonsoft.Json;


namespace Flutterwave.Moneywave.Net.Cards
{
    public class CardTokenizeResponseData: IMoneywaveResponseData
    {
        [JsonProperty("cardToken")]
        public string CardToken { get; set; }
    }
}
