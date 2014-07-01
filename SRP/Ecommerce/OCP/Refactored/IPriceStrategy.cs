using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ecommerce.Model.OCP;

namespace Ecommerce.OCP.Refactored
{
	public interface IPriceStrategy
	{
		bool IsMatch(OrderItem item);
		decimal CalculatePrice(OrderItem item);
	}
}
