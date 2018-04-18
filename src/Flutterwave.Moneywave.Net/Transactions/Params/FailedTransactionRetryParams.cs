using Newtonsoft.Json;

namespace Flutterwave.Moneywave.Net.Transactions
{
    public class FailedTransactionRetryParams
    {
        /// <summary>
        /// Instantiates FailedTransactionRetryParams object
        /// </summary>
        /// <param name="id">id of a successfully charged transfer.</param>
        /// <param name="recipientAccountNumber">disburse destination account number</param>
        /// <param name="recipientBank">disburse destination bank</param>
        public FailedTransactionRetryParams(string id, string recipientAccountNumber, string recipientBank)
        {
            Id = id;
            RecipientAccountNumber = recipientAccountNumber;
            RecipientBank = recipientAccountNumber;
        }

        /// <summary>
        /// id of a successfully charged transfer.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// disburse destination account number
        /// </summary>

        [JsonProperty("recipient_account_number")]
        public string RecipientAccountNumber { get; set; }

        /// <summary>
        /// disburse destination bank
        /// </summary>
        [JsonProperty("recipient_bank")]
        public string RecipientBank { get; set; }
    }
}
