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

        public static string ValidateAccountNumber = FlutterwaveMoneyWaveConstants.ApiVersion + "/resolve/account";
        public static string TokenizeCard = FlutterwaveMoneyWaveConstants.ApiVersion + "/transfer/charge/tokenize/card";
        public static string CardEnquiry = FlutterwaveMoneyWaveConstants.ApiVersion + "/user/card/check";
    }
}
