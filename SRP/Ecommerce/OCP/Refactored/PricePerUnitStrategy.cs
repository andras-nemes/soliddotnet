using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ecommerce.Model.OCP;

namespace Ecommerce.OCP.Refactored
{
	public class PricePerUnitStrategy : IPriceStrategy
	{
		public bool IsMatch(OrderItem item)
		{
			return item.Identifier.StartsWith("Each");
		}

		public decimal CalculatePrice(OrderItem item)
		{
			return item.Quantity * 4m;
		}
	}
}
