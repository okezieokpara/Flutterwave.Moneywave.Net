using System;


namespace Flutterwave.Moneywave.Net
{
    public class AccountDetails
    {
        /// <summary>
        /// Basic initialisation
        /// </summary>
        /// <param name="bankCode">Bank code</param>
        /// <param name="accountNumber">Account number</param>
        public AccountDetails(string bankCode, string accountNumber)
        {
            AccountNumber = accountNumber;
            BankCode = bankCode;
        }
        /// <summary>
        /// Account number of the bank account
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Bank code
        /// </summary>
        public string BankCode { get; set; }
    }
}
