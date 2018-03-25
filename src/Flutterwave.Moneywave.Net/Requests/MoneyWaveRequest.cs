using System;

namespace Flutterwave.Moneywave.Net.Requests
{
    internal class MoneyWaveRequest<T1, T2> : MoneyWaveRequestBase<T1, T2> where T1 : IMoneywaveResponse<T2> where T2 : IMoneywaveResponseData
    {
        public MoneyWaveRequest(MoneyWavGateWayConfig config) : base(config)
        {
        }
    }

}
