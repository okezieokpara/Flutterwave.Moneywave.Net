using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flutterwave.Moneywave.Net
{
    public class MerchantToken
    {
        public MerchantToken()
        {

        }
        public MerchantToken(string status, string token)
        {
            Status = status;
            Token = token;
        }
        public string Status { get; set; }
        public string Token { get; set; }
    }
}
