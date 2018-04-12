using Newtonsoft.Json;
using System;


namespace Flutterwave.Moneywave.Net.MoneyTransfer.WalletTranfers.WalletTransferParams
{
    public class WalletToAccountBulkParams: TransferParamsBase
    {
        public WalletToAccountBulkParams(decimal amount): base(amount)
        {

        }

        [JsonProperty("bankcode")]
        public string Bankcode { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("senderName")]
        public string SenderName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ref")]
        public string Ref { get; set; }

        [JsonProperty("lock")]
        public string Lock { get; set; }

        [JsonProperty("instantQueue")]
        public string InstantQueue { get; set; }
    }
}
