using Newtonsoft.Json;
using System;


namespace Flutterwave.Moneywave.Net.FundWalllets
{
    public class AccountFundWalletResponseData : FundWalletResponseDataBase
    {
        [JsonProperty("authparams")]
        public AuthParam[] Authparams { get; set; }

        public class AuthParam
        {
            [JsonProperty("validateparameter")]
            public string Validateparameter { get; set; }
            [JsonProperty("description")]
            public string Description { get; set; }
        }
    }
}
