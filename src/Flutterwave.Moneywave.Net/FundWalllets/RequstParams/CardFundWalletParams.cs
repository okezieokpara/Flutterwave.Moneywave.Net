using System;
using Flutterwave.Moneywave.Net.Cards;
using Newtonsoft.Json;

namespace Flutterwave.Moneywave.Net.FundWalllets
{
    public class CardFundWalletParams : FundWalletParamsBase
    {
        public CardFundWalletParams(string firstName, string lastName, string phoneNumber, string email, decimal amount, string medium, Card card) : base(firstName, lastName, phoneNumber, email, amount, medium)
        {

            Recipient = "wallet";
            if (card == null)
                throw new ArgumentException("The card paramater must not be null", paramName: nameof(card));
            CardNo = card.CardNo;
            Cvv = card.Cvv;
            Pin = card.Pin;
            ExpiryYear = card.ExpiryYear;
            ExpiryMonth = card.ExpiryMonth;
        }
        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("recipient_id")]
        public string RecipientId { get; set; }

        // Card information
        [JsonProperty("card_no")]
        public string CardNo { get; set; }
        [JsonProperty("cvv")]
        public string Cvv { get; set; }
        [JsonProperty("pin")]
        public string Pin { get; set; }

        [JsonProperty("expiry_year")]
        public string ExpiryYear { get; set; }
        [JsonProperty("expiry_month")]
        public string ExpiryMonth { get; set; }
    }
}
