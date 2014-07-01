using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecommerce.Model
{
	public class PaymentDetails
	{
		public PaymentMethod PaymentMethod { get; set; }
		public string CreditCardNumber { get; set; }
		public DateTime ExpiryDate { get; set; }
		public string CardholderName { get; set; }
	}
}
