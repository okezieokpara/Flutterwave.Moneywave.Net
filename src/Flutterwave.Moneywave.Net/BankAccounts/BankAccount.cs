using Flutterwave.Moneywave.Net.Banks;
using Newtonsoft.Json;
using System;


namespace Flutterwave.Moneywave.Net.BankAccounts
{
    public class BankAccount
    {
        /// <summary>
        /// Basic initialisation
        /// </summary>
        /// <param name="bankCode">Bank code</param>
        /// <param name="accountNumber">Account number</param>
        public BankAccount(string bankCode, string accountNumber)
        {
            AccountNumber = accountNumber;
            BankCode = bankCode;
        }
        public BankAccount(Bank bank, string accountNumber)
        {
            if(bank == null)
            {
                throw new ArgumentNullException(message: "The bank object must not be null", paramName: nameof(bank));
            }
            if (string.IsNullOrEmpty(accountNumber))
            {
                throw new ArgumentException(message: "The account number field is required", paramName: nameof(accountNumber));
            }
            BankCode = bank.BankCode;
            AccountNumber = accountNumber;
        }

        [JsonProperty("id")]
        public long Id { get; set; }
        /// <summary>
        /// Account number of the bank account
        /// </summary>
        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Bank code
        /// </summary>
        /// 
        [JsonProperty("bankcode")]
        public string BankCode { get; set; }
     
    }
}
