using Newtonsoft.Json;

namespace Flutterwave.Moneywave.Net.MoneyTransfer
{
    public abstract class TransferParamsBase : IMoneyTransferParams
    {
        protected TransferParamsBase(string firstName, string lastName, string email, string phoneNumber, decimal amount)
        {
            Firstname = firstName;
            Lastname = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Amount = amount;
        }
        protected TransferParamsBase(string firstName, string lastName, string phoneNumber, decimal amount)
        {
            Firstname = firstName;
            Lastname = lastName;
            PhoneNumber = phoneNumber;
            Amount = amount;
        }
        protected TransferParamsBase(string firstName, string lastName, decimal amount)
        {
            Firstname = firstName;
            Lastname = lastName;
            Amount = amount;
        }
        [JsonProperty("firstname")]
        public string Firstname { get; set; }
        [JsonProperty("lastname")]
        public string Lastname { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("phonenumber")]
        public string PhoneNumber { get; set; }
        [JsonProperty("amount")]
        public decimal Amount { get; set; }
    }
}
