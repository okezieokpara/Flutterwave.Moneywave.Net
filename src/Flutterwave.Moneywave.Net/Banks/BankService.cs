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
        private static MoneyWaveRequest<MoneywaveResponse<BanksResponseData>, BanksResponseData> _moneyWaveRequest = new MoneyWaveRequest<MoneywaveResponse<BanksResponseData>, BanksResponseData>(new MoneyWavGateWayConfig());


        /// <summary>
        /// Gets a list of available banks and their codes
        /// </summary>
        /// <param name="country">Optional parameter e.g if you want Kenyan banks use "KE"</param>
        /// <returns></returns>
        public static async Task<ICollection<Bank>> GetBankList(string country = "")
        {
            var requestUrl = string.IsNullOrEmpty(country) ? Endpoints.BanksList : Endpoints.BanksList + HttpUtil.RequestQueryBuilder(new { country });

            var requestMessage = _moneyWaveRequest.RequestBuilder.BuildWebRequest(HttpMethod.Post, requestUrl);//new HttpRequestMessage(HttpMethod.Post, requestUrl);
            var resp = await _moneyWaveRequest.Request(requestMessage);
            var resultBanks = new List<Bank>();
            foreach (var bank in resp.Data)
            {
                resultBanks.Add(new Bank(bank.Key, bank.Value));
            }

            return resultBanks;// Dummy Return;
        }

    }
}
