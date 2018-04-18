using Flutterwave.Moneywave.Net.Requests;
using System.Net.Http;
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
            var httpMessage = Request.RequestBuilder.BuildWebRequest(HttpMethod.Post, Endpoints.ValidateAccountNumber, new { account_number = bankAccount.AccountNumber, bank_code = bankAccount.BankCode });

            var response = await Request.Request(httpMessage);
            return response;
        }
        public async Task<MoneywaveResponse<BankValidationResponseData>> ValidateAccountNumber(string accountNumber, string bankCode)
        {
            var httpMessage = Request.RequestBuilder.BuildWebRequest(HttpMethod.Post, Endpoints.ValidateAccountNumber, new { account_number = accountNumber, bank_code = bankCode });

            var response = await Request.Request(httpMessage);
            return response;
        }
    }
}
