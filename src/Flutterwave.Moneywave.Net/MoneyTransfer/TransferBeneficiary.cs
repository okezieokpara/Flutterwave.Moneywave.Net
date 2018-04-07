using Newtonsoft.Json;
using System;

namespace Flutterwave.Moneywave.Net.MoneyTransfer
{
    public class TransferBeneficiary
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("accountName")]
        public string AccountName { get; set; }
        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("bankCode")]
        public string BankCode { get; set; }

        [JsonProperty("bankName")]
        public string BankName { get; set; }

        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("deletedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime DeletedAt { get; set; }
        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("userId")]
        public long UserId { get; set; }
    }
}
