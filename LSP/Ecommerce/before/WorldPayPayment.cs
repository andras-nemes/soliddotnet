using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecommerce.before
{
	public class WorldPayPayment : PaymentBase
	{
		public WorldPayPayment(string accountId, string password, string productId)
		{
			AccountName = accountId;
			Password = password;
			ProductId = productId;
		}

		public string AccountName { get; set; }
		public string Password { get; set; }
		public string ProductId { get; set; }

		public override bool Refund(decimal amount, string transactionId)
		{
			WorldPayWebService worldPayWebService = new WorldPayWebService();
			string response = worldPayWebService.MakeRefund(amount, transactionId, AccountName, Password, ProductId);
			if (response.Contains("Auth"))
				return true;
			return false;
		}
	}
}
