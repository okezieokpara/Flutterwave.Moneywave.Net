using System;
using System.Threading.Tasks;
using Flutterwave.Moneywave.Net.Requests;

namespace Flutterwave.Moneywave.Net.FundWalllets
{
    public class CardFundWallet : FundWalletBase<CardFundWalletResponseData>
    {
        public CardFundWallet(MoneyWavGateWayConfig config) : base(config)
        {
        }
        public override Task<MoneywaveResponse<CardFundWalletResponseData>> Pay(FundWalletParamsBase fundWalletParams)
        {
            if (!(fundWalletParams is CardFundWalletParams))
            {
                throw new ArgumentException($"The {nameof(fundWalletParams)} must be of type {nameof(CardFundWalletParams)}");
            }
            return base.Pay(fundWalletParams);
        }
    }
}
