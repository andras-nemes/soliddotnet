using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecommerce.Services
{
	public class InventoryService
	{
		public void Reserve(string identifier, int quantity)
		{
			throw new InsufficientInventoryException();
		}
	}

	public class InsufficientInventoryException : Exception
	{
	}
}
