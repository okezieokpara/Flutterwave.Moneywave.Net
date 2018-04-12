using Flutterwave.Moneywave.Net.Banks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlutterWaveNet.MoneyWave.TestCore
{
    [TestClass]
    public class BanksTests
    {
        [TestMethod]
        public void GetBankListTest()
        {
            var bankList = BankService.GetBankList().Result;
            Assert.IsNotNull(bankList);
            Assert.IsNotNull(bankList.Count > 0);
        }
        [TestMethod]
        ///This test gets all the supported kenyan banks
        public void GetBankListKETest()
        {
            var bankList = BankService.GetBankList("KE").Result;
            Assert.IsNotNull(bankList);
            Assert.IsNotNull(bankList.Count > 0);
        }
    }
}
