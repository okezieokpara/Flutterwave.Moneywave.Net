using Microsoft.Extensions.Configuration;

namespace FlutterWaveNet.MoneyWave.TestCore
{
    public static class TestConfig
    {
        private static readonly IConfiguration Config = new ConfigurationBuilder().AddJsonFile("appSettings.json").Build();
        public static string apiKey = Config["ApiKey"];
        public static string apiSecret = Config["ApiSecret"];

        public static string testCard1No = Config["TestCards:0:CardNumber"];
        public static string testCard1CVV = Config["TestCards:0:CVV"];
        public static string testCard1ExpiryMonth = Config["TestCards:0:ExpiryMonth"];
        public static string testCard1ExpiryYear = Config["TestCards:0:ExpiryYear"];
        public static string testCard1Pin = Config["TestCards:0:Pin"];
        public static string testCard1OTP = Config["TestCards:0:OTP"];

        public static string firstWalletName = Config["TestWallet:0:Name"];
        public static string firstWalletPassword = Config["TestWallet:0:Password"];

        public static string secondtWalletName = Config["TestWallet:1:Name"];
        public static string secondWalletPassword = Config["TestWallet:1:Password"];

        public static string testAccountBankCode = Config["TestAccounts:0:BankCode"];
        public static string testAccountNumber = Config["TestAccounts:0:AccountNumber"];

    }
}
