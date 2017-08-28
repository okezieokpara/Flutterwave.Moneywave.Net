using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flutterwave.Moneywave.Net.MoneyTransfer
{
	/// <summary>
	/// Builds a request for money transfer
	/// </summary>
	public class TransferRequest
	{
		/// <summary>
		/// Personal details of sender
		/// </summary>
		public PersonalDetails SenderInfomation { get; set; }
		/// <summary>
		/// Account details of recipient
		/// </summary>
		public AccountDetails RecipientInformation { get; set; }
		/// <summary>
		/// the url to redirect to after transaction has been successfully validated
		/// </summary>
		public string RedirectUrl { get; set; }
		/// <summary>
		/// this is the amount to send to the beneficiary
		/// </summary>
		public decimal Amount { get; set; }
		/// <summary>
		/// your merchant apiKey displayed to you after registering as a merchant.
		/// </summary>
		public string ApiKey { get; set; }
		/// <summary>
		/// the amount the merchant wants to add as his commission
		/// </summary>
		public decimal Fee { get; set; }
		/// <summary>
		/// this can either be web or mobile or depending on request medium
		/// </summary>
		public string Medium { get; set; }

		/// <summary>
		/// (optional) - this is the currency in which card will be charged
		/// </summary>
		public string ChargeCurrency { get; set; }

		/// <summary>
		/// (optional) - this is the currency in which account will be credited
		/// </summary>
		public string DisburseCurrency { get; set; }

		/// <summary>
		/// (optional) - charge method : card, account, token or tokenized_card
		/// </summary>
		public string ChargeWith { get; set; }

		/// <summary>
		/// (optional) - card last 4 digits, required in charge with token
		/// </summary>
		public string CardLast4 { get; set; }
		/// <summary>
		/// (optional) - card token, required in charge with tokenized card
		/// </summary>
		public string CardToken { get; set; }

		/// <summary>
		/// (optional)- charge source, required in charge with account
		/// </summary>
		public string SenderAccountNumber { get; set; }

		/// <summary>
		/// (optional) - charge source bank, required in charge with account
		/// </summary>
		public string SenderBank { get; set; }

		/// <summary>
		/// (optional)- Account Security PIN required for account charge
		/// </summary>
		public string PassCode { get; set; }

		/// <summary>
		/// (optional) - card ID required when charging with token
		/// </summary>
		public string CardId { get; set; }

		/// <summary>
		/// (optional) - sheduled / recurring transfer cycle
		/// </summary>
		public string Cycle { get; set; }

		/// <summary>
		/// (optional) - sheduled / recurring start date
		/// </summary>
		public string StartDate { get; set; }
		/// <summary>
		/// (optional)- sheduled / recurring end date
		/// </summary>
		public string EndDate { get; set; }

	}
}
