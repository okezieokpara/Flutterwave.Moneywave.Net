using Flutterwave.Moneywave.Net.Requests;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
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
            var jsonPayload = JsonConvert.SerializeObject(moneyTransferParams);
            var httpMessage = new HttpRequestMessage(HttpMethod.Post, PaymentEndpoint)
            {
                Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json") // Remember to always add the encoding an content-type here
            };

            var response = await MoneyWaveRequest.Request(httpMessage);
            return response;
        }

    }
}
