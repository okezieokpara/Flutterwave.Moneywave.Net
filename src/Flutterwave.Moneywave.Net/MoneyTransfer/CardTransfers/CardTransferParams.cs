
using Flutterwave.Moneywave.Net.Cards;
using Newtonsoft.Json;

namespace Flutterwave.Moneywave.Net.MoneyTransfer
{
    public class CardTransferParams : TransferParamsBase
    {

        public CardTransferParams(string firstName, string lastName, string email, string phoneNumber, decimal amount, Card card): base(amount)
        {
            SetupCard(card);
            Firstname = firstName;
            Lastname = lastName;
            Email = email;
            PhoneNumber = phoneNumber;

        }
        private void SetupCard(Card card)
        {
            CardNo = card.CardNo;
            Cvv = card.Cvv;
            ExpiryMonth = card.ExpiryMonth;
            ExpiryYear = card.ExpiryYear;
            Pin = card.Pin;
        }

        /// <summary>
        /// the firstname of the sender
        /// </summary>
        [JsonProperty("firstname", Order = -2)]
        public string Firstname { get; set; }
        [JsonProperty("lastname", Order = -1)]
        public string Lastname { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        /// <summary>
        /// Note that the phone number string must begin with a +
        /// </summary>
        [JsonProperty("phonenumber")]
        public string PhoneNumber { get; set; }

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

        [JsonProperty("charge_auth")]
        public string ChargeAuth { get; set; }

        [JsonProperty("apiKey")]
        public string ApiKey { get; set; }

        [JsonProperty("fee")]
        public decimal Fee { get; set; }

        [JsonProperty("medium")]
        public string Medium { get; set; }

        [JsonProperty("redirecturl")]
        public string Redirecturl { get; set; }

        [JsonProperty("narration")]
        public string Narration { get; set; }


    }
}
