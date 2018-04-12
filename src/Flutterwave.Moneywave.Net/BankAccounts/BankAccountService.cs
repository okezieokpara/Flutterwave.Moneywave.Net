using Flutterwave.Moneywave.Net.Requests;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Flutterwave.Moneywave.Net.BankAccounts
{
    public class BankAccountService
    {
        public BankAccountService(MoneyWavGateWayConfig config)
        {
            Config = config;
            Request = new MoneyWaveRequest<MoneywaveResponse<BankValidationResponseData>, BankValidationResponseData>(config);
        }
        MoneyWavGateWayConfig Config { get; }
        internal MoneyWaveRequest<MoneywaveResponse<BankValidationResponseData>, BankValidationResponseData> Request { get; }

        public async Task<MoneywaveResponse<BankValidationResponseData>> ValidateAccountNumber(BankAccount bankAccount)
        {
            var jsonPayload = JsonConvert.SerializeObject(new { account_number = bankAccount.AccountNumber, bank_code = bankAccount.BankCode });

            var httpMessage = new HttpRequestMessage(HttpMethod.Post, Endpoints.ValidateAccountNumber)
            {
                Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json") // Remember to always add the encoding an content-type here
            };

            var response = await Request.Request(httpMessage);
            return response;

        }
        public async Task<MoneywaveResponse<BankValidationResponseData>> ValidateAccountNumber(string accountNumber, string bankCode)
        {
            var jsonPayload = JsonConvert.SerializeObject(new { account_number = accountNumber, bank_code = bankCode });

            var httpMessage = new HttpRequestMessage(HttpMethod.Post, Endpoints.ValidateAccountNumber)
            {
                Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json") // Remember to always add the encoding an content-type here
            };

            var response = await Request.Request(httpMessage);
            return response;
        }
    }
}
