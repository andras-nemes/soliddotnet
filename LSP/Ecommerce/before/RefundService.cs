using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecommerce.before
{
	public class RefundService
	{
		public bool Refund(PaymentServiceType paymentServiceType, decimal amount, string transactionId)
		{
			PaymentBase payment = PaymentFactory.GetPaymentService(paymentServiceType);
			return payment.Refund(amount, transactionId);
		}
	}
}
