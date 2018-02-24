
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Flutterwave.Moneywave.Net;
using System.Diagnostics;
using System.Configuration;
namespace FlutterWaveNet.MoneyWave.Test
{
    [TestClass]
    public class ConfigTests
    {
        [TestMethod]
        public void TestGetMerchantToken()
        {
            // Arrange
            var apiKey = ConfigurationSettings.AppSettings["FlutterWave.MoneyWave.ApiKey"];
            var apiSecret = ConfigurationSettings.AppSettings["FlutterWave.MoneyWave.ApiSecret"];

            var config = new MoenyWavGateWayConfig(apiKey, apiSecret);
            var request = new MoneyWaveRequest(config);

            //Act

            var token = request.RequestToken().Result;
            //Assert
            Trace.WriteLine(token.Status);
            Trace.WriteLine(token.Token);

            Assert.IsInstanceOfType(token.Token, typeof(string));
        }
    }
}
