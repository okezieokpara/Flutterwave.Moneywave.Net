using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flutterwave.Moneywave.Net.Cards
{
    /// <summary>
    /// Represents a payment card (Debit/Credit)
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Instiates a new card object
        /// </summary>
        /// <param name="cardNo">The card number of the payment card</param>
        /// <param name="expiryMonth">The double digit expiry month of card</param>
        /// <param name="expiryYear">The double digit expiry year of card</param>
        public Card(string cardNo, string expiryMonth, string expiryYear)
        {
            CardNo = cardNo;
            ExpiryMonth = expiryMonth;
            ExpiryYear = expiryYear;
        }
        /// <summary>
        /// Instiates a new card object
        /// </summary>
        /// <param name="cardNo">The card number of the payment card</param>
        /// <param name="expiryMonth">The double digit expiry month of card</param>
        /// <param name="expiryYear">The double digit expiry year of card</param>
        /// <param name="cvv">The three-digit CVV number found at the back of the card</param>
        public Card(string cardNo, string expiryMonth, string expiryYear, string cvv)
        {
            CardNo = cardNo;
            ExpiryMonth = expiryMonth;
            ExpiryYear = expiryYear;
            Cvv = cvv;
        }
        /// <summary>
        /// Instiates a new card object
        /// </summary>
        /// <param name="cardNo">The card number of the payment card</param>
        /// <param name="expiryMonth">The double digit expiry month of card</param>
        /// <param name="expiryYear">The double digit expiry year of card</param>
        /// <param name="cvv">The three-digit CVV number found at the back of the card</param>
        /// <param name="pin">The four-digit pin of the card</param>
        public Card(string cardNo, string expiryMonth, string expiryYear, string cvv, string pin)
        {
            CardNo = cardNo;
            ExpiryMonth = expiryMonth;
            ExpiryYear = expiryYear;
            Cvv = cvv;
            Pin = pin;
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

    }
}
