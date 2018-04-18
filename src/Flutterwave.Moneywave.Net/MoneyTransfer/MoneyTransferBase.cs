using Flutterwave.Moneywave.Net.Requests;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Flutterwave.Moneywave.Net.MoneyTransfer
{

    public abstract class MoneyTransferBase<T> : IMoneyTransfer<TransferParamsBase, T> where T : MoneyTransferResponseData
    {
        protected MoneyTransferBase(MoneyWavGateWayConfig config)
        {
            Config = config ?? throw new ArgumentException("The Config object cannot be null");
            MoneyWaveRequest = new MoneyWaveRequest<MoneywaveResponse<T>, T>(config);

        }
        protected internal abstract string PaymentEndpoint { get; set; } // Oga! Mad!

        internal MoneyWaveRequest<MoneywaveResponse<T>, T> MoneyWaveRequest { get; }
        protected MoneyWavGateWayConfig Config { get; }


        public virtual async Task<MoneywaveResponse<T>> TransferAsync(TransferParamsBase moneyTransferParams)
        {
            var httpMessage = MoneyWaveRequest.RequestBuilder.BuildWebRequest(HttpMethod.Post, PaymentEndpoint, moneyTransferParams);
            var response = await MoneyWaveRequest.Request(httpMessage);
            return response;
        }

    }
}
