using System;
using System.Threading.Tasks;
using Flutterwave.Moneywave.Net.Requests;
using Newtonsoft.Json;

namespace Flutterwave.Moneywave.Net.MoneyTransfer
{
    public class WalletTransfer : MoneyTransferBase<WalletTransferResponseData>
    {
        public WalletTransfer(MoneyWavGateWayConfig config) : base(config)
        {
        }

        protected internal override string PaymentEndpoint { get; set; } = Endpoints.WalletToWalletTransfer;

        public override async Task<MoneywaveResponse<WalletTransferResponseData>> TransferAsync(TransferParamsBase moneyTransferParams)
        {

            // Todo implement this once in the base class and customize as needed
            // Todo: Verify the type of transfer from the params and switch endpoints
            if (!(moneyTransferParams is WalletTransferParamsBase))
            {
                // Todo check for type mismatch in transfer parameters
                throw new ArgumentException(message: $"The {nameof(moneyTransferParams)} parameter must be of {nameof(WalletTransferParamsBase)} type");
            }
            switch (moneyTransferParams) // This is a C# 7 feature "Switch statement pattern matching". Take Note
            {
                case WalletToWalletTransferParams walletToWalletParams:
                    PaymentEndpoint = Endpoints.WalletToWalletTransfer;
                    break;
                case WalletToAccountTransferParams walletToAccountParams:
                    PaymentEndpoint = Endpoints.WalletToAccountTransfer;
                    break;
                default:
                    PaymentEndpoint = Endpoints.WalletToWalletTransfer;
                    break;

            }

            return await base.TransferAsync(moneyTransferParams);
        }
    }
}
