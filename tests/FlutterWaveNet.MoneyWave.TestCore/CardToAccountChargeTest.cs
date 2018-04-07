using Flutterwave.Moneywave.Net;
using Flutterwave.Moneywave.Net.Cards;
using Flutterwave.Moneywave.Net.MoneyTransfer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlutterWaveNet.MoneyWave.TestCore
{
    [TestClass]
    public class CardToAccountChargeTest
    {
        [TestMethod]
        public void CardToAccountTest()
        {
            var moneyWaveConfig = new MoneyWavGateWayConfig(
                TestConfig.apiKey, TestConfig.apiSecret, false);
            var cardTransfer = new CardTransfer(moneyWaveConfig);

            var debitCard = new Card(TestConfig.testCard1No, TestConfig.testCard1ExpiryMonth, TestConfig.testCard1ExpiryYear, TestConfig.testCard1CVV, TestConfig.testCard1Pin);
            var cardParams = new CardTransferParams("Okezie", "Okpara", "okezieokpara@yahoo.com", "+2348022336925", 500m, debitCard)
            {
                Medium = "app"
            };
            var transferResponse = cardTransfer.TransferAsync(cardParams).Result;
            Assert.AreEqual(transferResponse.Status, "success");
            Assert.IsNotNull(transferResponse.Data);
            Assert.IsNotNull(transferResponse.Data.Transfer);

       

        }
    }
}
