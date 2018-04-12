using Flutterwave.Moneywave.Net;
using Flutterwave.Moneywave.Net.BankAccounts;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace FlutterWaveNet.MoneyWave.TestCore
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void ValidateAccountNumberTest()
        {
            var config = new MoneyWavGateWayConfig(TestConfig.apiKey, TestConfig.apiSecret, false);
            var bankacountService = new BankAccountService(config);
            var bankAccount = new BankAccount("044", "0690000005");
            var response = bankacountService.ValidateAccountNumber(bankAccount).Result;

            Assert.IsNotNull(response.Data);
            Assert.AreEqual(response.Status, "success");
        }
        [TestMethod]
        public void ValidateAccounNumberObjTest()
        {
            var config = new MoneyWavGateWayConfig(TestConfig.apiKey, TestConfig.apiSecret, false);
            var bankacountService = new BankAccountService(config);

            var response = bankacountService.ValidateAccountNumber("0690000005", "044").Result;

            Assert.IsNotNull(response.Data);
            Assert.AreEqual(response.Status, "success");
        }
    }
}
