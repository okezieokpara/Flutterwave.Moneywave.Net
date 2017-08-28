using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flutterwave.Moneywave.Net.MoneyTransfer
{
    public class MoneyTransfer
    {
        public MoneywaveResponse CardToAccountTransfer(TransferRequest trasnferRequest)
        {
            return new MoneywaveResponse();
        }

        public MoneywaveResponse CardToWallet(TransferRequest trasnferRequest)
        {
            return new MoneywaveResponse();

        }

        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="transferRequest"></param>
        /// <returns></returns>
        /// <remarks>end point "/disburse"</remarks>
        public MoneywaveResponse WalletToAccount(WalletTransferRequest transferRequest)
        {
            return new MoneywaveResponse();
        }

        public MoneywaveResponse GetTotalCharge(decimal amount, decimal fee)
        {
            return new MoneywaveResponse();
        }
    }
}
