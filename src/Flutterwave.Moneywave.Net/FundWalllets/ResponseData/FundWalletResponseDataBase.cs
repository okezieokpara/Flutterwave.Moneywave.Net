using Newtonsoft.Json;
using System;


namespace Flutterwave.Moneywave.Net.FundWalllets
{
    public abstract class FundWalletResponseDataBase : IFundWalletResponseData
    {
        [JsonProperty("transfer")]
        public TransferResponseData Transfer { get; set; }
        [JsonProperty("pendingValidation")]
        public bool PendingValidation { get; set; }
        [JsonProperty("chargeMethod")]
        public string ChargeMethod { get; set; }
        [JsonProperty("responsehtml")]
        public string ResponseHtml { get; set; }
        [JsonProperty("authurl")]
        public string AuthUrl { get; set; }
    }
}
