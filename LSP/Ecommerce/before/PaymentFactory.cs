using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecommerce.before
{
	public class PaymentFactory
	{
		public static PaymentBase GetPaymentService(PaymentServiceType serviceType)
		{
			switch (serviceType)
			{
				case PaymentServiceType.PayPal:
					return new PayPalPayment("Andras", "Passw0rd");
				case PaymentServiceType.WorldPay:
					return new WorldPayPayment("Andras", "Passw0rd", "ABC");
				default:
					throw new NotImplementedException("No such service.");
			}
		}
	}
}
