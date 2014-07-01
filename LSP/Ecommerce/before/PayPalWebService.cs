using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecommerce.before
{
	public class PayPalWebService
	{
		public string GetTransactionToken(string username, string password)
		{
			return "Hello from PayPal";
		}

		public string MakeRefund(decimal amount, string transactionId, string token)
		{
			return "Auth";
		}
	}
}
