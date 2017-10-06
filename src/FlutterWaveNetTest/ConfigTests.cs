using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Flutterwave.Moneywave.Net;

namespace FlutterWaveNetTest
{
    [TestClass]
    public class ConfigTests
    {
        [TestMethod]
        public void TestGetMerchantToken()
        {
            // Arrange
            var config = new MoenyWavGateWayConfig();
            var request = new MoneyWaveRequest(config);

            //Act

            var token = request.RequestToken();
            //Assert

            Assert.Fail("Error");
        }
    }
}
