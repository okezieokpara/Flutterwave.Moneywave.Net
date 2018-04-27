using Newtonsoft.Json;
using System;

namespace Flutterwave.Moneywave.Net.MoneyTransfer
{
    public class Transfer
    {
        [JsonProperty("id")]
        public long Id { get; set; }


        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public object Account { get; set; } // Todo find the properties of this object
        [JsonProperty("accountId", NullValueHandling = NullValueHandling.Ignore)]
        public long AccountId { get; set; }

        [JsonProperty("amountToCharge")]
        public decimal AmountToCharge { get; set; }

        [JsonProperty("amountToSend")]
        public decimal AmountToSend { get; set; }

        [JsonProperty("beneficiaryId")]
        public long BeneficiaryId { get; set; }

        [JsonProperty("beneficiary")]
        public TransferBeneficiary Beneficiary { get; set; }

        [JsonProperty("cardId")]
        public long CardId { get; set; }

        [JsonProperty("chargeCurrency")]
        public string ChargeCurrency { get; set; }

        [JsonProperty("chargedFee")]
        public decimal ChargedFee { get; set; }

        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("deletedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime DeletedAt { get; set; }

        [JsonProperty("disburseCurrency")]
        public string DisburseCurrency { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("flutterChargeReference")]
        public string FlutterChargeReference { get; set; }

        [JsonProperty("flutterChargeResponseCode")]
        public string FlutterChargeResponseCode { get; set; }

        [JsonProperty("flutterChargeResponseMessage")]
        public string FlutterChargeResponseMessage { get; set; }

        [JsonProperty("flutterDisburseReference")]
        public string FlutterDisburseReference { get; set; }

        [JsonProperty("flutterDisburseResponseCode")]
        public string FlutterDisburseResponseCode { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }
        [JsonProperty("medium")]
        public string Medium { get; set; }

        [JsonProperty("merchantCommission")]
        public decimal MerchantCommission { get; set; }

        [JsonProperty("merchantId")]
        public long MerchantId { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }
        [JsonProperty("ref")]
        public string Ref { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("source_id")]
        public long SourceId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updatedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("userId")]
        public long UserId { get; set; }
    }
}
