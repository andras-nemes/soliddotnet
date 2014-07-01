using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecommerce.before
{
	public abstract class PaymentBase
	{
		public abstract bool Refund(decimal amount, string transactionId);
	}
}
