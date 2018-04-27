using Newtonsoft.Json;

namespace Flutterwave.Moneywave.Net.FundWalllets
{
    public class AccountFundWalletParams : FundWalletParamsBase
    {
        public AccountFundWalletParams(string firstName, string lastName, string phoneNumber, string email, decimal amount, string medium) : base(firstName, lastName, phoneNumber, email, amount, medium)
        {
            ChargeWith = "account";
        }
        [JsonProperty("charge_with")]
        public string ChargeWith { get; set; }
        [JsonProperty("sender_account_number")]
        public string SenderAccountNumber { get; set; }
        [JsonProperty("sender_bank")]
        public string SenderBank { get; set; }
    }
}
