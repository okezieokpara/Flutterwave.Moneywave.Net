using System;

namespace Flutterwave.Moneywave.Net
{
    public class FlutterwaveMoneyWaveConstants
    {
        public const string LiveUrl = "https://live.moneywaveapi.co";
        public const string DemoUrl = "http://moneywave.herokuapp.com/";
        public const string ApiVersion = "v1";

        public static readonly AccountDetails TestAccount1 = new AccountDetails("044", "0690000004");
        public static readonly AccountDetails TestAccount2 = new AccountDetails("044", "0690000005");
        public static readonly AccountDetails TestAccount3 = new AccountDetails("058", "0921318712");
    }

}
