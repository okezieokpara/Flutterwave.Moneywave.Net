using Flutterwave.Moneywave.Net.BankAccounts;
using System;

namespace Flutterwave.Moneywave.Net
{
    internal class FlutterwaveMoneyWaveConstants
    {
        public const string LiveUrl = "https://live.moneywaveapi.co";
        public const string DemoUrl = "http://moneywave.herokuapp.com/";
        public const string ApiVersion = "v1";

        public static readonly BankAccount TestAccount1 = new BankAccount("044", "0690000004");
        public static readonly BankAccount TestAccount2 = new BankAccount("044", "0690000005");
        public static readonly BankAccount TestAccount3 = new BankAccount("058", "0921318712");
    }

}
