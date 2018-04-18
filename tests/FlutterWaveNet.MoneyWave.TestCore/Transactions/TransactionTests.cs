using Flutterwave.Moneywave.Net;
using Flutterwave.Moneywave.Net.Transactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace FlutterWaveNet.MoneyWave.TestCore.Transactions
{
    [TestClass]
    public class TransactionTests
    {
        [TestMethod]
        public void GetTotalChargetoCardTest()
        {
            var config = new MoneyWavGateWayConfig(TestConfig.apiKey, TestConfig.apiSecret, false);
            var tranxService = new TransactionService(config);

            var response = tranxService.GetTotalChargeCard(new TotalChargeCardParams(499, 45)).Result;
            Assert.IsNotNull(response.Data);


        }
        [TestMethod]
        public void FailedTransactionRetrialTest()
        {
            var config = new MoneyWavGateWayConfig(TestConfig.apiKey, TestConfig.apiSecret, false);
            var tranxService = new TransactionService(config);
            var response = tranxService.FailedTransactionRetrial(new FailedTransactionRetryParams("id", "494", "49")).Result;
            Assert.IsNotNull(response.Data);
            Assert.AreEqual(response.Status, "success");
        }
        [TestMethod]
        public void PreviousTransationCardTest()
        {
            var config = new MoneyWavGateWayConfig(TestConfig.apiKey, TestConfig.apiSecret, false);
            var tranxService = new TransactionService(config);

            var response = tranxService.PreviousTransactionStatus("939", TransactionType.Card).Result;
            Assert.IsNotNull(response.Data);
            Assert.AreEqual(response.Status, "success");
        }
        public void PreviousTransactionWalletTest()
        {
            var config = new MoneyWavGateWayConfig(TestConfig.apiKey, TestConfig.apiSecret, false);
            var tranxService = new TransactionService(config);

            var response = tranxService.PreviousTransactionStatus("939", TransactionType.Wallet).Result;
            Assert.IsNotNull(response.Data);
            Assert.AreEqual(response.Status, "success");
        }
    }
}
