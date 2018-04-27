using System;
using System.Net.Http;
using System.Threading.Tasks;
using Flutterwave.Moneywave.Net.Requests;

namespace Flutterwave.Moneywave.Net.FundWalllets
{
    public abstract class FundWalletBase<T> : IFundWallet<T> where T : IFundWalletResponseData
    {
        public FundWalletBase(MoneyWavGateWayConfig config)
        {
            Config = config;
            MoneyWaveRequest = new MoneyWaveRequest<MoneywaveResponse<T>, T>(config);
        }

        internal MoneyWaveRequest<MoneywaveResponse<T>, T> MoneyWaveRequest { get; }
        protected internal MoneyWavGateWayConfig Config { get; set; }

        public virtual async Task<MoneywaveResponse<T>> Pay(FundWalletParamsBase fundWalletParams)
        {
            fundWalletParams.ApiKey = Config.ApiKey;
            var httpMessage = MoneyWaveRequest.RequestBuilder.BuildWebRequest(HttpMethod.Post, Endpoints.Transfer, fundWalletParams);
            var response = await MoneyWaveRequest.Request(httpMessage);
            return response;
        }
    }
}
