using Newtonsoft.Json;


namespace Flutterwave.Moneywave.Net.Transactions
{
    public class TotalChargeCardParams
    {
        public TotalChargeCardParams(decimal amount, decimal fee)
        {
            Amount = amount;
            Fee = fee;
        }
        [JsonProperty("amount")]
        public decimal Amount { get; set; }
        [JsonProperty("fee")]
        public decimal Fee { get; set; }
    }
}
