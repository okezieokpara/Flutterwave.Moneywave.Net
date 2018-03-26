namespace Flutterwave.Moneywave.Net.Requests
{
    public static class Endpoints
    {
        public const string AccessToken = FlutterwaveMoneyWaveConstants.ApiVersion + "/merchant/verify";
        public static string Transfer = FlutterwaveMoneyWaveConstants.ApiVersion + "/transfer";
        public static string ValidateCharge = FlutterwaveMoneyWaveConstants.ApiVersion + "/transfer/charge/auth/card";
        public static string BanksList = "/banks";
    }
}
