

using Newtonsoft.Json;

namespace Flutterwave.Moneywave.Net.MoneyTransfer
{
    public class CardTransferResponseData : MoneyTransferResponseData
    {
        [JsonProperty("authurl")]
        public string Authurl { get; set; }

        [JsonProperty("chargeMethod")]
        public string ChargeMethod { get; set; }

        [JsonProperty("pendingValidation")]
        public bool PendingValidation { get; set; }
        [JsonProperty("responsehtml")]
        public string Responsehtml { get; set; }
        [JsonProperty("transfer")]
        public Transfer Transfer { get; set; }
    }
}
