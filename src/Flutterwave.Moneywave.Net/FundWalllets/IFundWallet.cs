using Flutterwave.Moneywave.Net.FundWalllets;
using Flutterwave.Moneywave.Net.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Flutterwave.Moneywave.Net.FundWalllets
{
    public interface IFundWallet<T> where T : IFundWalletResponseData
    {
        Task<MoneywaveResponse<T>> Pay(FundWalletParamsBase fundWalletParams);
    }
}
