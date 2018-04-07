using Newtonsoft.Json;

namespace Flutterwave.Moneywave.Net.MoneyTransfer
{
    public abstract class TransferParamsBase : IMoneyTransferParams
    {

        public TransferParamsBase(decimal amount)
        {
            Amount = amount;
        }
        [JsonProperty("amount")]
        public decimal Amount { get; set; }
    }
}
