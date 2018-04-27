using Newtonsoft.Json;



namespace Flutterwave.Moneywave.Net.FundWalllets
{
    public abstract class FundWalletParamsBase
    {
        public FundWalletParamsBase(string firstName, string lastName, string phoneNumber, string email, decimal amount, string medium)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            Medium = medium;
            Amount = amount;
        }
        [JsonProperty("firstname")]
        public string FirstName { get; set; }
        [JsonProperty("lastname")]
        public string LastName { get; set; }
        [JsonProperty("phonenumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("amount")]
        public decimal Amount { get; set; }
        [JsonProperty("medium")]
        public string Medium { get; set; }

        [JsonProperty("apiKey")]
        public string ApiKey { get; set; }

        [JsonProperty("redirecturl")]
        public string Redirecturl { get; set; }
    }
}
