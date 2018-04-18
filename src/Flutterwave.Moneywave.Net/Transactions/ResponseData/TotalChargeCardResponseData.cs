using Flutterwave.Moneywave.Net.Requests;
using Newtonsoft.Json;


namespace Flutterwave.Moneywave.Net.Transactions.ResponseData
{
    public class TotalChargeCardResponseData : IMoneywaveResponseData
    {
        [JsonProperty("amountToSend")]
        public decimal AmountToSend { get; set; }

        [JsonProperty("amountChargeable")]
        public decimal AmountChargeable { get; set; }

        [JsonProperty("merchantCommission")]
        public decimal MerchantCommission { get; set; }
    }
}
