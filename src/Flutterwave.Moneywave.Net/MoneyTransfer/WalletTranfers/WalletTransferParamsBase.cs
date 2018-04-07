using Newtonsoft.Json;
using System;


namespace Flutterwave.Moneywave.Net.MoneyTransfer
{
    public abstract class WalletTransferParamsBase : TransferParamsBase
    {
        public WalletTransferParamsBase(decimal amount, string @lock, string currency = "NGN") : base(amount)
        {
            Amount = amount;
            Lock = @lock;
            Currency = currency;
        }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("lock")]
        public string Lock { get; set; }
    }
}
