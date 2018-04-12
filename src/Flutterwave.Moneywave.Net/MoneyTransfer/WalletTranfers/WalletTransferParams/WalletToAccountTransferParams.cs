using Flutterwave.Moneywave.Net.BankAccounts;
using Newtonsoft.Json;
using System;
namespace Flutterwave.Moneywave.Net.MoneyTransfer
{
    public class WalletToAccountTransferParams : WalletTransferParamsBase
    {
        public WalletToAccountTransferParams(string bankCode, string accountNumber, string senderName, decimal amount, string @lock, string currency = "NGN") : base(amount, @lock, currency)
        {
            Bankcode = bankCode;
            AccountNumber = accountNumber;
            SenderName = senderName;
            Ref = Guid.NewGuid().ToString("N");
        }
        public WalletToAccountTransferParams(BankAccount account, string senderName, decimal amount, string @lock, string currency = "NGN") : base(amount, @lock, currency)
        {
            Bankcode = account.BankCode;
            AccountNumber = account.AccountNumber;
            SenderName = senderName;
            Ref = Guid.NewGuid().ToString("N");
        }
        [JsonProperty("bankcode")]
        public string Bankcode { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("senderName")]
        public string SenderName { get; set; }

        [JsonProperty("narration")]
        public string Narration { get; set; }

        [JsonProperty("ref")]
        public string Ref { get; set; }
    }
}
