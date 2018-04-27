using System;
using Newtonsoft.Json;


namespace Flutterwave.Moneywave.Net
{
    public class User
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long Id { get; set; }
        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }
        [JsonProperty("accountName")]
        public string AccountName { get; set; }
        [JsonProperty("bankCode")]
        public string BankCode { get; set; }
        [JsonProperty("bankName")]
        public string BankName { get; set; }

        [JsonProperty("userId", NullValueHandling = NullValueHandling.Ignore)]
        public long UserId { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("updatedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("deletedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime DeletedAt { get; set; }
    }
}
