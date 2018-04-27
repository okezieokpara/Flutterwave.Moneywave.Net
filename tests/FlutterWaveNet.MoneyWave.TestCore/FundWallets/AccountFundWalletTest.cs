using Flutterwave.Moneywave.Net;
using Flutterwave.Moneywave.Net.FundWalllets;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace FlutterWaveNet.MoneyWave.TestCore.FundWallets
{
    [TestClass]
    public class AccountFundWalletTest
    {
        [TestMethod]
        public void FundWalletFromAccountTest()
        {
            var config = new MoneyWavGateWayConfig(TestConfig.apiKey, TestConfig.apiSecret, false);
            var accountWallet = new AccountFundWallet(config);
            var accountPayParams = new AccountFundWalletParams("Okezie", "Okpara", "+2348067523817", "okeziestanley@gmail.com", 583, "web")
            {
                SenderBank = TestConfig.testAccountBankCode,
                SenderAccountNumber = TestConfig.testAccountNumber

            };
            var apiResponse = accountWallet.Pay(accountPayParams).Result;

            Trace.WriteLine(apiResponse.Data.Authparams[0].Description);
            Trace.WriteLine(apiResponse.Data.ChargeMethod);
            Assert.IsNotNull(apiResponse.Data);
            Assert.AreEqual("success", apiResponse.Status);
            ValidateAccountChargeTest(accountWallet, apiResponse.Data.Transfer.FlutterChargeReference, apiResponse.Data.Authparams[0].Validateparameter);
        }
        private void ValidateAccountChargeTest(AccountFundWallet accountFundWallet, string chargeRef, string authType)
        {
            var validateResponse = accountFundWallet.ValidateCharge(new ValidateAccountChargeParams(chargeRef, authType, "1234")).Result;
            Assert.IsNotNull(validateResponse.Data);
            Assert.AreEqual("success", validateResponse.Status);
        }
    }
}
