using Newtonsoft.Json;

namespace Flutterwave.Moneywave.Net.MoneyTransfer
{
	/// <summary>
	/// Request data for Wallet transfer request
	/// </summary>
	public class WalletTransferRequest
	{

		/// <summary>
		/// the password of your wallet
		/// </summary>
		[JsonProperty("lock")]
		public string Lock { get; set; }
		/// <summary>
		/// the amount to send to the beneficiary
		/// </summary>
		[JsonProperty("amount")]
		public decimal Amount { get; set; }

		/// <summary>
		/// the bankcode of the bank to send money to
		/// </summary>
		[JsonProperty("bankcode")]
		public string BankCode { get; set; }
		/// <summary>
		/// the account number of the recipient
		/// </summary>

		[JsonProperty("accountNumber")]
		public string AccountNumber { get; set; }

		/// <summary>
		/// the currency to send money in
		/// </summary>
		[JsonProperty("currency")]
		public string Currency { get; set; }


		/// <summary>
		/// the name of the sender
		/// </summary>
		[JsonProperty("senderName")]
		public string SenderName { get; set; }

		/// <summary>
		/// unique transaction ref
		/// </summary>
		[JsonProperty("ref")]
		public string Ref { get; set; }

	}
}
