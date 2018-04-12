using Flutterwave.Moneywave.Net;
using Flutterwave.Moneywave.Net.MoneyTransfer;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace FlutterWaveNet.MoneyWave.TestCore
{
    [TestClass]
    public class WalletTransferTests
    {
        [TestMethod]
        public void WalletToWalletTransferTest()
        {
            var moneyWaveConfig = new MoneyWavGateWayConfig(TestConfig.apiKey, TestConfig.apiSecret, false);
            var walletTransfer = new WalletTransfer(moneyWaveConfig);

            var walletToWalletParams = new WalletToWalletTransferParams("0", "1", 5094, TestConfig.firstWalletPassword);
            var walletResponse = walletTransfer.TransferAsync(walletToWalletParams).Result;

            Assert.IsNotNull(walletResponse.Data);
            Assert.AreEqual(walletResponse.Status, "success");

        }

        [TestMethod]
        public void WalletToAccontTransferTest()
        {
            var moneyWaveConfig = new MoneyWavGateWayConfig(TestConfig.apiKey, TestConfig.apiSecret, false);
            var walletTransfer = new WalletTransfer(moneyWaveConfig);
            var walletToAccountParams = new WalletToAccountTransferParams(TestConfig.testAccountBankCode, TestConfig.testAccountNumber, "Okezie", 500m, "Password123");

            var response = walletTransfer.TransferAsync(walletToAccountParams).Result;

            Assert.IsNotNull(response.Data);
            Assert.AreEqual(response.Status, "success");

        }
    }
}
