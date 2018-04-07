
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Flutterwave.Moneywave.Net.Requests;
using Newtonsoft.Json;

namespace Flutterwave.Moneywave.Net.MoneyTransfer
{
    /// <summary>
    /// Card to Account transfer.
    /// with this class, you can charge any card or account and disburse into any provided bank account instantly.
    /// </summary>
    public class CardTransfer : MoneyTransferBase<CardTransferResponseData>
    {
        public CardTransfer(MoneyWavGateWayConfig config) : base(config)
        {

        }

        protected internal override string PaymentEndpoint { get; set; } = Endpoints.Transfer; // For clarity this may be implemented in the constructor

        public override async Task<MoneywaveResponse<CardTransferResponseData>> TransferAsync(TransferParamsBase moneyTransferParams)
        {
            if (!(moneyTransferParams is CardTransferParams))
            {
                // Todo check for type mismatch in transfer parameters
                throw new ArgumentException(message: $"The {nameof(moneyTransferParams)} parameter must be of {nameof(CardTransferParams)} type");
            }
            return await base.TransferAsync(moneyTransferParams);
        }

    }
}
