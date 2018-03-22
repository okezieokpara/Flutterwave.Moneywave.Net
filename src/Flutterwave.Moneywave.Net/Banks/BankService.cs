using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Flutterwave.Moneywave.Net.Requests;

namespace Flutterwave.Moneywave.Net.Banks
{
    /// <summary>
    /// Utility for bank services
    /// </summary>
    public class BankService
    {
        /// <summary>
        /// Retrieve all banks and their codes
        /// </summary>
        /// <returns>A list of all banks and their respective codes</returns>
        /// <remarks>endpoint "/banks"</remarks>
        public async Task<MoneywaveResponse> GetAllBanks()
        {
            MoneywaveResponse result = null;
            const string bankEndpoint = "banks";
            string enpointUrl = FlutterwaveMoneyWaveConstants.DemoUrl + bankEndpoint;

            var client = new HttpClient() { BaseAddress = new Uri(FlutterwaveMoneyWaveConstants.DemoUrl) };
            client.DefaultRequestHeaders.Accept.Clear();
         //   client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.PostAsync(bankEndpoint, new StringContent(""));
            if (response.IsSuccessStatusCode)
            {
                var resultString = await response.Content.ReadAsStringAsync();
             //   result = JsonConvert.DeserializeObject<MoneywaveResponse>(resultString);
            }


            return result;
        }
    }
}
