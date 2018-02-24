using System;
using System.Collections.Generic;


namespace Flutterwave.Moneywave.Net
{
    public class CardDetails
    {
        public CardDetails(string cardNumber, string nameOnCard, string cvv)
        {
            CardNumber = cardNumber;
            NameOnCard = nameOnCard;
            CVV = cvv;
        }
        /// <summary>
        /// Number on card. Usully 12 digits, or 16 digits for verve card
        /// </summary>
        public string CardNumber { get; set; }
        /// <summary>
        /// The name of the cardholder as it appears on the card
        /// </summary>
        public string NameOnCard { get; set; }
        /// <summary>
        /// The verification number on the back of the card
        /// </summary>
        public string CVV { get; set; }
        /// <summary>
        /// The expiry year of the card
        /// </summary>
        public string ExpiryYear { get; set; }
        /// <summary>
        /// The expiry month of the card
        /// </summary>
        public string ExpiryMonth { get; set; }
        /// <summary>
        /// Optional pin. Required for verve card authorisation
        /// </summary>
        public string Pin { get; set; }
    }
}
