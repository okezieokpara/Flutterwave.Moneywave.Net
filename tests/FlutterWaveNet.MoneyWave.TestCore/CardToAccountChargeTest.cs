using Flutterwave.Moneywave.Net;
using Flutterwave.Moneywave.Net.Cards;
using Flutterwave.Moneywave.Net.MoneyTransfer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

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

            var debitCard = new Card(TestConfig.testCard1No, TestConfig.testCard1ExpiryMonth, TestConfig.testCard1ExpiryYear, TestConfig.testCard1CVV);
            var transferResponse = cardTransfer.Transfer(new CardTransferParams("Okezie", "Okpara", 598m, debitCard)).Result;
            Assert.IsNotNull(transferResponse.Data);
            Assert.IsTrue(string.IsNullOrEmpty(transferResponse.Message));
            Trace.WriteLine(transferResponse.Message);
            Trace.WriteLine(transferResponse.Status);
            
        }
    }
}
