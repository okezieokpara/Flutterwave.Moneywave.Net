using System;
using System.Collections.Generic;
using System.Linq;

namespace Flutterwave.Moneywave.Net.Banks
{
    public class Bank
    {
        public Bank()
        {

        }
        public Bank(string bankCode, string name)
        {
            BankCode = bankCode;
            Name = name;
        }
        public string BankCode { get; set; }
        public string Name { get; set; }
    }
}
