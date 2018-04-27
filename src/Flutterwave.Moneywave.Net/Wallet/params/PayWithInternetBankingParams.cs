using Newtonsoft.Json;

namespace Flutterwave.Moneywave.Net.Wallet
{
    public class PayWithInternetBankingParams
    {
        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("phonenumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("recipient_id")]
        public string RecipientId { get; set; }

        [JsonProperty("sender_bank")]
        public string SenderBank { get; set; }

        [JsonProperty("charge_auth")]
        public string ChargeAuth { get; set; }

        [JsonProperty("charge_with")]
        public string ChargeWith { get; set; }

        [JsonProperty("apiKey")]
        public string ApiKey { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("redirecturl")]
        public decimal Redirecturl { get; set; }

        [JsonProperty("medium")]
        public string Medium { get; set; }
    }
}
