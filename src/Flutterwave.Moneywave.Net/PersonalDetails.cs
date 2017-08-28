using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flutterwave.Moneywave.Net
{
	public class PersonalDetails
	{
		/// <summary>
		/// First name of person
		/// </summary>
		[JsonProperty("firstname")]
		public string FirstName { get; set; }

		/// <summary>
		/// Last name of the person
		/// </summary>
		[JsonProperty("lastname")]
		public string LastName { get; set; }
		/// <summary>
		/// Phone number of the person
		/// </summary>
		[JsonProperty("phonenumber")]
		public string PhoneNumber { get; set; }
		/// <summary>
		/// Email address of the person
		/// </summary>
		[JsonProperty("email")]
		public string EmailAddress { get; set; }

	}
}
