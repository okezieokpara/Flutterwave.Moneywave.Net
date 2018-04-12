using Flutterwave.Moneywave.Net;
using Flutterwave.Moneywave.Net.Cards;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace FlutterWaveNet.MoneyWave.TestCore
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void TokenizeCardTest()
        {
            var config = new MoneyWavGateWayConfig(TestConfig.apiKey, TestConfig.apiSecret, false);
            var cardService = new CardService(config);

        }

    }
}
