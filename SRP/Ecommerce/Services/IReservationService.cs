using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ecommerce.Model;

namespace Ecommerce.Services
{
	public interface IReservationService
	{
		void ReserveInventory(IEnumerable<OrderItem> items);
	}
}
