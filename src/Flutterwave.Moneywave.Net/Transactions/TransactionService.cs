using System;
using Flutterwave.Moneywave.Net.Requests;
using Flutterwave.Moneywave.Net.Transactions.ResponseData;
using System.Net.Http;
using System.Threading.Tasks;

namespace Flutterwave.Moneywave.Net.Transactions
{
    public enum TransactionType { Wallet, Card }
    public class TransactionService
    {
        public TransactionService(MoneyWavGateWayConfig config)
        {
            Config = config;
        }
        private MoneyWavGateWayConfig Config { get; }

        public async Task<MoneywaveResponse<TotalChargeCardResponseData>> GetTotalChargeCard(TotalChargeCardParams totalChargeCardParams)
        {
            var requester = new MoneyWaveRequest<MoneywaveResponse<TotalChargeCardResponseData>, TotalChargeCardResponseData>(Config);
            var httpMessage = requester.RequestBuilder.BuildWebRequest(HttpMethod.Post, Endpoints.GetTotalCardCharge, totalChargeCardParams);
            return await requester.Request(httpMessage);
        }
        public async Task<MoneywaveResponse<FailedTransactionRetryResponseData>> FailedTransactionRetrial(FailedTransactionRetryParams transactionRetryParams)
        {
            var requester = new MoneyWaveRequest<MoneywaveResponse<FailedTransactionRetryResponseData>, FailedTransactionRetryResponseData>(Config);
            var httpMessage = requester.RequestBuilder.BuildWebRequest(HttpMethod.Post, Endpoints.FailedTranxRetry, transactionRetryParams);
            return await requester.Request(httpMessage);
        }
        public async Task<MoneywaveResponse<TransactionStatusResponseData>> TransactionStatusCheck(string @ref)
        {
            var requester = new MoneyWaveRequest<MoneywaveResponse<TransactionStatusResponseData>, TransactionStatusResponseData>(Config);
            var httpMessage = requester.RequestBuilder.BuildWebRequest(HttpMethod.Post, Endpoints.TransactionStatus, new { @ref });
            return await requester.Request(httpMessage);

        }
        public async Task<MoneywaveResponse<PreviousTransactionStatusResponseData>> PreviousTransactionStatus(string idOrRef, TransactionType transactionType)
        {
            if (string.IsNullOrEmpty(idOrRef))
                throw new ArgumentNullException("Please provide a valid transaction id or ref");

            var endpoint = "";
            HttpRequestMessage requestMessage;
            var requester = new MoneyWaveRequest<MoneywaveResponse<PreviousTransactionStatusResponseData>, PreviousTransactionStatusResponseData>(Config);

            switch (transactionType)
            {
                case TransactionType.Card:
                    endpoint = $"{Endpoints.PreviousTransactionCard}/{idOrRef}";
                    requestMessage = requester.RequestBuilder.BuildWebRequest(HttpMethod.Post, endpoint);
                    break;
                case TransactionType.Wallet:
                    requestMessage = requester.RequestBuilder.BuildWebRequest(HttpMethod.Post, Endpoints.PreviousTransactionWallet, new { @ref = idOrRef });
                    break;
                default:
                    requestMessage = new HttpRequestMessage();
                    break;
            }
            return await requester.Request(requestMessage);
        }

    }
}
