namespace Flutterwave.Moneywave.Net.Requests
{
    internal static class Endpoints
    {
        public const string AccessToken = FlutterwaveMoneyWaveConstants.ApiVersion + "/merchant/verify";
        public static string Transfer = FlutterwaveMoneyWaveConstants.ApiVersion + "/transfer";
        public static string WalletToWalletTransfer = FlutterwaveMoneyWaveConstants.ApiVersion + "/wallet/transfer";
        public static string WalletToAccountTransfer = FlutterwaveMoneyWaveConstants.ApiVersion + "/disburse";
        public static string ValidateCharge = FlutterwaveMoneyWaveConstants.ApiVersion + "/transfer/charge/auth/card";
        public static string BanksList = "/banks";
    }
}
