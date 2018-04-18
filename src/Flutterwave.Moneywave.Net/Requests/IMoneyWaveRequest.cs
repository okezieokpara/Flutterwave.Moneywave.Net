using System.Net.Http;
using System.Threading.Tasks;

namespace Flutterwave.Moneywave.Net.Requests
{
    internal interface IMoneyWaveRequest<T1, T2> where T1 : IMoneywaveResponse<T2> where T2 : IMoneywaveResponseData
    {
        MoneyWavGateWayConfig Config { get; }
        Task<MoneywaveResponse<T2>> Request(HttpRequestMessage requestBody);
        IWebRequestBuilder RequestBuilder { get; }
    }
}
