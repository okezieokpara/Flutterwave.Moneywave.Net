using System;


namespace Flutterwave.Moneywave.Net
{
    public class MoenyWavGateWayConfig
    {

        public MoenyWavGateWayConfig(bool isLive)
        {
            IsLive = isLive;
            ApiVersion = "v1";
        }

        public MoenyWavGateWayConfig(bool isLive = false, string apiVersion = "v1")
        {
            IsLive = isLive;
            ApiVersion = apiVersion;
        }
        public MoenyWavGateWayConfig(string apiKey, string apiSecret, bool isLive = false, string apiVersion = "v1")
        {
            IsLive = isLive;
            ApiVersion = apiVersion;
            ApiKey = apiKey;
            SecretKey = apiSecret;
        }

        public bool IsLive { get; set; }
        /// <summary>
        /// The API Key given to your account
        /// </summary>
        public string ApiKey { get; set; }
        public string SecretKey { get; set; }
        /// <summary>
        /// The current api version to use
        /// Defaut is v1
        /// </summary>
        public string ApiVersion { get; set; }


        public MerchantToken CreateAccessToken()
        {
            return new MerchantToken();
        }

    }

}
