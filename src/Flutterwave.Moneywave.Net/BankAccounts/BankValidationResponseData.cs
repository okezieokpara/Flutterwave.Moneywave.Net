using Flutterwave.Moneywave.Net.Requests;
using Newtonsoft.Json;

namespace Flutterwave.Moneywave.Net.BankAccounts
{
    public class BankValidationResponseData : IMoneywaveResponseData
    {
        [JsonProperty("account_name")]
        public string AccountName { get; set; }
    }
}
