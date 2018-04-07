using Flutterwave.Moneywave.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace FlutterWaveNet.MoneyWave.TestCore
{
    [TestClass]
    public class ConfigurationTests
    {
        [TestMethod]
        public void GenerateMerchantTokenTest()
        {
            var moneyWaveConfig = new MoneyWavGateWayConfig(TestConfig.apiKey, TestConfig.apiSecret, false);
            var token = moneyWaveConfig.RequestToken().Result;

            Assert.IsNotNull(token);
            Assert.IsNotNull(token.Config);
            Assert.IsTrue(!string.IsNullOrEmpty(token.Token));
            Assert.AreEqual(token.Status, "success");
            Trace.WriteLine(token.Token);
        }

       
    }
}
