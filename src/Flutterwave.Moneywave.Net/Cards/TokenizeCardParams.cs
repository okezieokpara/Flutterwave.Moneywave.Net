using Newtonsoft.Json;

namespace Flutterwave.Moneywave.Net.Cards
{
    public class TokenizeCardParams
    {
        public TokenizeCardParams(string cardNo, string expiryYear, string expiryMonth, string cvv)
        {
            CardNo = cardNo;
            ExpiryYear = expiryYear;
            ExpiryMonth = expiryMonth;
            Cvv = cvv;
        }

        public TokenizeCardParams(Card card)
        {
            CardNo = card.CardNo;
            ExpiryYear = card.ExpiryYear;
            ExpiryMonth = card.ExpiryMonth;
            Cvv = card.ExpiryMonth;
        }

        [JsonProperty("card_no")]
        public string CardNo { get; set; }

        [JsonProperty("expiry_year")]
        public string ExpiryYear { get; set; }

        [JsonProperty("expiry_month")]
        public string ExpiryMonth { get; set; }

        [JsonProperty("cvv")]
        public string Cvv { get; set; }
    }
}
