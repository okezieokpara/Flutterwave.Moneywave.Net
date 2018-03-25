
using Flutterwave.Moneywave.Net.Cards;
using Newtonsoft.Json;

namespace Flutterwave.Moneywave.Net.MoneyTransfer
{
    public class CardTransferParams : TransferParamsBase
    {
        public CardTransferParams(string firstName, string lastName, decimal amount, Card card) : base(firstName, lastName, amount)
        {
            SetupCard(card);
        }

        public CardTransferParams(string firstName, string lastName, string phoneNumber, decimal amount, Card card) : base(firstName, lastName, phoneNumber, amount)
        {
            SetupCard(card);

        }

        public CardTransferParams(string firstName, string lastName, string email, string phoneNumber, decimal amount, Card card) : base(firstName, lastName, email, phoneNumber, amount)
        {
            SetupCard(card);

        }
        private void SetupCard(Card card)
        {
            CardNo = card.CardNo;
            Cvv = card.Cvv;
            ExpiryMonth = card.ExpiryMonth;
            ExpiryYear = card.ExpiryYear;
            Pin = card.Pin;
        }

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

    }
}
