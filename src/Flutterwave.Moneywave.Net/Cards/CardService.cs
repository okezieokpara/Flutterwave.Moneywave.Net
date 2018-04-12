using Flutterwave.Moneywave.Net.Requests;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Flutterwave.Moneywave.Net.Cards
{
    public class CardService
    {
        public CardService(MoneyWavGateWayConfig config)
        {
            Config = config;
            Request = new MoneyWaveRequest<MoneywaveResponse<CardTokenizeResponseData>, CardTokenizeResponseData>(config);
        }
        public async Task<MoneywaveResponse<CardTokenizeResponseData>> TokenizeCard(TokenizeCardParams tokenizeCardParams)
        {
            var jsonPayload = JsonConvert.SerializeObject(tokenizeCardParams);

            var httpMessage = new HttpRequestMessage(HttpMethod.Post, Endpoints.TokenizeCard)
            {
                Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json") // Remember to always add the encoding an content-type here
            };

            var response = await Request.Request(httpMessage);
            return response;

        }
        MoneyWavGateWayConfig Config { get; }
        internal MoneyWaveRequest<MoneywaveResponse<CardTokenizeResponseData>, CardTokenizeResponseData> Request { get; }
    }
}
