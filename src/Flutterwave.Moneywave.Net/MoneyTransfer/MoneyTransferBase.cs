using Flutterwave.Moneywave.Net.Requests;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Flutterwave.Moneywave.Net.MoneyTransfer
{

    public abstract class MoneyTransferBase : IMoneyTransfer<TransferParamsBase>
    {
        private MoneyWaveRequest<MoneywaveResponse<MoneyTransferResponseData>, MoneyTransferResponseData> _moneyWaveRequest;
        protected MoneyTransferBase(MoneyWavGateWayConfig config)
        {
            if (config == null)
            {
                throw new ArgumentException("The Config object cannot be null");
            }
            _moneyWaveRequest = new MoneyWaveRequest<MoneywaveResponse<MoneyTransferResponseData>, MoneyTransferResponseData>(config);
        }
        public virtual async Task<MoneywaveResponse<MoneyTransferResponseData>> Transfer(TransferParamsBase moneyTransferParams)
        {
            var jsonPayload = JsonConvert.SerializeObject(moneyTransferParams);
            var httpMessage = new HttpRequestMessage(HttpMethod.Post, Endpoints.Transfer)
            {
                Content = new StringContent(jsonPayload)
            };

            var response = await _moneyWaveRequest.Request(httpMessage);

            return (MoneywaveResponse<MoneyTransferResponseData>)response;
        }

    }
}
