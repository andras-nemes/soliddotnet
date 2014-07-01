using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ecommerce.Model;

namespace Ecommerce.SRP
{
	class CashOrder : Order
	{
		public CashOrder(ShoppingCart shoppingCart)
			: base(shoppingCart)
		{ }
	}
}
