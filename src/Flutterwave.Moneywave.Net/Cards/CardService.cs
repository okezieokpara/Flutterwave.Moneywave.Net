using Flutterwave.Moneywave.Net.Requests;
using System.Net.Http;
using System.Threading.Tasks;

namespace Flutterwave.Moneywave.Net.Cards
{
    public class CardService
    {
        public CardService(MoneyWavGateWayConfig config)
        {
            Config = config;

        }
        public async Task<MoneywaveResponse<CardTokenizeResponseData>> TokenizeCard(TokenizeCardParams tokenizeCardParams)
        {
            var Request = new MoneyWaveRequest<MoneywaveResponse<CardTokenizeResponseData>, CardTokenizeResponseData>(Config);
            var httpMessage = Request.RequestBuilder.BuildWebRequest(HttpMethod.Post, Endpoints.TokenizeCard, tokenizeCardParams);

            var response = await Request.Request(httpMessage);
            return response;
        }
        MoneyWavGateWayConfig Config { get; }
    }
}
