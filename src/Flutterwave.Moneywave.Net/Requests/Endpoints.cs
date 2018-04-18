namespace Flutterwave.Moneywave.Net.Requests
{
    internal static class Endpoints
    {
        public const string AccessToken = FlutterwaveMoneyWaveConstants.ApiVersion + "/merchant/verify";
        public const string Transfer = FlutterwaveMoneyWaveConstants.ApiVersion + "/transfer";
        public const string WalletToWalletTransfer = FlutterwaveMoneyWaveConstants.ApiVersion + "/wallet/transfer";
        public const string WalletToAccountTransfer = FlutterwaveMoneyWaveConstants.ApiVersion + "/disburse";
        public const string ValidateCharge = FlutterwaveMoneyWaveConstants.ApiVersion + "/transfer/charge/auth/card";
        public const string BanksList = "/banks";

        public const string ValidateAccountNumber = FlutterwaveMoneyWaveConstants.ApiVersion + "/resolve/account";
        public const string TokenizeCard = FlutterwaveMoneyWaveConstants.ApiVersion + "/transfer/charge/tokenize/card";
        public const string CardEnquiry = FlutterwaveMoneyWaveConstants.ApiVersion + "/user/card/check";

        public const string GetTotalCardCharge = FlutterwaveMoneyWaveConstants.ApiVersion + "/get-charge";
        public const string FailedTranxRetry = FlutterwaveMoneyWaveConstants.ApiVersion + "/transfer/disburse/retry";
        public const string PreviousTransactionCard = FlutterwaveMoneyWaveConstants.ApiVersion + "/transfer/";
        public const string PreviousTransactionWallet = FlutterwaveMoneyWaveConstants.ApiVersion + "/disburse/status";
        public const string TransactionStatus = FlutterwaveMoneyWaveConstants.ApiVersion + "/transfer/charge/status";

    }
}
