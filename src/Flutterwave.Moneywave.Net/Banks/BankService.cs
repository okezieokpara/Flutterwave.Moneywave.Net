using Flutterwave.Moneywave.Net.MoneyTransfer;
using Flutterwave.Moneywave.Net.Requests;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Flutterwave.Moneywave.Net.Banks
{
    /// <summary>
    /// Utility for bank services
    /// </summary>
    public static class BankService
    {
        private static MoneyWaveRequest<MoneywaveResponse<MoneyTransferResponseData>, MoneyTransferResponseData> _moneyWaveRequest = new MoneyWaveRequest<MoneywaveResponse<MoneyTransferResponseData>, MoneyTransferResponseData>(new MoneyWavGateWayConfig());
        /// <summary>
        /// Gets a list of available banks and their codes
        /// </summary>
        /// <param name="country">Optional parameter e.g if you want Kenyan banks use "KE"</param>
        /// <returns></returns>
        public static async Task<IEnumerable<Bank>> GetBankList(string country = "")
        {
            var requestUrl = string.IsNullOrEmpty(country) ? Endpoints.BanksList : Endpoints.BanksList + HttpUtil.RequestQueryBuilder(country);


            var requestMessage = new HttpRequestMessage(HttpMethod.Post, requestUrl);


            var resp = await _moneyWaveRequest.Request(requestMessage);
            return new List<Bank>(); // Dummy Return;
        }

    }
}
