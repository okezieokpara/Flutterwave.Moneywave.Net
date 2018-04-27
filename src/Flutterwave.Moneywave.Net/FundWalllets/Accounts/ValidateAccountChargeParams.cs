using Newtonsoft.Json;


namespace Flutterwave.Moneywave.Net.FundWalllets
{
    public class ValidateAccountChargeParams
    {
        public ValidateAccountChargeParams(string tranxRef, string authType, string authValue)
        {
            TransactionRef = tranxRef;
            AuthType = authType;
            AuthValue = authValue;
        }
        [JsonProperty("transactionRef")]
        public string TransactionRef { get; set; }

        [JsonProperty("authType")]
        public string AuthType { get; set; }

        [JsonProperty("authValue")]
        public string AuthValue { get; set; }
    }
}
