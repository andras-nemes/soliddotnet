using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecommerce.before
{
	public class WorldPayWebService
	{
		public string MakeRefund(decimal amount, string transactionId, string username,
			string password, string productId)
		{
			return "Success";
		}
	}
}
