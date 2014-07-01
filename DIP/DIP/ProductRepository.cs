using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP
{
	public class ProductRepository : IProductRepository
	{	

		public ProductRepository()
		{
			//do nothing with the time provider context right now but it may be needed later
		}

		public IEnumerable<Product> FindAll()
		{
			return new List<Product>();
		}
	}
}
