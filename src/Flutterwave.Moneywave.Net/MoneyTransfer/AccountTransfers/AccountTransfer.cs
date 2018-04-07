

using System.Threading.Tasks;
using Flutterwave.Moneywave.Net.Requests;

namespace Flutterwave.Moneywave.Net.MoneyTransfer
{
    public class AccountTransfer : MoneyTransferBase<AccountTransferResponseData>
    {
        protected AccountTransfer(MoneyWavGateWayConfig config) : base(config)
        {
        }

        protected internal override string PaymentEndpoint { get; set; } = Endpoints.Transfer;

        public override Task<MoneywaveResponse<AccountTransferResponseData>> TransferAsync(TransferParamsBase moneyTransferParams)
        {
            throw new System.NotImplementedException();
        }
    }
}
