using System;
using System.Net.Http;
using System.Threading.Tasks;
using Flutterwave.Moneywave.Net.Requests;

namespace Flutterwave.Moneywave.Net.FundWalllets
{
    public class AccountFundWallet : FundWalletBase<AccountFundWalletResponseData>
    {
        public AccountFundWallet(MoneyWavGateWayConfig config) : base(config)
        {
        }
        public override Task<MoneywaveResponse<AccountFundWalletResponseData>> Pay(FundWalletParamsBase fundWalletParams)
        {
            if (!(fundWalletParams is AccountFundWalletParams))
            {
                throw new ArgumentException($"The {nameof(fundWalletParams)} must be of type {nameof(AccountFundWalletParams)}");
            }

            return base.Pay(fundWalletParams);
        }
        public async Task<MoneywaveResponse<AccountFundWalletResponseData>> ValidateCharge(ValidateAccountChargeParams validateParams)
        {
            var httpMessage = MoneyWaveRequest.RequestBuilder.BuildWebRequest(HttpMethod.Post, Endpoints.ValidateAcountCharge, validateParams);
            var response = await MoneyWaveRequest.Request(httpMessage);
            return response;
        }
    }
}
