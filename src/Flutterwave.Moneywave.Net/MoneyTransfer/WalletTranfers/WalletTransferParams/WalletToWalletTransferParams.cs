using Newtonsoft.Json;


namespace Flutterwave.Moneywave.Net.MoneyTransfer
{
    public class WalletToWalletTransferParams : WalletTransferParamsBase
    {
        public WalletToWalletTransferParams(string sourceWallet, string recipientWallet, decimal amount, string @lock, string currency = "NGN") : base(amount, @lock, currency)
        {
            SourceWallet = sourceWallet;
            RecipientWallet = recipientWallet;
        }

        /// <summary>
        /// the sender wallet number
        /// </summary>
        [JsonProperty("sourceWallet")]
        public string SourceWallet { get; set; }

        /// <summary>
        /// the destination wallet number
        /// </summary>
        [JsonProperty("recipientWallet")]
        public string RecipientWallet { get; set; }
    }
}
