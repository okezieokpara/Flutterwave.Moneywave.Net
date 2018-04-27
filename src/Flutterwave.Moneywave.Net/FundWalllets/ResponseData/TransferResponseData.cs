using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flutterwave.Moneywave.Net.FundWalllets
{
    public class TransferResponseData
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        [JsonProperty("updatedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("recipientPhone")]
        public string RecipientPhone { get; set; }
        [JsonProperty("isCardValidationSuccessful")]
        public bool IsCardValidationSuccessful { get; set; }
        [JsonProperty("isDeliverySuccessful")]
        public bool IsDeliverySuccessful { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("medium")]
        public string Medium { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("exchangeRate")]
        public string ExchangeRate { get; set; }
        [JsonProperty("amountToSend", NullValueHandling = NullValueHandling.Ignore)]
        public decimal AmountToSend { get; set; }

        [JsonProperty("amountToCharge")]
        public decimal AmountToCharge { get; set; }
        [JsonProperty("disburseCurrency")]
        public string DisburseCurrency { get; set; }
        [JsonProperty("chargeCurrency")]
        public string ChargeCurrency { get; set; }
        [JsonProperty("flutterChargeResponseCode")]
        public string FlutterChargeResponseCode { get; set; }

        [JsonProperty("flutterChargeResponseMessage")]
        public string FlutterChargeResponseMessage { get; set; }
        [JsonProperty("flutterDisburseResponseMessage")]
        public string FlutterDisburseResponseMessage { get; set; }

        [JsonProperty("flutterChargeReference")]
        public string FlutterChargeReference { get; set; }

        [JsonProperty("flutterDisburseReference")]
        public string FlutterDisburseReference { get; set; }

        [JsonProperty("flutterDisburseResponseCode")]
        public string FlutterDisburseResponseCode { get; set; }

        [JsonProperty("merchantCommission", NullValueHandling = NullValueHandling.Ignore)]
        public decimal MerchantCommission { get; set; }
        [JsonProperty("moneywaveCommission", NullValueHandling = NullValueHandling.Ignore)]
        public decimal MoneywaveCommission { get; set; }
        [JsonProperty("netDebitAmount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal NetDebitAmount { get; set; }

        [JsonProperty("chargedFee", NullValueHandling = NullValueHandling.Ignore)]
        public decimal ChargedFee { get; set; }

        [JsonProperty("receiptNumber")]
        public string ReceiptNumber { get; set; }
        [JsonProperty("redirectUrl")]
        public string RedirectUrl { get; set; }
        [JsonProperty("linkingReference")]
        public string LinkingReference { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
        [JsonProperty("source_id")]
        public string SourceId { get; set; }

        [JsonProperty("meta", NullValueHandling = NullValueHandling.Ignore)]
        public object Meta { get; set; }

        [JsonProperty("ref")]
        public string Ref { get; set; }
        [JsonProperty("userId", NullValueHandling = NullValueHandling.Ignore)]
        public long UserId { get; set; }
        [JsonProperty("beneficiaryId")]
        public long BeneficiaryId { get; set; }

        [JsonProperty("cardId", NullValueHandling = NullValueHandling.Ignore)]
        public long CardId { get; set; }

        [JsonProperty("account")]
        public User Account { get; set; }

        [JsonProperty("beneficiary")]
        public User Beneficiary { get; set; }

    }
}
