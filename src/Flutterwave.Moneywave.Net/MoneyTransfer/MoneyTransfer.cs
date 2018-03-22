using System;
using System.Net.Http;
using System.Threading.Tasks;
using Flutterwave.Moneywave.Net.Requests;
using Newtonsoft.Json;

namespace Flutterwave.Moneywave.Net.MoneyTransfer
{
    public class MoneyTransfer
    {
        private MoneyWaveRequest _request;
        private const string TransferEndpoint = "/v1/transfer";

        public MoneyTransfer(MoenyWavGateWayConfig config)
        {
            _request = new MoneyWaveRequest(config);
        }

        public async Task<MoneywaveResponse> CardToAccountTransfer(TransferRequest trasnferRequest)
        {
            var jsonRequestBody = JsonConvert.SerializeObject(trasnferRequest);
            var httpRequest =
                new HttpRequestMessage(new HttpMethod("POST"), new Uri(TransferEndpoint))
                {
                    Content = new StringContent(jsonRequestBody)
                };
            var response = await _request.Request(httpRequest);
            return response;
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
