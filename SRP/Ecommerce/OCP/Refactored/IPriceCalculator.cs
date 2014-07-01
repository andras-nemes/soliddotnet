using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ecommerce.Model.OCP;

namespace Ecommerce.OCP.Refactored
{
	public interface IPriceCalculator
	{
		decimal CalculatePrice(OrderItem item);
	}
}
