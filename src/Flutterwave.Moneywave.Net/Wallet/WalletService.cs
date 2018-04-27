using Flutterwave.Moneywave.Net.Requests;
using Flutterwave.Moneywave.Net.Transactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flutterwave.Moneywave.Net.Wallet
{
    public class WalletService
    {
        MoneyWavGateWayConfig Config { get; }
        public WalletService(MoneyWavGateWayConfig config)
        {
            Config = config;
        }
        public void PayWithInternetBanking()
        {
            var requester = new MoneyWaveRequest<MoneywaveResponse<TotalChargeCardResponseData>, TotalChargeCardResponseData>(Config);
        }
        public void CardToWallet()
        {

        }
        public void AccountToWallet()
        {

        }
        public void GetWalletBalance()
        {

        }
        public void CreateSubWallet()
        {

        }
    }
}
