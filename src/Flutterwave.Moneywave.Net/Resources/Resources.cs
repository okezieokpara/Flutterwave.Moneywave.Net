using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flutterwave.Moneywave.Net.Resources
{
    /// <summary>
    /// Useful resources
    /// </summary>
    public class Resources
    {
        /// <summary>
        /// Endpoint to validate the details of the destination bank account.
        /// </summary>
        /// <param name="accountNumber">the account number of the sender</param>
        /// <param name="bankCode">the bank code of the account to resolve</param>
        /// <returns></returns>
        public MoneywaveResponse ValidateAccountNumber(string accountNumber, string bankCode)
        {
            return new MoneywaveResponse();
        }

        public MoneywaveResponse TokenizeCard(CardDetails card)
        {
            return new MoneywaveResponse();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">id of a successfully charged transfer.</param>
        /// <param name="recipientAccountNumber">(optional) disburse destination account number</param>
        /// <param name="recipientBank">(optional) disburse destination bank</param>
        /// <returns></returns>
        /// <remarks> endpoint "transfer/disburse/retry"</remarks>
        public MoneywaveResponse RetryTransaction(string id, string recipientAccountNumber, string recipientBank)
        {
            return new MoneywaveResponse();
        }

        public MoneywaveResponse PreviousTransaction(string transactioId)
        {
            return new MoneywaveResponse();
        }

        public MoneywaveResponse GetWalletBalance()
        {
            return new MoneywaveResponse();
        }
    }
}
