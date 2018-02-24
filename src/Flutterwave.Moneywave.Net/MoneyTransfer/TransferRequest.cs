using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Flutterwave.Moneywave.Net.MoneyTransfer
{
    /// <summary>
    /// Builds a request for money transfer
    /// </summary>
    public class TransferRequest
    {
        /// <summary>
        /// First name of person
        /// </summary>
        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the person
        /// </summary>
        [JsonProperty("lastname")]
        public string LastName { get; set; }
        /// <summary>
        /// Phone number of the person
        /// </summary>
        [JsonProperty("phonenumber")]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Email address of the person
        /// </summary>
        [JsonProperty("email")]
        public string EmailAddress { get; set; }
        /// <summary>
        /// the email of the sender
        /// </summary>
        [JsonProperty("recipient")]
        public string Recipient { get; set; }
        /// <summary>
        /// (optional) recipient type: account, wallet, beneficiary, bulk-account
        /// </summary>
        [JsonProperty("recipient_id")]
        public long RecipientId { get; set; }
        /// <summary>
        /// (optional) recipient type id
        /// </summary>
        [JsonProperty("recipient_bank")]
        public string RecipientBank { get; set; }
        /// <summary>
        /// bank to send money to
        /// </summary>
        [JsonProperty("recipient_account_number")]
        public string RecipientAccountNumber { get; set; }

        /// <summary>
        /// account number of the recipient in the recipient bank
        /// </summary>
        [JsonProperty("recipients")]
        public string[] Recipients { get; set; }
        /// <summary>
        /// the url to redirect to after transaction has been successfully validated
        /// </summary>
        [JsonProperty("redirecturl")]
        public string RedirectUrl { get; set; }
        /// <summary>
        /// this is the amount to send to the beneficiary
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { get; set; }
        /// <summary>
        /// your merchant apiKey displayed to you after registering as a merchant.
        /// </summary>
        [JsonProperty("apiKey")]
        public string ApiKey { get; set; }
        /// <summary>
        /// the amount the merchant wants to add as his commission
        /// </summary>
        [JsonProperty("fee")]
        public decimal Fee { get; set; }
        /// <summary>
        /// this can either be web or mobile or depending on request medium
        /// </summary>
        [JsonProperty("medium")]
        public string Medium { get; set; }

        /// <summary>
        /// (optional) - this is the currency in which card will be charged
        /// </summary>
        [JsonProperty("chargeCurrency")]
        public string ChargeCurrency { get; set; }

        /// <summary>
        /// (optional) - this is the currency in which account will be credited
        /// </summary>
        [JsonProperty("disburseCurrency")]
        public string DisburseCurrency { get; set; }

        /// <summary>
        /// (optional) - charge method : card, account, token or tokenized_card
        /// </summary>
        [JsonProperty("charge_with")]
        public string ChargeWith { get; set; }

        /// <summary>
        /// (optional) - card last 4 digits, required in charge with token
        /// </summary>
        [JsonProperty("card_last4")]
        public string CardLast4 { get; set; }
        /// <summary>
        /// (optional) - card token, required in charge with tokenized card
        /// </summary>
        [JsonProperty("card_token")]
        public string CardToken { get; set; }

        /// <summary>
        /// (optional)- charge source, required in charge with account
        /// </summary>
        [JsonProperty("sender_account_number")]
        public string SenderAccountNumber { get; set; }

        /// <summary>
        /// (optional) - charge source bank, required in charge with account
        /// </summary>
        [JsonProperty("sender_bank")]
        public string SenderBank { get; set; }

        /// <summary>
        /// (optional)- Account Security PIN required for account charge
        /// </summary>
        [JsonProperty("passcode")]
        public string PassCode { get; set; }

        /// <summary>
        /// (optional) - card ID required when charging with token
        /// </summary>
        [JsonProperty("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// (optional) - sheduled / recurring transfer cycle
        /// </summary>
        [JsonProperty("cycle")]
        public string Cycle { get; set; }

        /// <summary>
        /// (optional) - sheduled / recurring start date
        /// </summary>
        [JsonProperty("startDate")]
        public string StartDate { get; set; }
        /// <summary>
        /// (optional)- sheduled / recurring end date
        /// </summary>
        [JsonProperty("endDate")]
        public string EndDate { get; set; }

    }
}
