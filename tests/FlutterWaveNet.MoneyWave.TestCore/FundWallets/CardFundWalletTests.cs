using Flutterwave.Moneywave.Net;
using Flutterwave.Moneywave.Net.Cards;
using Flutterwave.Moneywave.Net.FundWalllets;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace FlutterWaveNet.MoneyWave.TestCore.FundWallets
{
    [TestClass]
    public class CardFundWalletTests
    {
        [TestMethod]
        public void FundWalletWithCardTest()
        {
            var config = new MoneyWavGateWayConfig(TestConfig.apiKey, TestConfig.apiSecret, false);
            var cardFundWallet = new CardFundWallet(config);
            var card = new Card(TestConfig.testCard1No, TestConfig.testCard1ExpiryMonth, TestConfig.testCard1ExpiryYear, TestConfig.testCard1CVV, TestConfig.testCard1Pin);
            var apiResponse = cardFundWallet.Pay(new CardFundWalletParams("Okezie", "Okpara", "+2348022336925", "okezie@okezie.com", 4945.49m, "web", card) { RecipientId = "0" }
                ).Result;

            Assert.IsNotNull(apiResponse.Data);
            Assert.AreEqual("success", apiResponse.Status);

        }
    }
}
